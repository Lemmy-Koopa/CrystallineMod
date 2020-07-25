using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using CrystallineMod.Projectiles;


namespace CrystallineMod.Items.Weapons
{
    public class WaterSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("WaterSword");
            Tooltip.SetDefault("On tile collide it makes a water piller which can damage enemies");
        }
        public override void SetDefaults()
        {
            item.damage = 10;
            item.knockBack = 0.6f;
            item.width = item.height = 18;
            item.shoot = ModContent.ProjectileType<WaterSwordProjectile>();
            item.shootSpeed = 10f;
            item.melee = true;
            item.useAnimation = 12;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.thrown = true;
            item.noMelee = true;
            item.useTime = 12;
            item.rare = 2;
            item.value = Item.buyPrice(0, 0, 6, 0);
            item.autoReuse = true;
            item.UseSound = SoundID.Item21;
            item.noUseGraphic = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenBow, 1);
            recipe.AddIngredient(mod.ItemType("WaterElement"), 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Player player)
        {
            // Ensures no more than one spear can be thrown out, use this when using autoReuse
            return player.ownedProjectileCounts[item.shoot] < 1;
        }
    }
}