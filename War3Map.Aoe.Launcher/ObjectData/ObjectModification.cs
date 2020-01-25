using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace War3Map.Aoe.Launcher.ObjectData
{
    public sealed class ObjectModification : IEnumerable<FieldModification>
    {
        private readonly int _old;
        private readonly int _new;
        private readonly Dictionary<int, FieldModification> _mods;

        public ObjectModification(int oldId, int newId, params FieldModification[] modifications)
        {
            _old = oldId;
            _new = newId;
            _mods = new Dictionary<int, FieldModification>(modifications.Select(mod => new KeyValuePair<int, FieldModification>(mod.Field, mod)));
        }

        public int OldId => _old;

        public int NewId => _new;

        public int ModificationCount => _mods.Count;

        public ObjectModification AddModification(FieldModification modification)
        {
            if (_mods.ContainsKey(modification.Field))
            {
                _mods[modification.Field] = modification;
            }
            else
            {
                _mods.Add(modification.Field, modification);
            }

            return this;
        }

        public IEnumerator<FieldModification> GetEnumerator()
        {
            return ((IEnumerable<FieldModification>)_mods.Values).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<FieldModification>)_mods.Values).GetEnumerator();
        }
    }
}