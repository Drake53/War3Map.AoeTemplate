using System.IO;

namespace War3Map.Aoe.Launcher.ObjectData
{
    public sealed class IntModification : FieldModification
    {
        private readonly int _modification;

        public IntModification(int field, int modification)
            : base(field)
        {
            _modification = modification;
        }

        public int Modification => _modification;

        public override FieldModificationType Type => FieldModificationType.Int;

        public override void WriteData(BinaryWriter writer)
        {
            writer.Write(_modification);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}