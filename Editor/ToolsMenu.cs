using static UnityEditor.AssetDatabase;
using UnityEditor;
namespace douwert
{
    public static class ToolsMenu
    {
        [MenuItem("Tools/Douwert/Setup/Create Default Folders")]

        static void CreateDefaultFolders()
        {
            Folders.CreateDirectories("_Project", "Scripts", "Models", "Prefabs", "Materials", "Textures", "Shaders", "Effects", "Scenes");
            Refresh();
        }

        [MenuItem("Tools/Douwert/Setup/Load New Manifest")]
        static async void LoadNewManifest() => await Packages.ReplacePackagesFromGist("7ab024784680de9f5bb5e4550e141476");
        
        [MenuItem("Tools/Douwert/Packages/Visual Scripting")]
        static void AddVisualScripting() => Packages.InstallUnityPackage("visualscripting");
        [MenuItem("Tools/Douwert/Packages/2D Features")]
        static void Add2DFeatures() => Packages.InstallUnityPackage("feature.2d");
        [MenuItem("Tools/Douwert/Packages/New Input System")]
        static void AddNewInputSystem() => Packages.InstallUnityPackage("inputsystem");
        [MenuItem("Tools/Douwert/Packages/Cinemachine")]
        static void AddCinemachine() => Packages.InstallUnityPackage("cinemachine");
        [MenuItem("Tools/Douwert/Packages/Pro Builder")]
        static void AddProbuilder() => Packages.InstallUnityPackage("probuilder");
        [MenuItem("Tools/Douwert/Packages/VFX Graph")]
        static void AddVFXGraph() => Packages.InstallUnityPackage("visualeffectgraph");
        [MenuItem("Tools/Douwert/Packages/Shader Graph")]
        static void AddShaderGraph() => Packages.InstallUnityPackage("shadergraph");
    }
}