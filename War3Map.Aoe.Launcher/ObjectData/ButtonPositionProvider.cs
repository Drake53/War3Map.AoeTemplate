using System.Collections.Generic;

namespace War3Map.Aoe.Launcher.ObjectData
{
    internal static class ButtonPositionProvider
    {
        private static readonly Dictionary<char, (int, int)> _buttonPositions;

        static ButtonPositionProvider()
        {
            _buttonPositions = new Dictionary<char, (int X, int Y)>();
            _buttonPositions.Add('Q', (0, 0));
            _buttonPositions.Add('W', (1, 0));
            _buttonPositions.Add('E', (2, 0));
            _buttonPositions.Add('R', (3, 0));
            _buttonPositions.Add('A', (0, 1));
            _buttonPositions.Add('S', (1, 1));
            _buttonPositions.Add('D', (2, 1));
            _buttonPositions.Add('F', (3, 1));
            _buttonPositions.Add('Z', (0, 2));
            _buttonPositions.Add('X', (1, 2));
            _buttonPositions.Add('C', (2, 2));
            _buttonPositions.Add('V', (3, 2));
        }

        // TODO: input position and output hotkey instead of having hotkey as input? (makes locatization for QWERTZ keyboards easier)
        public static (int X, int Y) GetButtonPosition(char hotkey)
        {
            if (_buttonPositions.TryGetValue(hotkey, out var pos))
            {
                return pos;
            }

            return (0, -11);
        }
    }
}