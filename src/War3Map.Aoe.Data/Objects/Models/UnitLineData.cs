using System.Collections.Generic;

using War3Map.Aoe.Data.Objects.Enums;

namespace War3Map.Aoe.Data.Objects.Models
{
    public class UnitLineData
    {
        public UnitType Type { get; set; }
        public int Wood { get; set; }
        public int Food { get; set; }
        public int Gold { get; set; }
        public int Stone { get; set; }
        public int Time { get; set; }
        public int Vision { get; set; }
        public List<UnitData> Units { get; set; }
    }
}