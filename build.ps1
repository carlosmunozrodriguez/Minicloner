Import-Module ./invoke-task.psm1

Invoke-Task AutomatedBuild {
    Invoke-Task Get-DotNet-Sdk {
        $dotnetSdkVersion1 = "1.1.9"
        $dotnetSdkVersion2 = "2.1.200"

        if ($IsLinux -or $IsOsX) {
            bash ./dotnet-install.sh -Channel Current -Version $dotnetSdkVersion1
            bash ./dotnet-install.sh -Channel Current -Version $dotnetSdkVersion2
        } else {
            ./dotnet-install.ps1 -Channel Current -Version $dotnetSdkVersion1
            ./dotnet-install.ps1 -Channel Current -Version $dotnetSdkVersion2
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
        dotnet test Minicloner.Tests/Minicloner.Tests.csproj --configuration Release --logger "trx;" --no-build
    }
}