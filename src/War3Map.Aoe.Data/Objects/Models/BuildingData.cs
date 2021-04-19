#nullable enable

using System.Collections.Generic;

namespace War3Map.Aoe.Data.Objects.Models
{
    public class BuildingData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Wood { get; set; }
        public int Food { get; set; }
        public int Gold { get; set; }
        public int Stone { get; set; }
        public int Time { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public float AttackTime { get; set; }
        public int AttackRange { get; set; }
        public int Size { get; set; }
        public int Housing { get; set; }
        public List<UnitLineData>? UnitLines { get; set; }
        public List<TechnologyData>? Technologies { get; set; }
    }
}