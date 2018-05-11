Import-Module ./invoke-task.psm1

Invoke-Task AutomatedBuild {
    Invoke-Task Get-DotNet-Sdk {
        $dotnetSdkVersion = "2.1.200"

        if ($IsLinux -or $IsOsX) {
            bash ./dotnet-install.sh -Channel Current -Version $dotnetSdkVersion
        } else {
            ./dotnet-install.ps1 -Channel Current -Version $dotnetSdkVersion
        }
    }

    Invoke-Task Info {
        dotnet --info
    }

    Invoke-Task Clean {
        dotnet clean
    }

    Invoke-Task Build {
        dotnet build --configuration Release
    }

    Invoke-Task Test {
        dotnet test test/Minicloner.Tests/Minicloner.Tests.csproj --configuration Release --logger "trx;" --no-build
    }
}