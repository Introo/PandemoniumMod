using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Pandemonium.Items.Materials
{
    public class VoidiumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Voidium Bar");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.material = true;
            item.melee = false;
            item.rare = ItemRarityID.LightRed;
        }
    }
}
