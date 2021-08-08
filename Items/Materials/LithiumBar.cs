using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Pandemonium.Items.Materials
{
    public class LithiumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lithium Bar");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.material = true;
            item.melee = false;
            item.rare = ItemRarityID.Gray;
        }
        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<LithiumOre>(), 3);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
