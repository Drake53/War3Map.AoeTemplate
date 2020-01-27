using System.IO;

namespace War3Map.Aoe.Launcher.ObjectData
{
    public sealed class FloatModification : FieldModification
    {
        private readonly float _modification;
        private readonly FieldModificationType _type;

        public FloatModification(int field, float modification, bool idkbruh)
            : base(field)
        {
            _modification = modification;
            _type = idkbruh ? FieldModificationType.RealZeroToOne : FieldModificationType.Real;
        }

        public float Modification => _modification;

        public override FieldModificationType Type => _type;

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