using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using CrystallineMod.Projectiles;

namespace CrystallineMod.Items.Weapons
{
	public class TestSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");

		}

		public override void SetDefaults()
		{
			item.damage = 9;
			item.melee = true;
			item.width = 32;
			item.height = 34;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("TestSwordProjectile");
			item.shootSpeed = 16f;
			item.channel = true;
			item.noUseGraphic = true;

		}
	}
}
