namespace War3Map.Aoe.Source
{
    // Implements wc3 natives so they can be used at compile-time.
    public static class DotNet
    {
        /// @CSharpLua.Template = "FourCC({0})"
        public static int FourCC(string code)
        {
            return (code[0]) | (code[1] << 8) | (code[2] << 16) | (code[3] << 24);
        }
    }
}