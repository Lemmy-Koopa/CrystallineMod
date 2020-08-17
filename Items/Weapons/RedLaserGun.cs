
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using CrystallineMod.Projectiles;
using Terraria;
using System;

namespace CrystallineMod.Items.Weapons
{
	public class RedLaserGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shoots a homing laser to chase your foes");

		}

		public override void SetDefaults()
		{
			item.damage = 22;
			item.magic = true;
			item.mana = 5;
			item.width = 36;
			item.height = 20;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = Item.buyPrice(0, 0, 45, 0);
			item.rare = ItemRarityID.Green;
			item.shoot = ProjectileType<RedLaserGunProjectile>();
			item.UseSound = SoundID.Item33;
			item.autoReuse = true;
			item.shootSpeed = 18f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpaceGun, 1);
			recipe.AddIngredient(mod.ItemType("FireElement"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
            int numberProjectiles = 2 + Main.rand.Next(5);
            for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(35)); 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
				
			}
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return false;
		}


      
    }
}