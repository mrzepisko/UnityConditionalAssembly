# Conditionally including an assembly
>You can use preprocessor symbols to control whether an assembly is compiled and included in builds of your game or application (including play mode in the Editor). You can specify which symbols must be defined for an assembly to be used with the Define Constraints list in the Assembly Definition options.

>You can “negate” the symbol by putting an exclamation point in front of the name.

See [Unity docs](https://docs.unity3d.com/Manual/ScriptCompilationAssemblyDefinitionFiles.html)

# How to
Edit `Scripting Define Symbols` in project settings and run `SampleScene` to test defines manually or use menu to build and run all variants