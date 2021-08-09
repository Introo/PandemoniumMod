using Microsoft.Xna.Framework;
using Pandemonium.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pandemonium.Items.Weapons.Melee
{
    public class BasaliteCleaver : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Basalite Cleaver");
        }

        public override void SetDefaults()
        {
            item.damage = 65;
            item.melee = true;
            item.width = 52;
            item.height = 55;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 4f;
            item.crit = 4;
            item.value = Item.sellPrice(0, 3, 80, 0);
            item.rare = ItemRarityID.Red;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            float projectilespeedX = 5;
            float projectilespeedY = 5;
            int projectiledamage = 90;
            float projectileknockBack = 2;
            Projectile.NewProjectile(Main.mouseX, Main.mouseY, projectilespeedX, projectilespeedY, ProjectileID.JavelinFriendly, projectiledamage, projectileknockBack, Main.myPlayer, 0f, 0f);
            Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, ProjectileID.SolarWhipSwordExplosion, projectiledamage, projectileknockBack, Main.myPlayer, 0f, 0f);
        }
        public override bool UseItem(Player player)
        {
            if(player.whoAmI == Main.myPlayer)
            {
                float projectilespeedX = 5;
                float projectilespeedY = 5;
                int projectiledamage = 90;
                float projectileknockBack = 2;
                Projectile.NewProjectile(Main.mouseX, Main.mouseY, projectilespeedX, projectilespeedY, ProjectileID.Skull, projectiledamage, projectileknockBack, Main.myPlayer);
                Projectile.NewProjectile(Main.mouseX, Main.mouseY, projectilespeedX, projectilespeedY, ProjectileID.Skull, projectiledamage, projectileknockBack, Main.myPlayer);
                Projectile.NewProjectile(Main.mouseX, Main.mouseY, projectilespeedX, projectilespeedY, ProjectileID.Skull, projectiledamage, projectileknockBack, Main.myPlayer);
                return true;
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Muramasa, 1);
            recipe.AddIngredient(ModContent.ItemType<BasaliteBar>(), 5);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
        }
    }
}