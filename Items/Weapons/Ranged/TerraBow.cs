using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Pandemonium;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using System;
using Steamworks;
using System.Threading;
using Pandemonium.Items.Materials;

namespace Pandemonium.Items.Weapons.Ranged
{
    public class TerraBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terra Bow");
        }
        public override void SetDefaults()
        {
            item.ranged = true;
            item.shoot = AmmoID.Arrow;
            item.damage = 66;
            item.width = 18;
            item.height = 70;
            item.useTime = 40;
            item.shootSpeed = 25f;
            item.noMelee = true;
            item.knockBack = 2f;
            item.useStyle = 5;
            item.useAnimation = 30;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
        }
        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .20f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, nameof(TerraAlloy), 16);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

}
