using UnityEngine;
using UnityEditor;
using UnityEditor.TestRunner;

public class TestRunner : MonoBehaviour
{
    [MenuItem("Tools/Run Tests")]
    public static void RunAllTests()
    {
        // This method runs all tests in the project
        EditorApplication.ExecuteMenuItem("Edit/Test Runner/Run All Tests");
    }

    [MenuItem("Tools/Run Tests in Play Mode")]
    public static void RunTestsInPlayMode()
    {
        // This method runs tests in Play Mode (if supported by your test framework)
        EditorApplication.ExecuteMenuItem("Edit/Test Runner/Run Tests in Play Mode");
    }
}
