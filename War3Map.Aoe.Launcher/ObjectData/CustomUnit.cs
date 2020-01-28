using System;
using System.Collections.Generic;
using System.Linq;

using static War3Map.Aoe.Source.DotNet;

namespace War3Map.Aoe.Launcher.ObjectData
{
    public sealed class CustomUnit
    {
        private static readonly int BaseUnitType = FourCC("hpea");
        //private static readonly int BaseBuildingType = FourCC("htow");

        private static readonly int ModName = FourCC("unam");
        private static readonly int ModIcon = FourCC("uico");
        private static readonly int ModHotkey = FourCC("uhot");
        private static readonly int ModTooltipBasic = FourCC("utip");
        private static readonly int ModTooltipExtended = FourCC("utub");
        private static readonly int ModButtonPositionX = FourCC("ubpx");
        private static readonly int ModButtonPositionY = FourCC("ubpy");
        private static readonly int ModGoldCost = FourCC("ugol");
        private static readonly int ModGoldRepairCost = FourCC("ugor");
        private static readonly int ModLumberCost = FourCC("ulum");
        private static readonly int ModLumberRepairCost = FourCC("ulur");
        private static readonly int ModBuildTime = FourCC("ubld");
        private static readonly int ModRepairTime = FourCC("urtm");
        private static readonly int ModMaxHp = FourCC("uhpm");
        private static readonly int ModRegenerationType = FourCC("uhrt");
        private static readonly int ModWeapon1BaseDamage = FourCC("ua1b");
        private static readonly int ModWeapon1Dice = FourCC("ua1d");
        private static readonly int ModWeapon1SidesPerDie = FourCC("ua1s");
        private static readonly int ModWeapon1Cooldown = FourCC("ua1c");
        private static readonly int ModWeaponsEnabled = FourCC("uaen");
        private static readonly int ModDefense = FourCC("udef");
        private static readonly int ModMovementSpeed = FourCC("umvs");
        private static readonly int ModSightRadiusDay = FourCC("usid");
        private static readonly int ModSightRadiusNight = FourCC("usin");
        private static readonly int ModSoundSet = FourCC("usnd");
        private static readonly int ModGoldBountyBase = FourCC("ubba");
        private static readonly int ModGoldBountyDice = FourCC("ubdi");
        private static readonly int ModGoldBountySidesPerDie = FourCC("ubsi");
        private static readonly int ModLumberBountyBase = FourCC("ulba");
        private static readonly int ModLumberBountyDice = FourCC("ulbd");
        private static readonly int ModLumberBountySidesPerDie = FourCC("ulbs");
        private static readonly int ModFoodCost = FourCC("ufoo");
        private static readonly int ModFoodProduced = FourCC("ufma");

        private static readonly int ModBuildingsBuilt = FourCC("ubui");
        private static readonly int ModTechRequirements = FourCC("ureq");
        private static readonly int ModTechAvailable = FourCC("ures");
        private static readonly int ModAbilities = FourCC("uabi");
        private static readonly int ModUnitsTrained = FourCC("utra");
        private static readonly int ModUpgradesTo = FourCC("uupt");
        private static readonly int ModUpgradesUsed = FourCC("upgr");

        private static readonly int ModCollisionSize = FourCC("ucol");
        private static readonly int ModSelectionScale = FourCC("ussc");
        private static readonly int ModPathingMap = FourCC("upat");

        private static readonly int ModModelPath = FourCC("umdl");
        private static readonly int ModModelScaling = FourCC("usca");
        private static readonly int ModAnimationProperties = FourCC("uani");

        private static readonly int ModUnitClassification = FourCC("utyp");

        private static readonly int ModPathingPrevent = FourCC("upap");
        private static readonly int ModPathingWaterRadius = FourCC("upaw");

        private readonly ObjectModification _modification;
        private readonly List<int> _upgradeAbilities;

        public CustomUnit(int newId)
            : this(BaseUnitType, newId)
        {
        }

        public CustomUnit(int oldId, int newId)
        {
            _modification = new ObjectModification(oldId, newId);
            _upgradeAbilities = new List<int>();
        }

        private CustomUnit(ObjectModification modification)
        {
            _modification = modification;
            _upgradeAbilities = new List<int>();
        }

        public ObjectModification Mods => _modification;

        public CustomUnit Clean()
        {
            _modification.AddModification(new IntModification(ModGoldCost, 0));
            _modification.AddModification(new IntModification(ModGoldRepairCost, 0));
            _modification.AddModification(new IntModification(ModLumberCost, 0));
            _modification.AddModification(new IntModification(ModLumberRepairCost, 0));
            _modification.AddModification(new IntModification(ModGoldBountyBase, 0));
            _modification.AddModification(new IntModification(ModGoldBountyDice, 0));
            _modification.AddModification(new IntModification(ModGoldBountySidesPerDie, 0));
            _modification.AddModification(new IntModification(ModLumberBountyBase, 0));
            _modification.AddModification(new IntModification(ModLumberBountyDice, 0));
            _modification.AddModification(new IntModification(ModLumberBountySidesPerDie, 0));
            _modification.AddModification(new IntModification(ModFoodCost, 1));
            _modification.AddModification(new IntModification(ModFoodProduced, 0));
            _modification.AddModification(new StringModification(ModRegenerationType, "none"));
            _modification.AddModification(new StringModification(ModSoundSet, string.Empty));
            _modification.AddModification(new ListModification(ModBuildingsBuilt));
            _modification.AddModification(new ListModification(ModTechRequirements));
            _modification.AddModification(new ListModification(ModTechAvailable));
            _modification.AddModification(new ListModification(ModAbilities));
            _modification.AddModification(new ListModification(ModUnitsTrained));
            _modification.AddModification(new ListModification(ModUpgradesTo));
            _modification.AddModification(new ListModification(ModUpgradesUsed));

            _modification.AddModification(new FloatModification(ModCollisionSize, 32f - 1, true));
            _modification.AddModification(new FloatModification(ModSelectionScale, 1f, false));

            _modification.AddModification(new StringModification(ModUnitClassification, "_"));

            return this;
        }

        public void SetName(string name)
        {
            _modification.AddModification(new StringModification(ModName, name));
        }

        public void SetHotkey(char hotkey)
        {
            hotkey = $"{hotkey}".ToUpper()[0];
            var (X, Y) = ButtonPositionProvider.GetButtonPosition(hotkey);

            _modification.AddModification(new CharModification(ModHotkey, hotkey));
            _modification.AddModification(new IntModification(ModButtonPositionX, X));
            _modification.AddModification(new IntModification(ModButtonPositionY, Y));
        }

        public void SetCost(int time, int repairtime = 0)
        {
            repairtime = repairtime <= 0 ? time : repairtime;
            _modification.AddModification(new IntModification(ModBuildTime, time));
            _modification.AddModification(new IntModification(ModRepairTime, repairtime));
        }

        public void SetFood(int food)
        {
            if (food < 0)
            {
                _modification.AddModification(new IntModification(ModFoodProduced, -food));
            }
            else
            {
                _modification.AddModification(new IntModification(ModFoodCost, food));
            }
        }

        public void SetTooltip(string description, CreationMethod creationMethod = CreationMethod.Train)
        {
            var hotkey = _modification.GetModification(ModHotkey);
            var name = _modification.GetModification(ModName);

            _modification.AddModification(new StringModification(ModTooltipBasic, $"[|cffffcc00{hotkey}|r] {creationMethod} {name}"));
            _modification.AddModification(new StringModification(ModTooltipExtended, description));
        }

        public void SetAttack(int damage, float attackspeed, int range = 1, string projectile = null)
        {
            _modification.AddModification(new IntModification(ModWeapon1BaseDamage, damage - 1));
            _modification.AddModification(new IntModification(ModWeapon1Dice, 1));
            _modification.AddModification(new IntModification(ModWeapon1SidesPerDie, 1));
            _modification.AddModification(new FloatModification(ModWeapon1Cooldown, attackspeed, true));
            _modification.AddModification(new IntModification(ModWeaponsEnabled, damage > 0 ? 1 : 0));

            if (range > 1)
            {
                // TODO: ranged attacks
                throw new NotImplementedException();
            }
        }

        public void SetDefense(int hp, int armor)
        {
            _modification.AddModification(new IntModification(ModMaxHp, hp));
            _modification.AddModification(new IntModification(ModDefense, armor));
        }

        public void SetSpeed(float movespeed)
        {
            _modification.AddModification(new IntModification(ModMovementSpeed, (int)(200 * movespeed)));
        }

        public void SetSight(int radius)
        {
            var value = radius * 128;
            _modification.AddModification(new IntModification(ModSightRadiusDay, value));
            _modification.AddModification(new IntModification(ModSightRadiusNight, value));
        }

        public void SetSize(int pathingMap)
        {
            SetSize(pathingMap * 64, pathingMap * 2, pathingMap);
        }

        public void SetSize(float collision, float selection, int pathingMap = 0)
        {
            _modification.AddModification(new FloatModification(ModCollisionSize, collision - 1f, true));
            _modification.AddModification(new FloatModification(ModSelectionScale, selection, false));

            if (pathingMap > 0)
            {
                // Assume it's a building.
                // todo: add bool modification?: isbuilding = true
                // also todo: add class BoolModification : FieldModification
                SetClassification(UnitClassification.Mechanical);
                SetFood(0);

                _modification.AddModification(new StringModification(ModPathingMap, pathingMap switch
                {
                    1 => @"PathTextures\4x4SimpleSolid.tga",
                    2 => @"PathTextures\8x8SimpleSolid.tga",
                    3 => @"PathTextures\12x12SimpleSolid.tga",
                    _ => "",
                }));
            }
        }

        // Used for dock.
        public void SetWaterRequirement(float radius)
        {
            _modification.AddModification(new StringModification(ModPathingPrevent, "unwalkable"));
            _modification.AddModification(new FloatModification(ModPathingWaterRadius, radius, true));
        }

        public void SetModel(string path, string animationProperties, float scaling = 1f)
        {
            _modification.AddModification(new StringModification(ModModelPath, path));
            _modification.AddModification(new StringModification(ModAnimationProperties, animationProperties));
            _modification.AddModification(new FloatModification(ModModelScaling, scaling, false));
        }

        public void SetIcon(string iconName)
        {
            _modification.AddModification(new StringModification(ModIcon, $@"ReplaceableTextures\CommandButtons\BTN{iconName}.tga"));

#if DEBUG
            SetName(iconName);
#endif
        }

        public void SetSoundSet(SoundSet soundSet)
        {
            _modification.AddModification(new StringModification(ModSoundSet, soundSet.ToString()));
        }

        public void SetBuilds(IEnumerable<int> buildings)
        {
            _modification.AddModification(new ListModification(ModBuildingsBuilt, buildings.ToArray()));
            AddAbility(FourCC("Ahrp"));
        }

        public void SetTechRequires(IEnumerable<int> technologies)
        {
            _modification.AddModification(new ListModification(ModTechRequirements, technologies));
        }

        public void SetTechAvailable(params int[] technologies)
        {
            _modification.AddModification(new ListModification(ModTechAvailable, technologies));
        }

        public void SetTechAvailable(IEnumerable<int> technologies)
        {
            _modification.AddModification(new ListModification(ModTechAvailable, technologies));
        }

        public void AddAbility(int ability)
        {
            if (_modification.GetModification(ModAbilities) is ListModification listModification)
            {
                // Create a new ListModification, because the method UpgradesTo does not create a new ability list for the cloned CustomUnit.
                _modification.AddModification(new ListModification(ModAbilities, listModification.Append(ability).ToArray()));
            }
            else
            {
                _modification.AddModification(new ListModification(ModAbilities, ability));
            }
        }

        public void AddAbilities(params int[] abilities)
        {
            foreach (var ability in abilities)
            {
                AddAbility(ability);
            }
        }

        public void AddUpgradeAbilities()
        {
            foreach (var upgrade in _upgradeAbilities)
            {
                AddAbility(upgrade);
            }

            _upgradeAbilities.Clear();
        }

        public void RemoveAbility(int ability)
        {
            if (_modification.GetModification(ModAbilities) is ListModification listModification)
            {
                _modification.AddModification(new ListModification(ModAbilities, listModification.Where(i => i != ability).ToArray()));
            }
            else
            {
                throw new Exception("cannot remove ability when unit has no abils");
            }
        }

        public void SetUnitsTrained(params int[] units)
        {
            _modification.AddModification(new ListModification(ModUnitsTrained, units));
        }

        public void SetUnitsTrained(IEnumerable<int> units)
        {
            _modification.AddModification(new ListModification(ModUnitsTrained, units));
        }

        // TODO: ModUpgradesTo, ModUpgradesUsed
        // public void SetUpgradesTo

        // public void SetUpgradesUsed // building masonry

        public void SetClassification(params UnitClassification[] classifications)
        {
            _modification.AddModification(new StringModification(ModUnitClassification, classifications.Length > 0
                ? classifications.Select(c => c.ToString().ToLower()).Aggregate((accum, next) => $"{accum},{next}")
                : "_"));
        }

        public CustomUnit UpgradesTo(int newId, int techId, out ObjectModification chaosAbility, bool autoAddAbility = true)
        {
            var newCustomUnit = new CustomUnit(new ObjectModification(_modification.OldId, newId, _modification.ToArray()));

            var chaosAbilityCode = newId + (1 << 21);
            chaosAbility = new ObjectModification(FourCC("Srtt"), chaosAbilityCode,
                new ListModification(FourCC("areq"), techId),
                new ListModification(FourCC("Cha1"), newId));

            if (autoAddAbility)
            {
                AddAbility(chaosAbilityCode);
            }
            else
            {
                // If a unit upgrades to multiple units, store the upgrade ability so it can later be added to the ability list using the AddUpgradeAbilities method.
                // This ensures that upgraded units after the first one do not also receive the ability for the first upgraded unit.
                _upgradeAbilities.Add(chaosAbilityCode);
            }

            return newCustomUnit;
        }

        public enum CreationMethod
        {
            Train,
            Upgrade,
            Build,
        }
    }
}