using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pandemonium.Items.Weapons.Melee
{
    public class Sword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Holy Excalibur");
        }

        public override void SetDefaults()
        {
            item.damage = 58; //Filler 
            item.melee = true;
            item.width = 90;
            item.height = 90;
            item.useTime = 21;
            item.useAnimation = 21;
            item.useStyle = 1;
            item.knockBack = 3f;
            item.crit = 0;
            item.value = Item.sellPrice(0, 1, 0, 0); //Filler
            item.rare = ItemRarityID.Blue; //Filler
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 999);
        }
    }
}