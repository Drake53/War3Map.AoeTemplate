#define SKIP_GENERATE_DISBTN

using System;
using System.Diagnostics;
using System.IO;
using System.Text;

using War3Map.Aoe.Launcher.ObjectData;

using War3Net.Build;

namespace War3Map.Aoe.Launcher
{
    internal static class Program
    {
        // Input
        private const string SourceCodeProjectFolderPath = @"..\..\..\..\War3Map.Aoe.Source";
        private const string AssetsFolderPath = @".\Assets\";
        private const string ScenarioFilePath = null;

        // Output
        private const string OutputFolderPath = @"..\..\..\..\artifacts";
        private const string OutputMapName = @"Testmap.w3x";

        // Warcraft III
        private const string Warcraft3ExecutableFilePath = null;
        private const string GraphicsApi = "Direct3D9";
        private const bool PauseGameOnLoseFocus = false;

        private static void Main()
        {
            if (ScenarioFilePath is null)
            {
                throw new FileNotFoundException("An input .scn file is required.");
            }

            // Convert .scn to .w3x
            var convertedScenarioFilesFolder = Path.Combine(OutputFolderPath, new FileInfo(ScenarioFilePath).Name);
            ScenarioConverter.MapConverter.Convert(ScenarioFilePath, convertedScenarioFilesFolder);

            // Generate .w3o files
            var generatedObjectDataFolder = Path.Combine(OutputFolderPath, "Object Data");
            ObjectDataGenerator.Generate(generatedObjectDataFolder);

            // Generate DISBTN icons
            var generatedDisbtnFolder = Path.Combine(OutputFolderPath, "DISBTN Icons");
#if !SKIP_GENERATE_DISBTN
            Directory.CreateDirectory(Path.Combine(generatedDisbtnFolder, "ReplaceableTextures", "CommandButtonsDisabled"));
            foreach (var button in Directory.EnumerateFiles(Path.Combine(AssetsFolderPath, "ReplaceableTextures", "CommandButtons")))
            {
                var btnName = new FileInfo(button).Name.Substring(3);
                var expectDisbtnPath = Path.Combine("ReplaceableTextures", "CommandButtonsDisabled", $"DISBTN{btnName}");
                if (!File.Exists(Path.Combine(AssetsFolderPath, expectDisbtnPath)))
                {
                    File.Copy(button, Path.Combine(generatedDisbtnFolder, expectDisbtnPath));
                }
            }
#endif

            // Build and launch
            var mapBuilder = new MapBuilder(OutputMapName);
            var options = CompilerOptions.GetCompilerOptions(SourceCodeProjectFolderPath, OutputFolderPath);

            var buildResult = mapBuilder.Build(options, generatedObjectDataFolder, AssetsFolderPath, convertedScenarioFilesFolder, generatedDisbtnFolder);
            if (buildResult.Success)
            {
                var mapPath = Path.Combine(OutputFolderPath, OutputMapName);
                var absoluteMapPath = new FileInfo(mapPath).FullName;

#if DEBUG
                if (Warcraft3ExecutableFilePath != null)
                {
                    var commandLineArgs = new StringBuilder();
                    var isReforged = Version.Parse(FileVersionInfo.GetVersionInfo(Warcraft3ExecutableFilePath).FileVersion) >= new Version(1, 32);
                    if (isReforged)
                    {
                        commandLineArgs.Append("-launch ");
                    }
                    else if (GraphicsApi != null)
                    {
                        commandLineArgs.Append($"-graphicsapi {GraphicsApi} ");
                    }

                    if (!PauseGameOnLoseFocus)
                    {
                        commandLineArgs.Append("-nowfpause ");
                    }

                    commandLineArgs.Append($"-loadfile \"{absoluteMapPath}\"");

                    Process.Start(Warcraft3ExecutableFilePath, commandLineArgs.ToString());
                }
                else
#endif
                {
                    Process.Start("explorer.exe", $"/select, \"{absoluteMapPath}\"");
                }
            }
        }
    }
}