using System.Collections.Immutable;
using System.IO;

namespace War3Map.Aoe.Launcher.ObjectData
{
    public sealed class ListModification : FieldModification
    {
        private readonly ImmutableArray<int> _modification;

        public ListModification(int field, params int[] modification)
            : base(field)
        {
            _modification = modification.ToImmutableArray();
        }

        public override FieldModificationType Type => FieldModificationType.String;

        public override void WriteData(BinaryWriter writer)
        {
            var last = _modification.Length - 1;
            for (var i = 0; i <= last; i++)
            {
                writer.Write(_modification[i]);
                if (i != last)
                {
                    writer.Write((byte)',');
                }
            }

            writer.Write((byte)0);
        }
    }
}