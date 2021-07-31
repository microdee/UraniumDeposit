using System;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities.Collections;
using Nuke.Unreal;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Logger;

[CheckBuildProjectConfigurations]
class Build : PluginTargets
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main() => Execute<Build>(x => x.BuildEditor);

    [Solution] readonly Solution Solution;
    
    public override string UnrealVersion { get; set; } = "4.26.0";
    
    public override string PluginVersion => "0.1.0";

    public override AbsolutePath TemplatesPath => ToPlugin.Parent / "Templates";
    
    public Target NewHandler => _ => _
        .Description("Create new CEF - Uranium handler pair")
        .Requires(() => Name)
        .Executes(() => 
            Name.ForEach(n => 
                new HandlerGenerator().Generate(
                    TemplatesPath,
                    (AbsolutePath) Environment.CurrentDirectory,
                    new(n)
                )
            )
        );
}