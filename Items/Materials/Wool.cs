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
    public class Wool : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wool");
        }
        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 28;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;
            item.rare = ItemRarityID.Gray;
        }
    }
}
