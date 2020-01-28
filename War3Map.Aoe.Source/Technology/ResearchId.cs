using static War3Map.Aoe.Source.DotNet;

namespace War3Map.Aoe.Source.Technology
{
    public static class ResearchId
    {
        public static readonly int AsianStoneAge = FourCC("R00a");
        public static readonly int EgyptianStoneAge = FourCC("R00e");
        public static readonly int GreekStoneAge = FourCC("R00g");
        public static readonly int MesopotamianStoneAge = FourCC("R00m");
        public static readonly int RomanStoneAge = FourCC("R00r");

        // codes: 'R' {buildingChar} {type} {level}
        // researches with same name as unit it unlocks, but different icon, have the 'Research' prefix

        // Town Center (q)
        public static readonly int ToolAge = FourCC("Rq00");
        public static readonly int BronzeAge = FourCC("Rq01");
        public static readonly int IronAge = FourCC("Rq02");
        public static readonly int AsianToolAge = FourCC("Rqa0");
        public static readonly int AsianBronzeAge = FourCC("Rqa1");
        public static readonly int AsianIronAge = FourCC("Rqa2");
        public static readonly int EgyptianToolAge = FourCC("Rqe0");
        public static readonly int EgyptianBronzeAge = FourCC("Rqe1");
        public static readonly int EgyptianIronAge = FourCC("Rqe2");
        public static readonly int GreekToolAge = FourCC("Rqg0");
        public static readonly int GreekBronzeAge = FourCC("Rqg1");
        public static readonly int GreekIronAge = FourCC("Rqg2");
        public static readonly int MesopotamianToolAge = FourCC("Rqm0");
        public static readonly int MesopotamianBronzeAge = FourCC("Rqm1");
        public static readonly int MesopotamianIronAge = FourCC("Rqm2");
        public static readonly int RomanToolAge = FourCC("Rqr0");
        public static readonly int RomanBronzeAge = FourCC("Rqr1");
        public static readonly int RomanIronAge = FourCC("Rqr2");

        // Storage Pit (r)
        public static readonly int Toolworking = FourCC("Rr00");
        public static readonly int Metalworking = FourCC("Rr01");
        public static readonly int Metallurgy = FourCC("Rr02");
        public static readonly int LeatherArmorInfantry = FourCC("Rr10");
        public static readonly int ScaleArmorInfantry = FourCC("Rr11");
        public static readonly int ChainMailInfantry = FourCC("Rr12");
        public static readonly int LeatherArmorArchers = FourCC("Rr20");
        public static readonly int ScaleArmorArchers = FourCC("Rr21");
        public static readonly int ChainMailArchers = FourCC("Rr22");
        public static readonly int LeatherArmorCavalry = FourCC("Rr30");
        public static readonly int ScaleArmorCavalry = FourCC("Rr31");
        public static readonly int ChainMailCavalry = FourCC("Rr32");
        public static readonly int BronzeShield = FourCC("Rr40");
        public static readonly int IronShield = FourCC("Rr41");
        public static readonly int TowerShield = FourCC("Rr42");

        // Granary (g)
        public static readonly int ResearchSmallWall = FourCC("Rg00");
        public static readonly int MediumWall = FourCC("Rg01");
        public static readonly int Fortification = FourCC("Rg02");
        public static readonly int ResearchWatchTower = FourCC("Rg10");
        public static readonly int ResearchSentryTower = FourCC("Rg11");
        public static readonly int GuardTower = FourCC("Rg12");
        public static readonly int BallistaTower = FourCC("Rg13");

        // Barracks (b)
        public static readonly int Axe = FourCC("Rb00");
        public static readonly int Shortsword = FourCC("Rb10");
        public static readonly int Broadsword = FourCC("Rb11");
        public static readonly int Longsword = FourCC("Rb12");
        public static readonly int Legion = FourCC("Rb13");

        // Dock (d)
        public static readonly int ResearchFishingShip = FourCC("Rd00");
        public static readonly int ResearchMerchantShip = FourCC("Rd10");
        public static readonly int ResearchHeavyTransport = FourCC("Rd20");
        public static readonly int ResearchWarGalley = FourCC("Rd30");
        public static readonly int ResearchTrireme = FourCC("Rd31");
        public static readonly int ResearchCatapultTrireme = FourCC("Rd40");
        public static readonly int Juggernaught = FourCC("Rd41");

        // Archery Range (a)
        public static readonly int ImprovedBow = FourCC("Ra00");
        public static readonly int CompositeBow = FourCC("Ra01");
        public static readonly int HeavyHorseArcher = FourCC("Ra10");

        // Stable (s)
        public static readonly int ScytheChariot = FourCC("Rs00");
        public static readonly int ResearchHeavyCavalry = FourCC("Rs10");
        public static readonly int Cataphract = FourCC("Rs11");
        public static readonly int ArmoredElephant = FourCC("Rs20");

        // Market (m)
        public static readonly int Woodworking = FourCC("Rm00");
        public static readonly int Artisanship = FourCC("Rm01");
        public static readonly int Craftmanship = FourCC("Rm02");
        public static readonly int StoneMining = FourCC("Rm10");
        public static readonly int Siegecraft = FourCC("Rm11");
        public static readonly int GoldMining = FourCC("Rm20");
        public static readonly int Coinage = FourCC("Rm21");
        public static readonly int Domestication = FourCC("Rm30");
        public static readonly int Plow = FourCC("Rm31");
        public static readonly int Irrigation = FourCC("Rm32");
        public static readonly int Wheel = FourCC("Rm40");

        // Government Center (v)
        public static readonly int Nobility = FourCC("Rv00");
        public static readonly int Writing = FourCC("Rv10");
        public static readonly int Architecture = FourCC("Rv20");
        public static readonly int Logistics = FourCC("Rv30");
        public static readonly int Aristocracy = FourCC("Rv40");
        public static readonly int Ballistics = FourCC("Rv50");
        public static readonly int Alchemy = FourCC("Rv60");
        public static readonly int Engineering = FourCC("Rv70");

        // Temple (t)
        public static readonly int Astrology = FourCC("Rt00");
        public static readonly int Mysticism = FourCC("Rt10");
        public static readonly int Polytheism = FourCC("Rt20");
        public static readonly int Medicine = FourCC("Rt30");
        public static readonly int Afterlife = FourCC("Rt40");
        public static readonly int Monotheism = FourCC("Rt50");
        public static readonly int Fanaticism = FourCC("Rt60");
        public static readonly int Jihad = FourCC("Rt70");
        public static readonly int Martyrdom = FourCC("Rt80");

        // Academy (c)
        public static readonly int ResearchPhalanx = FourCC("Rc00");
        public static readonly int Centurion = FourCC("Rc01");

        // Siege Workshop (u)
        public static readonly int ResearchCatapult = FourCC("Ru00");
        public static readonly int HeavyCatapult = FourCC("Ru01");
        public static readonly int Helepolis = FourCC("Ru10");
    }
}