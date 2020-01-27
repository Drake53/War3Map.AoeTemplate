using System.IO;

namespace War3Map.Aoe.Launcher.ObjectData
{
    public sealed class CharModification : FieldModification
    {
        private readonly char _modification;

        public CharModification(int field, char modification)
            : base(field)
        {
            _modification = modification;
        }

        public char Modification => _modification;

        public override FieldModificationType Type => FieldModificationType.String;

        public override void WriteData(BinaryWriter writer)
        {
            writer.Write((byte)_modification);
            writer.Write((byte)0);
        }

        public override string ToString()
        {
            return _modification.ToString();
        }
    }
}