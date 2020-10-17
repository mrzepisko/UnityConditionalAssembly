using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;

public class BuildAll : EditorWindow
{
    private static List<string> exes = new List<string>();
    private static readonly (string, string)[] defines = {
            ("Default", ""),
            ("V1", "VARIANT1"),
            ("V2", "VARIANT2"),
            ("V1 V2", "VARIANT1;VARIANT2"),
        };

    [MenuItem("Build/Build all")]
    private static void Build()
    {
        exes.Clear();
        var assetsPath = Application.dataPath;
        string path = assetsPath.Substring(0, assetsPath.Length - "Assets".Length) + "Builds/";//EditorUtility.SaveFolderPanel("Choose Location of Built Game", "", "");
        foreach (var tuple in defines)
        {
            var exePath = Build(tuple, path);
            exes.Add(exePath);
        }
    }

    [MenuItem("Build/Run all")]
    private static void RunAll()
    {
        foreach (var exe in exes)
        {
            RunExe(exe);
        }
    }

    [MenuItem("Build/Build and run all")]
    private static void BuildAndRunAll()
    {
        Build();
        RunAll();
    }


    private static string Build((string, string) defines, string basePath)
    {
        // Get filename.
        string[] levels = new string[] { "Assets/Scenes/SampleScene.unity", };

        // Build player.
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone, defines.Item2);
        PlayerSettings.productName = "AssemblyTest - " + defines.Item1;
        string exePath = basePath + defines.Item1 + "/Test.exe";
        BuildPipeline.BuildPlayer(levels, exePath, BuildTarget.StandaloneWindows, BuildOptions.None);

        return exePath;
    }

    private static void RunExe(string path)
    {
        // Run the game (Process class from System.Diagnostics).
        Process proc = new Process();
        proc.StartInfo.FileName = path;
        proc.Start();
    }
}
