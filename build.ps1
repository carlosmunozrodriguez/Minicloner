Import-Module ./invoke-task.psm1

function Install-DotNetRuntime {
    param(
        [String] $Version
    )

    process {
        if ($IsLinux -or $IsOsX) {
            bash ./dotnet-install.sh --runtime dotnet --version $Version
        } else {
            ./dotnet-install.ps1 -Runtime dotnet -Version $Version
        }
    }
}

function Install-DotNetSdk {
    param(
        [String] $Version
    )

    process {
        if ($IsLinux -or $IsOsX) {
            bash ./dotnet-install.sh --version $Version
        } else {
            ./dotnet-install.ps1 -Version $Version
        }
    }
}

Invoke-Task AutomatedBuild {
    Invoke-Task Get-DotNet-Runtime-1.1 {
        Install-DotNetRuntime "1.1.13"
    }

    Invoke-Task Get-DotNet-Runtime-2.2 {
        Install-DotNetRuntime "2.2.8"
    }

    Invoke-Task Get-DotNet-Runtime-3.1 {
        Install-DotNetRuntime "3.1.32"
    }

    Invoke-Task Get-DotNet-Sdk-5.0 {
        Install-DotNetSdk "5.0.408"
    }

    Invoke-Task Info {
        dotnet --info
    }

    Invoke-Task Clean {
        dotnet clean --configuration Release
    }

    Invoke-Task Install-Dotnet-Outdated {
        dotnet tool update --global dotnet-outdated-tool --version 4.5.0
    }

    Invoke-Task Dotnet-outdated {
        dotnet outdated --fail-on-updates
    }

    Invoke-Task Build {
        dotnet build --configuration Release
    }

    if (-not ($IsLinux -or $IsOsX)) {
        Invoke-Task Test-Net4.5 {
            dotnet test --configuration Release --framework net452 --logger "trx;LogFileName=net452.trx" --no-build
        }
    }

    Invoke-Task Test-1.0 {
        dotnet test --configuration Release --framework netcoreapp1.0 --logger "trx;LogFileName=netcoreapp1.0.trx" --no-build
    }

    Invoke-Task Test-2.0 {
        dotnet test --configuration Release --framework netcoreapp2.0 --logger "trx;LogFileName=netcoreapp2.0.trx" --no-build
    }
}