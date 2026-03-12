using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class ResoniteSDK_Builder
{
    [MenuItem("Resonite SDK/Build UnityPackage")]
    public static void BuildUnityPackage()
    {
        var files = Directory.EnumerateFiles("Assets/ResoniteSDK/", "*", SearchOption.AllDirectories)
            .Where(file => Path.GetExtension(file) != ".meta").ToArray();

        Debug.Log($"Building UnityPackage from files:\n{string.Join("\n", files)}");

        Directory.CreateDirectory("Builds");

        AssetDatabase.ExportPackage(files, "Builds/ResoniteSDK.unitypackage", ExportPackageOptions.IncludeDependencies);

        Debug.Log("ResoniteSDK UnityPackage built!");
    }
}
