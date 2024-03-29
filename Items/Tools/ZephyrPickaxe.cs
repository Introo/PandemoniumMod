﻿using Microsoft.Xna.Framework;
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

namespace Pandemonium.Items.Tools
{
    public class ZephyrPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zephyr Pickaxe");

        }
        public override void SetDefaults()
        {
            item.melee = true;
            item.maxStack = 1;
            item.pick = 55;
            item.width = 52;
            item.height = 48;
            item.damage = 12;
            item.useTime = 11;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 23;
            item.autoReuse = true;
            item.useTurn = true;
            item.UseSound = SoundID.Item1;
            item.rare = ItemRarityID.Blue;
        }
        public override void AddRecipes()
        {
            ModRecipe modRecipe = new ModRecipe(mod);
            modRecipe.AddIngredient(ModContent.ItemType<ZephyrBar>(), 12);
            modRecipe.SetResult(this);
            modRecipe.AddRecipe();
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.WhiteTorch);
        }
        public override void RightClick(Player player)
        {
            for (int k = 0; k > 15; k++)
            {
                player.AddBuff(BuffID.Mining, 10);
                k = 0;
            }
        }
    }
}
