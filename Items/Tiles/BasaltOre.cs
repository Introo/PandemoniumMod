using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;


namespace Pandemonium.Items.Tiles
{
    public class BasaltOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileSpelunker[Type] = true;

            soundType = 21;
            soundStyle = 2;

            drop = mod.ItemType("BasaltOre");

            AddMapEntry(Microsoft.Xna.Framework.Color.OrangeRed);
        }
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.5f;
            g = 0.5f;
            b = 0.5f;
        }
    }
}
