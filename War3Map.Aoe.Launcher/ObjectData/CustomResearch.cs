using static War3Map.Aoe.Source.DotNet;

namespace War3Map.Aoe.Launcher.ObjectData
{
    public sealed class CustomResearch
    {
        private static readonly int BaseResearchType = FourCC("Rhpm");

        private static readonly int ModName = FourCC("gnam");
        private static readonly int ModIcon = FourCC("gar1");
        private static readonly int ModHotkey = FourCC("ghk1");
        private static readonly int ModTooltipBasic = FourCC("gtp1");
        private static readonly int ModTooltipExtended = FourCC("gub1");
        private static readonly int ModButtonPositionX = FourCC("gbpx");
        private static readonly int ModButtonPositionY = FourCC("gbpy");
        private static readonly int ModGoldCostBase = FourCC("gglb");
        private static readonly int ModLumberCostBase = FourCC("glmb");
        private static readonly int ModTimeBase = FourCC("gtib");

        private static readonly int ModTechRequirements = FourCC("greq");

        private readonly ObjectModification _modification;

        public CustomResearch(int newId)
            : this(BaseResearchType, newId)
        {
        }

        public CustomResearch(int oldId, int newId)
        {
            _modification = new ObjectModification(oldId, newId);
        }

        private CustomResearch(ObjectModification modification)
        {
            _modification = modification;
        }

        public ObjectModification Mods => _modification;

        public CustomResearch Clean()
        {
            _modification.AddModification(new IntModification(ModGoldCostBase, 0));
            _modification.AddModification(new IntModification(ModLumberCostBase, 0));
            _modification.AddModification(new ListModification(ModTechRequirements));

            return this;
        }

        public void SetName(string name)
        {
            _modification.AddModification(new StringModification(ModName, name));
        }

        public void SetHotkey(char hotkey)
        {
            var (X, Y) = ButtonPositionProvider.GetButtonPosition(hotkey);

            _modification.AddModification(new CharModification(ModHotkey, hotkey));
            _modification.AddModification(new IntModification(ModButtonPositionX, X));
            _modification.AddModification(new IntModification(ModButtonPositionY, Y));
        }

        public void SetCost(int time)
        {
            _modification.AddModification(new IntModification(ModTimeBase, time));
        }

        public void SetTooltip(string description)
        {
            var hotkey = _modification.GetModification(ModHotkey);
            var name = _modification.GetModification(ModName);

            _modification.AddModification(new StringModification(ModTooltipBasic, $"[|cffffcc00{hotkey}|r] Research {name}"));
            _modification.AddModification(new StringModification(ModTooltipExtended, description));
        }

        public void SetIcon(string iconName)
        {
            _modification.AddModification(new StringModification(ModIcon, $@"ReplaceableTextures\CommandButtons\BTN{iconName}.tga"));

#if DEBUG
            SetName(iconName);
#endif
        }
    }
}