## Test project for Uranium

# [Go to the plugin repository](https://github.com/microdee/Uranium)

## Build Uranium

If you only want to use it in your project then you can just submodule https://github.com/microdee/Uranium.git into the project `Plugins` folder then ignore the rest of this guide.

If you'd like to develop it or make precompiled Engine plugins yourself, carry on reading:

Uranium uses [Nuke](https://nuke.build) with [Nuke.Unreal](https://github.com/microdee/Nuke.Unreal) to automate build tasks and chores usually associated with developing an Unreal project.

### Build editor for developing the plugin

Just run `build.cmd` without arguments. If it complains about missing .NET 5 then install .NET 5 SDK too.

If you need to develop for a different Unreal Engine version than the default, execute

```
> .\build.cmd --target Checkout --unreal-version 4.26
```

If you have Nuke installed as a global dotnet tool you can avoid `--target` and execute the command from any subfolder:

```
> nuke Checkout --unreal-version 4.26
```

### Make releases

For now precompiled releases are not yet supported in Uranium (although it's one goal).

### Building with custom engine

Using a custom instance of Unreal Engine maybe built from source:

```
nuke MakeRelease --custom-engine-path C:\Path\To\MyCustomEngine
```

or if you want to make that permanent you can edit the `Build` class in `/Nuke.Targets/Build.cs` by adding

```CSharp
public override AbsolutePath CustomEnginePath { get; set; } = RootDirectory.Parent / "MyCustomEngine"
```

or make an installed build and register it as a custom engine distribution.