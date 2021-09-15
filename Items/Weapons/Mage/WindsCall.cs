using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PandemoniumMod.Items.Materials.Bars;
using Trinitarian.Items.Materials.Parts;


namespace PandemoniumMod.Items.Weapons.Mage
{
    public class WindsCall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wind's Call");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 19;
            item.magic = true;
            item.mana = 7;
            item.width = 42;
            item.height = 40;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item43;
            item.autoReuse = true;
            item.shoot = ProjectileID.DiamondBolt;
            item.shootSpeed = 8f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<ZephyrBar>(), 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}