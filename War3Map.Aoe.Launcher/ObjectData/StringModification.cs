using System.IO;

using War3Net.Common.Extensions;

namespace War3Map.Aoe.Launcher.ObjectData
{
    public sealed class StringModification : FieldModification
    {
        private readonly string _modification;

        public StringModification(int field, string modification)
            : base(field)
        {
            _modification = modification;
        }

        public string Modification => _modification;

        public override FieldModificationType Type => FieldModificationType.String;

        public override void WriteData(BinaryWriter writer)
        {
            writer.WriteString(_modification);
        }
    }
}