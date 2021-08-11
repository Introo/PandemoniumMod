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
using Terraria.Graphics.Shaders;

namespace Pandemonium.Items.Tools
{
    public class GlacieritePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glacierite Pickaxe");

        }
        public override void SetDefaults()
        {
            item.melee = true;
            item.maxStack = 1;
            item.pick = 195;
            item.width =  52;
            item.height = 54;
            item.damage = 40;
            item.useTime = 9;
            item.useAnimation = 23;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;
            item.rare = ItemRarityID.Cyan;
        }
        public override void AddRecipes()
        {
            ModRecipe modRecipe = new ModRecipe(mod);
            modRecipe.AddIngredient(ModContent.ItemType<GlacieriteBar>(), 12);
            modRecipe.SetResult(this);
            modRecipe.AddRecipe();
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.BlueTorch);
        }
    }
}
