using static War3Map.Aoe.Source.DotNet;

namespace War3Map.Aoe.Source.Technology
{
    public static class UnitId
    {
        // Town Center Units
        public static readonly int Villager = FourCC("e083");

        // Barracks Units
        public static readonly int Clubman = FourCC("e073");
        public static readonly int Axeman = FourCC("e074");
        public static readonly int ShortSwordsman = FourCC("e075");
        public static readonly int BroadSwordsman = FourCC("e076");
        public static readonly int LongSwordsman = FourCC("e077");
        public static readonly int Legion = FourCC("e282");
        public static readonly int Slinger = FourCC("e347");

        // Dock Units
        public static readonly int FishingBoat = FourCC("e013");
        public static readonly int FishingShip = FourCC("e014");
        public static readonly int TradeBoat = FourCC("e015");
        public static readonly int MerchantShip = FourCC("e016");
        public static readonly int LightTransport = FourCC("e017");
        public static readonly int HeavyTransport = FourCC("e018");
        public static readonly int ScoutShip = FourCC("e019");
        public static readonly int WarGalley = FourCC("e020");
        public static readonly int Trireme = FourCC("e021");
        public static readonly int CatapultTrireme = FourCC("e250");
        public static readonly int Juggernaught = FourCC("e277");
        public static readonly int FireGalley = FourCC("e360");

        // Archery Range Units
        public static readonly int Bowman = FourCC("e004");
        public static readonly int ImprovedBowman = FourCC("e005");
        public static readonly int CompositeBowman = FourCC("e006");
        public static readonly int ChariotArcher = FourCC("e041");
        public static readonly int ElephantArcher = FourCC("e025");
        public static readonly int HorseArcher = FourCC("e039");
        public static readonly int HeavyHorseArcher = FourCC("e281");

        // Stable Units
        public static readonly int Scout = FourCC("e299");
        public static readonly int Cavalry = FourCC("e037");
        public static readonly int HeavyCavalry = FourCC("e038");
        public static readonly int Cataphract = FourCC("e283");
        public static readonly int Chariot = FourCC("e040");
        public static readonly int ScytheChariot = FourCC("e339");
        public static readonly int WarElephant = FourCC("e046");
        public static readonly int ArmoredElephant = FourCC("e345");
        public static readonly int CamelRider = FourCC("e338");

        // Temple Units
        public static readonly int Priest = FourCC("e125");

        // Academy Units
        public static readonly int Hoplite = FourCC("e093");
        public static readonly int Phalanx = FourCC("e094");
        public static readonly int Centurion = FourCC("e291");

        // Siege Workshop Units
        public static readonly int StoneThrower = FourCC("e035");
        public static readonly int Catapult = FourCC("e036");
        public static readonly int HeavyCatapult = FourCC("e280");
        public static readonly int Ballista = FourCC("e011");
        public static readonly int Helepolis = FourCC("e279");
    }
}