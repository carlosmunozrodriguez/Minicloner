function Invoke-Task {
    <#
    .SYNOPSIS
    Runs the code passes as a parameter. This code defines a task
    .DESCRIPTION
    Normal task runners define a task to be executed a later step. This function on the other hand defines and executes it immediately
    .PARAMETER Name
    Name of the task to be written to the standard output
    .PARAMETER Action
    Script to be run as part of the execution of the task
    #>
    [CmdletBinding()]
    param(
        [String]
        $Name,
        
        [ScriptBlock]
        $Action
    )
    process {
        Write-Host "-------------------------------------"
        Write-Host "Starting task: $Name"
        Write-Host "-------------------------------------"
        $sw = [System.Diagnostics.Stopwatch]::StartNew()
        & $Action
        $sw.Stop()
        
        if ($lastExitCode -eq 0) {
            Write-Host "-------------------------------------"
            Write-Host "Finished task: $Name"
            Write-Host "Task completed in" $sw.Elapsed.ToString()
            Write-Host "-------------------------------------"
        } else {
            Write-Host "-------------------------------------"
            Write-Host "Task: $Name failed"
            Write-Host "Task failed in" $sw.Elapsed.ToString()
            Write-Host "-------------------------------------"
            exit 1
        }
    }
}

Invoke-Task AutomatedBuild {
    Invoke-Task Get-DotNet {
        $dotnetVersion = "1.0.1"

        if ($IsLinux -or $IsOsX) {
            bash ./dotnet-install.sh -Version $dotnetVersion
        } else {
            ./dotnet-install.ps1 -Version $dotnetVersion
        }
    }

    Invoke-Task Info {
        dotnet --info
    }

    Invoke-Task Restore {
        dotnet restore --verbosity detailed
    }

    Invoke-Task Build {
        dotnet build --configuration Release --verbosity normal
    }

    Invoke-Task Test {
        dotnet test test/Minicloner.Tests/Minicloner.Tests.csproj --configuration Release --logger "trx;" --no-build --verbosity minimal
    }
}