Import-Module ./invoke-task.psm1

Invoke-Task AutomatedBuild {
    Invoke-Task Get-DotNet-Sdk-2.2 {
        $dotnetSdkVersion2 = "2.2.203"

        if ($IsLinux -or $IsOsX) {
            bash ./dotnet-install.sh --channel Current --version $dotnetSdkVersion2
        } else {
            ./dotnet-install.ps1 -Channel Current -Version $dotnetSdkVersion2
        }
    }

    Invoke-Task Info {
        dotnet --info
    }

    Invoke-Task Clean {
        dotnet clean --configuration Release
    }

    Invoke-Task Build {
        dotnet build --configuration Release
    }

    Invoke-Task Test-2.0 {
        dotnet test Minicloner.Tests/Minicloner.Tests.csproj --configuration Release --framework netcoreapp2.0 --logger "trx;" --no-build
    }

    Invoke-Task Get-DotNet-Sdk-1.1 {
        $dotnetSdkVersion1 = "1.1.12"

        if ($IsLinux -or $IsOsX) {
            bash ./dotnet-install.sh --channel Current --version $dotnetSdkVersion1
        } else {
            ./dotnet-install.ps1 -Channel Current -Version $dotnetSdkVersion1
        }
    }

    Invoke-Task Test-2.0 {
        dotnet test Minicloner.Tests/Minicloner.Tests.csproj --configuration Release --framework netcoreapp1.0 --logger "trx;" --no-build
    }
}