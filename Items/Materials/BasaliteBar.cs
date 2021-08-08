using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Pandemonium.Items.Tiles;

namespace Pandemonium.Items.Materials
{
    public class BasaliteBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Basalite Bar");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.material = true;
            item.melee = false;
            item.rare = ItemRarityID.Red;
        }
        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<BasaltOre>(), 4);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
