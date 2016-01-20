using System;

using Terraria.ModLoader;

namespace Terradventure
{
    public class Terradventure : Mod
    {
        public override void SetModInfo(out string name, ref ModProperties properties)
        {
            name = "Terradventure";
            properties.Autoload = true;
        }
    }
}
