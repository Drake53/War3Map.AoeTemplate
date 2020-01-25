using System.Collections.Generic;
using System.IO;

using static War3Map.Aoe.Source.DotNet;

namespace War3Map.Aoe.Launcher.ObjectData
{
    public abstract class FieldModification
    {
        private static readonly HashSet<int> _levelSpecificCodes;

        private readonly int _field;

        static FieldModification()
        {
            _levelSpecificCodes = new HashSet<int>();

            // Research
            _levelSpecificCodes.Add(FourCC("gnam"));
            _levelSpecificCodes.Add(FourCC("gar1"));
            _levelSpecificCodes.Add(FourCC("ghk1"));
            _levelSpecificCodes.Add(FourCC("gtp1"));
            _levelSpecificCodes.Add(FourCC("gub1"));
            _levelSpecificCodes.Add(FourCC("greq"));

            // Ability
            _levelSpecificCodes.Add(FourCC("Cha1"));
        }

        internal FieldModification(int field)
        {
            _field = field;
        }

        public int Field => _field;

        public abstract FieldModificationType Type { get; }

        public void WriteTo(BinaryWriter writer, bool additionalData)
        {
            writer.Write(_field);
            writer.Write((int)Type);
            if (additionalData)
            {
                writer.Write(IsLevelSpecificField(_field) ? 1 : 0);
                writer.Write(0);
            }

            WriteData(writer);
            writer.Write(0);
        }

        public abstract void WriteData(BinaryWriter writer);

        private static bool IsLevelSpecificField(int code)
        {
            return _levelSpecificCodes.Contains(code);
        }
    }
}