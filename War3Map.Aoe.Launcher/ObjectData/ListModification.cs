using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace War3Map.Aoe.Launcher.ObjectData
{
    public sealed class ListModification : FieldModification, IEnumerable<int>
    {
        private readonly List<int> _modification;

        public ListModification(int field, params int[] modification)
            : base(field)
        {
            //_modification = modification.ToImmutableArray();
            _modification = new List<int>(modification);
        }

        public ListModification(int field, IEnumerable<int> modification)
            : base(field)
        {
            _modification = new List<int>(modification);
        }

        public override FieldModificationType Type => FieldModificationType.String;

        public override void WriteData(BinaryWriter writer)
        {
            //var last = _modification.Length - 1;
            var last = _modification.Count - 1;
            for (var i = 0; i <= last; i++)
            {
                writer.Write(_modification[i]);
                if (i != last)
                {
                    writer.Write((byte)',');
                }
            }

            writer.Write((byte)0);

            //writer.WriteString(ToString());
        }

        public override string ToString()
        {
            return base.ToString();
            //return _modification.Select(item => new string(item[0];
        }

        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)_modification).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<int>)_modification).GetEnumerator();
        }
    }
}