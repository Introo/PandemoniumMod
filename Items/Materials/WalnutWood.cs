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
    public class WalnutWood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Walnut Wood");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 22;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.rare = ItemRarityID.White;
        }
    }
}
