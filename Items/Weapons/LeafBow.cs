using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CrystallineMod.Projectiles.Ammo.Arrows;
using Microsoft.Xna.Framework;
using CrystallineMod.Items.Elements;

namespace CrystallineMod.Items.Weapons
{
	public class LeafBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("LeafBow");
			Tooltip.SetDefault("Shoots 3 arrows per shot \n" + "Has a Chance to convert 2ood arrows into leaf arrows which can perice up to 3 enemies");
		}
		public override void SetDefaults()
		{
			item.damage = 6;
			item.ranged = true;
			item.width = 35;
			item.height = 60;
			item.useTime = 4;
			item.useAnimation = 12;
			item.reuseDelay = 14;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 13;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item5;
			item.autoReuse = false;
			item.shoot = ProjectileID.PurificationPowder;
			item.shootSpeed = 14f;
			item.useAmmo = AmmoID.Arrow;


		}
         public override void AddRecipes()
         {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenBow, 1);
            recipe.AddIngredient(mod.ItemType("LeafElement"), 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		 }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
			type = Main.rand.Next(new int[] { type, ProjectileID.WoodenArrowFriendly, ModContent.ProjectileType<LeafArrow>()});
			return true;
		}
    }
}