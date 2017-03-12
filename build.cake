Task("Restore").Does(()=>
{
    //TODO: Cake 0.18 does not work with .NET Core SDK 1.0. When it does, use proper DotNetCore* commands
    //DotNetCoreRestore();

    var returnCode = StartProcess(new FilePath("dotnet"), "restore --verbosity detailed");
    if (returnCode != 0)
    {
        throw new Exception(String.Format("Restore failed with error code: {0}", returnCode));
    }
});

Task("Build").IsDependentOn("Restore").Does(()=>
{
    //TODO: Cake 0.18 does not work with .NET Core SDK 1.0. When it does, use proper DotNetCore* commands
    //DotNetCoreBuild("./src/Minicloner", new DotNetCoreBuildSettings { Configuration = "Release", Verbose = true });
 
    var returnCode = StartProcess(new FilePath("dotnet"), "build --configuration Release --verbosity normal");
    if (returnCode != 0)
    {
        throw new Exception(String.Format("Build failed with error code: {0}", returnCode));
    }
});

Task("Test").IsDependentOn("Build").Does(()=>
{
    //TODO: Cake 0.18 does not work with .NET Core SDK 1.0. When it does, use proper DotNetCore* commands
    //DotNetCoreTest("./test/Minicloner.Tests", new DotNetCoreTestSettings { Configuration = "Release", Verbose = true });
 
    var returnCode = StartProcess(new FilePath("dotnet"), @"test test/Minicloner.Tests/Minicloner.Tests.csproj --configuration Release --verbosity minimal --logger ""trx;LogFileName=TestResults.trx""");
    if (returnCode != 0)
    {
        throw new Exception(String.Format("Test failed with error code: {0}", returnCode));
    }
});

Task("Default").IsDependentOn("Test").Does(() =>
{
});

RunTarget(Argument("target", "Default"));