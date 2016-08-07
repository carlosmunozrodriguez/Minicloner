Task("Restore").Does(()=>
{
    DotNetCoreRestore();
});

Task("Build").IsDependentOn("Restore").Does(()=>
{
    DotNetCoreBuild("./src/Minicloner", new DotNetCoreBuildSettings { Configuration = "Release", Verbose = true });
});

Task("Test").IsDependentOn("Build").Does(()=>
{
    DotNetCoreTest("./test/Minicloner.Tests", new DotNetCoreTestSettings { Configuration = "Release", Verbose = true });
});

Task("Default").IsDependentOn("Test").Does(() =>
{
});

RunTarget(Argument("target", "Default"));