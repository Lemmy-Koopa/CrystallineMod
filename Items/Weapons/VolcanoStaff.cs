using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using CrystallineMod.Projectiles;

namespace CrystallineMod.Items.Weapons
{
	public class VolcanoStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			Item.staff[item.type] = true;
			Tooltip.SetDefault("ae");

		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.magic = true;
			item.mana = 5;
			item.width = 26;
			item.height = 38;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = Item.buyPrice(0, 0, 15, 80);
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ProjectileType<VolcanicRockProjectile>();
			item.shootSpeed = 16f;
			item.scale = 1.5f;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(mod.ItemType("FireElement"), 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
