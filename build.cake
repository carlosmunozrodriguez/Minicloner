Task("Restore").Does(()=>
{
    //TODO: Cake 0.18 does not work with .NET Core SDK 1.0. When it does, use proper DotNetCore* commands
    //DotNetCoreRestore();
    StartProcess(new FilePath("dotnet"), "restore --verbosity detailed");
});

Task("Build").IsDependentOn("Restore").Does(()=>
{
    //TODO: Cake 0.18 does not work with .NET Core SDK 1.0. When it does, use proper DotNetCore* commands
    //DotNetCoreBuild("./src/Minicloner", new DotNetCoreBuildSettings { Configuration = "Release", Verbose = true });
    StartProcess(new FilePath("dotnet"), "build --configuration Release --verbosity normal");
});

Task("Test").IsDependentOn("Build").Does(()=>
{
    //TODO: Cake 0.18 does not work with .NET Core SDK 1.0. When it does, use proper DotNetCore* commands
    //DotNetCoreTest("./test/Minicloner.Tests", new DotNetCoreTestSettings { Configuration = "Release", Verbose = true });
    StartProcess(new FilePath("dotnet"), @"test test/Minicloner.Tests/Minicloner.Tests.csproj --configuration Release --verbosity minimal --logger ""trx;LogFileName=TestResults.trx""");
});

Task("Default").IsDependentOn("Test").Does(() =>
{
});

RunTarget(Argument("target", "Default"));