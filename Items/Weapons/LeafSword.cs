using Terraria;
using Terraria.ModLoader;
namespace CrystallineMod.Items.Weapons
{
    public class LeafSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leaf Sword");
            Tooltip.SetDefault("ae");
        }
        public override void SetDefaults()
        {
            item.damage = 10;
            item.knockBack = 0.6f;
            item.width = item.height = 18;
            item.shoot = ModContent.ProjectileType<Projectiles.Ammo.Arrows.LeafProjectile>();
            item.shootSpeed = 10f;
            item.melee = true;
            item.useAnimation = 12;
            item.useStyle = 1;
            item.useTime = 12;
            item.rare = 2;
            item.value = Item.buyPrice(0,0,6,0);
            item.autoReuse = true;
        }
    }
}