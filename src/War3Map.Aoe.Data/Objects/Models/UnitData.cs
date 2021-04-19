#nullable enable

namespace War3Map.Aoe.Data.Objects.Models
{
    public class UnitData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public float AttackTime { get; set; }
        public int AttackRange { get; set; }
        public int Armor { get; set; }
        public int MissileArmor { get; set; }
        public float Speed { get; set; }

        public string? TechnologyRequirement { get; set; }
    }
}