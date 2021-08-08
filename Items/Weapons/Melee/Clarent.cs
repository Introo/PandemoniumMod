using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pandemonium.Items.Weapons.Melee
{
	public class Clarent : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Clarent");
        }

        public override void SetDefaults()
        {
            item.damage = 65; 
            item.melee = true;
            item.width = 90;
            item.height = 90;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 4f;
            item.crit = 4;
            item.value = Item.sellPrice(0, 3, 80, 0);
            item.rare = ItemRarityID.Pink; 
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DarkShard, 1);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.HallowBar, 12);
        }
    }
}