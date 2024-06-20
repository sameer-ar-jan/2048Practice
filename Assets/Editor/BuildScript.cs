using UnityEditor;

public static class BuildScript
{
    public static void BuildAndroid()
    {
        string buildPath = "Builds/Android/2048Practice.apk";
        BuildPipeline.BuildPlayer(EditorBuildSettings.scenes, buildPath, BuildTarget.Android, BuildOptions.None);
    }
}
