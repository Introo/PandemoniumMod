using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Pandemonium.Items.Materials
{
    public class TerraAlloy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terra Alloy");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.material = true;
            item.melee = false;
            item.rare = ItemRarityID.Green;
        }
        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<BasaliteBar>(), 1);
            recipe.AddIngredient(ModContent.ItemType<GlacieriteBar>(), 1);
            recipe.AddIngredient(ModContent.ItemType<ZephyrBar>(), 1);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
