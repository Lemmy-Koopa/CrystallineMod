using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using CrystallineMod.Projectiles;

namespace CrystallineMod.Items.Weapons
{
	public class BlizzardStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Fires a blizzard mist projectile which slows enemies down");

		}

		public override void SetDefaults()
		{
			item.damage = 9;
			item.magic = true;
			item.mana = 7;
			item.width = 32;
			item.height = 34;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = Item.buyPrice(0, 0, 7, 20);
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ProjectileType<BlizzardProjectile>();
			item.shootSpeed = 16f;

		}
	}
}
