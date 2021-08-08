using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Pandemonium.Items.Materials
{
    public class ZephyrBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zephyr Bar");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(8, 9));
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.material = true;
            item.melee = false;
            item.rare = ItemRarityID.Cyan;
        }
        public override bool PreDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            scale = 1f;
            return base.PreDrawInInventory(spriteBatch, position, frame, drawColor, itemColor, origin, scale);
        }
    }
}
