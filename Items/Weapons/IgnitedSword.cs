using CrystallineMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace CrystallineMod.Items.Weapons
{
    public class IgnitedSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ignited Sword");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {

            item.damage = 21;
            item.melee = true;
            item.width = 32;
            item.height = 34;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 10000;
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item20;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("IgnitedSwordProjectile");
            item.shootSpeed = 16f;
            item.channel = true;
            item.noUseGraphic = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Obsidian, 20);
            recipe.AddIngredient(mod.ItemType("FireElement"), 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}