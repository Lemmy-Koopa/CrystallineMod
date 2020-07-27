
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using CrystallineMod.Projectiles;
using Terraria;
using System;

namespace CrystallineMod.Items.Weapons
{
	public class LeafTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");

		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.magic = true;
			item.mana = 1;
			item.width = 32;
			item.height = 34;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<LeafTomeProjectile>();
			item.shootSpeed = 16f;

		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2?(new Vector2(0, 1));
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			
			float numberProjectiles = 5;
			float rotation = MathHelper.ToRadians(30);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .6f;
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X * 2.65f, perturbedSpeed.Y * 2.65f, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}

		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 5;
		}
	}
}