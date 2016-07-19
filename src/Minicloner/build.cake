Task("Restore").Does(()=>
{
    DotNetCoreRestore();
});

Task("Build").IsDependentOn("Restore").Does(()=>
{
    DotNetCoreBuild("./Minicloner", new DotNetCoreBuildSettings { Configuration = "Release", Verbose = true });
});

Task("Test").IsDependentOn("Build").Does(()=>
{
    DotNetCoreTest("./Minicloner.Tests", new DotNetCoreTestSettings { Configuration = "Release", Verbose = true });
});

Task("Default").IsDependentOn("Test").Does(() =>
{
});

RunTarget(Argument("target", "Default"));