using UnityEditor;
using UnityEngine;
using System.IO;

public class BuildScript
{
    public static void BuildAndroid()
    {
        string[] scenes = { "Assets/Scenes/MainMenu.unity", "Assets/Scenes/2048.unity" }; // Adjust this to include all your scenes

        string buildPath = "Builds/Android/build.apk";

        // If desired, modify or create the build path dynamically
        // (e.g., buildPath = Path.Combine(buildPath, "YourGame.apk");)

        BuildPipeline.BuildPlayer(scenes, buildPath, BuildTarget.Android, BuildOptions.None);
    }
}
