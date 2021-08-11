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
    public class ZephyrAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zephyr Axe");

        }
        public override void SetDefaults()
        {
            item.melee = true;
            item.maxStack = 1;
            item.axe = 40;
            item.width = 52;
            item.height = 48;
            item.damage = 12;
            item.useTime = 9;
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
    }
}
