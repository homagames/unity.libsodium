﻿using UnityEditor;

public class PackageTool
{
    [MenuItem("Package/Update Package")]
    private static void UpdatePackage()
    {
        const string VERSION = "0.2.0";
        AssetDatabase.ExportPackage(
            new[] {"Assets/unity.libsodium"},
            $"../unity.libsodium-{VERSION}.unitypackage",
            ExportPackageOptions.Recurse
        );
    }
}