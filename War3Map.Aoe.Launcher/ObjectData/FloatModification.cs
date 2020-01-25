using System.IO;

namespace War3Map.Aoe.Launcher.ObjectData
{
    public sealed class FloatModification : FieldModification
    {
        private readonly float _modification;

        public FloatModification(int field, float modification)
            : base(field)
        {
            _modification = modification;
        }

        public float Modification => _modification;

        public override FieldModificationType Type => FieldModificationType.Real;

        public override void WriteData(BinaryWriter writer)
        {
            writer.Write(_modification);
        }
    }
}