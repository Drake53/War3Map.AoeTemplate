using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace War3Map.Aoe.Launcher.ObjectData
{
    public static class ObjectDataGenerator
    {
        public static void Generate(string outputFolder)
        {
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            var data = AoeUnitData.GetModifications();

            // note: not all fields always start with u/a/g (example: 'Cha1' in chaos ability)
            WriteObjects(Path.Combine(outputFolder, "war3map.w3u"), false, data.Where(obj => (obj.First().Field & 0xff) == 'u'));
            WriteObjects(Path.Combine(outputFolder, "war3map.w3a"), true, data.Where(obj => (obj.First().Field & 0xff) == 'a'));
            WriteObjects(Path.Combine(outputFolder, "war3map.w3q"), true, data.Where(obj => (obj.First().Field & 0xff) == 'g'));
        }

        private static void WriteObjects(string outputFile, bool additionalData, IEnumerable<ObjectModification> objects)
        {
            using var fileStream = File.Create(outputFile);
            using var writer = new BinaryWriter(fileStream);

            writer.Write(1); // File Version
            writer.Write(0); // Amount of base units modified

            writer.Write(objects.Count());
            foreach (var customUnit in objects)
            {
                writer.Write(customUnit.OldId);
                writer.Write(customUnit.NewId);
                writer.Write(customUnit.ModificationCount);
                foreach (var modification in customUnit)
                {
                    modification.WriteTo(writer, additionalData);
                }
            }
        }
    }
}