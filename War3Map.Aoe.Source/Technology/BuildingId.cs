using static War3Map.Aoe.Source.DotNet;

namespace War3Map.Aoe.Source.Technology
{
    public static class BuildingId
    {
        // Base Buildings
        public static readonly int House = FourCC("e070");
        public static readonly int Barracks = FourCC("e012");
        public static readonly int Granary = FourCC("e068");
        public static readonly int StoragePit = FourCC("e103");
        public static readonly int Dock = FourCC("e045");
        public static readonly int ArcheryRange = FourCC("e087");
        public static readonly int Stable = FourCC("e101");
        public static readonly int Farm = FourCC("e050");
        public static readonly int WatchTower = FourCC("e079");
        public static readonly int SentryTower = FourCC("e199");
        public static readonly int GuardTower = FourCC("e069");
        public static readonly int BallistaTower = FourCC("e278");
        public static readonly int SmallWall = FourCC("e072");
        public static readonly int MediumWall = FourCC("e117");
        public static readonly int Fortification = FourCC("e155");
        public static readonly int Market = FourCC("e084");
        public static readonly int GovernmentCenter = FourCC("e082");
        public static readonly int Temple = FourCC("e104");
        // public static readonly int TownCenter = FourCC("e109");
        public static readonly int SiegeWorkshop = FourCC("e049");
        public static readonly int Academy = FourCC("e000");
        public static readonly int Wonder = FourCC("e276");

        public static readonly int TrainingCamp = FourCC("e00c");
        public static readonly int ResourceStore = FourCC("e00r");



        // =========
        // Stone Age
        public static readonly int StoneTownCenter = FourCC("e109");

        public static readonly int StoneAsianGranary = FourCC("gb0a");
        public static readonly int StoneEgyptianGranary = FourCC("gb0e");
        public static readonly int StoneGreekGranary = FourCC("gb0g");
        public static readonly int StoneMesopotamianGranary = FourCC("gb0m");
        public static readonly int StoneRomanGranary = FourCC("gb0r");



        // ========
        // Tool Age
        public static readonly int ToolTownCenter = FourCC("qb10");

        // Tool Age (Asian)
        public static readonly int ToolAsianArcheryRange = FourCC("ab1a");
        public static readonly int ToolAsianHouse = FourCC("hb1a");

        // Tool Age (Egyptian)
        public static readonly int ToolEgyptianArcheryRange = FourCC("ab1e");
        public static readonly int ToolEgyptianHouse = FourCC("hb1e");

        // Tool Age (Greek)
        public static readonly int ToolGreekArcheryRange = FourCC("ab1g");
        public static readonly int ToolGreekHouse = FourCC("hb1g");

        // Tool Age (Mesopotamian)
        public static readonly int ToolMesopotamianArcheryRange = FourCC("ab1m");
        public static readonly int ToolMesopotamianHouse = FourCC("hb1m");

        // Tool Age (Roman)
        public static readonly int ToolRomanArcheryRange = FourCC("ab1r");
        public static readonly int ToolRomanHouse = FourCC("hb1r");



        // ==========
        // Bronze Age

        // Bronze Age (Asian)
        public static readonly int BronzeAsianBarracks = FourCC("bb2a");
        public static readonly int AsianAcademy = FourCC("cb2a");
        public static readonly int BronzeAsianDock = FourCC("db2a");
        public static readonly int BronzeAsianHouse = FourCC("hb2a");
        public static readonly int BronzeAsianMarket = FourCC("mb2a");
        public static readonly int BronzeAsianTownCenter = FourCC("qb2a");
        public static readonly int BronzeAsianStoragePit = FourCC("rb2a");
        public static readonly int AsianStable = FourCC("sb2a");
        public static readonly int BronzeAsianTemple = FourCC("tb2a");
        public static readonly int AsianSiegeWorkshop = FourCC("ub2a");
        public static readonly int BronzeAsianGovernmentCenter = FourCC("vb2a");
        public static readonly int AsianMediumWall = FourCC("yb2a");

        // Bronze Age (Egyptian)
        public static readonly int BronzeEgyptianBarracks = FourCC("bb2e");
        public static readonly int EgyptianAcademy = FourCC("cb2e");
        public static readonly int BronzeEgyptianDock = FourCC("db2e");
        public static readonly int BronzeEgyptianHouse = FourCC("hb2e");
        public static readonly int BronzeEgyptianMarket = FourCC("mb2e");
        public static readonly int BronzeEgyptianTownCenter = FourCC("qb2e");
        public static readonly int BronzeEgyptianStoragePit = FourCC("rb2e");
        public static readonly int EgyptianStable = FourCC("sb2e");
        public static readonly int BronzeEgyptianTemple = FourCC("tb2e");
        public static readonly int EgyptianSiegeWorkshop = FourCC("ub2e");
        public static readonly int BronzeEgyptianGovernmentCenter = FourCC("vb2e");
        public static readonly int EgyptianMediumWall = FourCC("yb2e");

        // Bronze Age (Greek)
        public static readonly int BronzeGreekBarracks = FourCC("bb2g");
        public static readonly int GreekAcademy = FourCC("cb2g");
        public static readonly int BronzeGreekDock = FourCC("db2g");
        public static readonly int BronzeGreekHouse = FourCC("hb2g");
        public static readonly int BronzeGreekMarket = FourCC("mb2g");
        public static readonly int BronzeGreekTownCenter = FourCC("qb2g");
        public static readonly int BronzeGreekStoragePit = FourCC("rb2g");
        public static readonly int GreekStable = FourCC("sb2g");
        public static readonly int BronzeGreekTemple = FourCC("tb2g");
        public static readonly int GreekSiegeWorkshop = FourCC("ub2g");
        public static readonly int BronzeGreekGovernmentCenter = FourCC("vb2g");
        public static readonly int GreekMediumWall = FourCC("yb2g");

        // Bronze Age (Mesopotamian)
        public static readonly int BronzeMesopotamianBarracks = FourCC("bb2m");
        public static readonly int MesopotamianAcademy = FourCC("cb2m");
        public static readonly int BronzeMesopotamianDock = FourCC("db2m");
        public static readonly int BronzeMesopotamianHouse = FourCC("hb2m");
        public static readonly int BronzeMesopotamianMarket = FourCC("mb2m");
        public static readonly int BronzeMesopotamianTownCenter = FourCC("qb2m");
        public static readonly int BronzeMesopotamianStoragePit = FourCC("rb2m");
        public static readonly int MesopotamianStable = FourCC("sb2m");
        public static readonly int BronzeMesopotamianTemple = FourCC("tb2m");
        public static readonly int MesopotamianSiegeWorkshop = FourCC("ub2m");
        public static readonly int BronzeMesopotamianGovernmentCenter = FourCC("vb2m");
        public static readonly int MesopotamianMediumWall = FourCC("yb2m");

        // Bronze Age (Roman)
        public static readonly int BronzeRomanBarracks = FourCC("bb2r");
        public static readonly int RomanAcademy = FourCC("cb2r");
        public static readonly int BronzeRomanDock = FourCC("db2r");
        public static readonly int BronzeRomanHouse = FourCC("hb2r");
        public static readonly int BronzeRomanMarket = FourCC("mb2r");
        public static readonly int BronzeRomanTownCenter = FourCC("qb2r");
        public static readonly int BronzeRomanStoragePit = FourCC("rb2r");
        public static readonly int RomanStable = FourCC("sb2r");
        public static readonly int BronzeRomanTemple = FourCC("tb2r");
        public static readonly int RomanSiegeWorkshop = FourCC("ub2r");
        public static readonly int BronzeRomanGovernmentCenter = FourCC("vb2r");
        public static readonly int RomanMediumWall = FourCC("yb2r");



        // ==========
        // Iron Age

        // Iron Age (Asian)
        public static readonly int IronAsianArcheryRange = FourCC("ab3a");
        public static readonly int IronAsianBarracks = FourCC("bb3a");
        public static readonly int IronAsianDock = FourCC("db3a");
        public static readonly int IronAsianGranary = FourCC("gb3a");
        public static readonly int IronAsianHouse = FourCC("hb3a");
        public static readonly int AsianGuardTower = FourCC("kb3a");
        public static readonly int AsianBallistaTower = FourCC("lb3a");
        public static readonly int IronAsianMarket = FourCC("mb3a");
        public static readonly int IronAsianTownCenter = FourCC("qb3a");
        public static readonly int IronAsianStoragePit = FourCC("rb3a");
        public static readonly int IronAsianTemple = FourCC("tb3a");
        public static readonly int IronAsianGovernmentCenter = FourCC("vb3a");
        public static readonly int AsianWonder = FourCC("wb3a");
        public static readonly int AsianFortification = FourCC("zb3a");

        // Iron Age (Egyptian)
        public static readonly int IronEgyptianArcheryRange = FourCC("ab3e");
        public static readonly int IronEgyptianBarracks = FourCC("bb3e");
        public static readonly int IronEgyptianDock = FourCC("db3e");
        public static readonly int IronEgyptianGranary = FourCC("gb3e");
        public static readonly int IronEgyptianHouse = FourCC("hb3e");
        public static readonly int EgyptianGuardTower = FourCC("kb3e");
        public static readonly int EgyptianBallistaTower = FourCC("lb3e");
        public static readonly int IronEgyptianMarket = FourCC("mb3e");
        public static readonly int IronEgyptianTownCenter = FourCC("qb3e");
        public static readonly int IronEgyptianStoragePit = FourCC("rb3e");
        public static readonly int IronEgyptianTemple = FourCC("tb3e");
        public static readonly int IronEgyptianGovernmentCenter = FourCC("vb3e");
        public static readonly int EgyptianWonder = FourCC("wb3e");
        public static readonly int EgyptianFortification = FourCC("zb3e");

        // Iron Age (Greek)
        public static readonly int IronGreekArcheryRange = FourCC("ab3g");
        public static readonly int IronGreekBarracks = FourCC("bb3g");
        public static readonly int IronGreekDock = FourCC("db3g");
        public static readonly int IronGreekGranary = FourCC("gb3g");
        public static readonly int IronGreekHouse = FourCC("hb3g");
        public static readonly int GreekGuardTower = FourCC("kb3g");
        public static readonly int GreekBallistaTower = FourCC("lb3g");
        public static readonly int IronGreekMarket = FourCC("mb3g");
        public static readonly int IronGreekTownCenter = FourCC("qb3g");
        public static readonly int IronGreekStoragePit = FourCC("rb3g");
        public static readonly int IronGreekTemple = FourCC("tb3g");
        public static readonly int IronGreekGovernmentCenter = FourCC("vb3g");
        public static readonly int GreekWonder = FourCC("wb3g");
        public static readonly int GreekFortification = FourCC("zb3g");

        // Iron Age (Mesopotamian)
        public static readonly int IronMesopotamianArcheryRange = FourCC("ab3m");
        public static readonly int IronMesopotamianBarracks = FourCC("bb3m");
        public static readonly int IronMesopotamianDock = FourCC("db3m");
        public static readonly int IronMesopotamianGranary = FourCC("gb3m");
        public static readonly int IronMesopotamianHouse = FourCC("hb3m");
        public static readonly int MesopotamianGuardTower = FourCC("kb3m");
        public static readonly int MesopotamianBallistaTower = FourCC("lb3m");
        public static readonly int IronMesopotamianMarket = FourCC("mb3m");
        public static readonly int IronMesopotamianTownCenter = FourCC("qb3m");
        public static readonly int IronMesopotamianStoragePit = FourCC("rb3m");
        public static readonly int IronMesopotamianTemple = FourCC("tb3m");
        public static readonly int IronMesopotamianGovernmentCenter = FourCC("vb3m");
        public static readonly int MesopotamianWonder = FourCC("wb3m");
        public static readonly int MesopotamianFortification = FourCC("zb3m");

        // Iron Age (Roman)
        public static readonly int IronRomanArcheryRange = FourCC("ab3r");
        public static readonly int IronRomanBarracks = FourCC("bb3r");
        public static readonly int IronRomanDock = FourCC("db3r");
        public static readonly int IronRomanGranary = FourCC("gb3r");
        public static readonly int IronRomanHouse = FourCC("hb3r");
        public static readonly int RomanGuardTower = FourCC("kb3r");
        public static readonly int RomanBallistaTower = FourCC("lb3r");
        public static readonly int IronRomanMarket = FourCC("mb3r");
        public static readonly int IronRomanTownCenter = FourCC("qb3r");
        public static readonly int IronRomanStoragePit = FourCC("rb3r");
        public static readonly int IronRomanTemple = FourCC("tb3r");
        public static readonly int IronRomanGovernmentCenter = FourCC("vb3r");
        public static readonly int RomanWonder = FourCC("wb3r");
        public static readonly int RomanFortification = FourCC("zb3r");
    }
}