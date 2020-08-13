
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class BuildClass
{
    private static List<string> scenesNamesOp = new List<string>{"SampleScene"};
    private static List<string> scenesNamesOf = new List<string>{"ToDeleteScene"};

    public static void BuildMethod(string arg)
    {
        string[] scenes = AssetDatabase.FindAssets("t:Scene", null);
        List<EditorBuildSettingsScene> editorBuildSettingsScenes = new List<EditorBuildSettingsScene>();
        
        foreach (var s in scenes)
        {
            editorBuildSettingsScenes.Add(new EditorBuildSettingsScene(s, true));
        }
        
        if (arg == "op")
        {
            foreach (var es in editorBuildSettingsScenes)
            {
                string sceneName = Path.GetFileNameWithoutExtension(es.path);

                es.enabled = scenesNamesOp.Contains(sceneName);
            }
        }
        else if (arg == "of")
        {
            foreach (var es in editorBuildSettingsScenes)
            {
                string sceneName = Path.GetFileNameWithoutExtension(es.path);

                es.enabled = scenesNamesOf.Contains(sceneName);
            }
        }
        
        EditorBuildSettings.scenes = editorBuildSettingsScenes.ToArray();
    }
}
