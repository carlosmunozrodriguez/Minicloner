Import-Module ./invoke-task.psm1

Invoke-Task AutomatedBuild {
    Invoke-Task Get-DotNet-Sdk {
        $dotnetRuntimeVersion1 = "1.1.8"
        $dotnetSdkVersion2 = "2.1.200"

        if ($IsLinux -or $IsOsX) {
            bash ./dotnet-install.sh -Channel Current -Version $dotnetRuntimeVersion1 -Runtime dotnet
            bash ./dotnet-install.sh -Channel Current -Version $dotnetSdkVersion2
        } else {
            ./dotnet-install.ps1 -Channel Current -Version $dotnetRuntimeVersion1  -Runtime dotnet
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
        dotnet test test/Minicloner.Tests/Minicloner.Tests.csproj --configuration Release --logger "trx;" --no-build
    }
}