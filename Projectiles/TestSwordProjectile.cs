using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using System;
using System.Security.Policy;

namespace CrystallineMod.Projectiles
{
	class TestSwordProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			Main.projFrames[projectile.type] = 28;
		}
		public override void SetDefaults()
		{
			projectile.width = 63;
			projectile.height = 60;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 120;
			projectile.tileCollide = false;
			projectile.ownerHitCheck = true;
			//projectile.localNPCHitCooldown = -1;
			//projectile.usesLocalNPCImmunity = true;

		}

		public override bool PreAI()
		{

			Player player = Main.player[projectile.owner];
			float num = (float)Math.PI / 2f;
			Vector2 vector = player.RotatedRelativePoint(player.MountedCenter);
			num = 0f;

			if (projectile.spriteDirection == -1)
			{
				num = (float)Math.PI;
			}
			if (++projectile.frame >= Main.projFrames[projectile.type])
			{
				projectile.frame = 0;
			}
			projectile.soundDelay--;
			if (projectile.soundDelay <= 0)
			{
				Main.PlaySound(SoundID.Item1, projectile.Center);
				projectile.soundDelay = 12;
			}
			if (Main.myPlayer == projectile.owner)
			{
				if (player.channel && !player.noItems && !player.CCed)
				{
					float num27 = 1f;
					if (player.inventory[player.selectedItem].shoot == projectile.type)
					{
						num27 = player.inventory[player.selectedItem].shootSpeed * projectile.scale;
					}
					Vector2 vector16 = Main.MouseWorld - vector;
					vector16.Normalize();
					if (vector16.HasNaNs())
					{
						vector16 = Vector2.UnitX * player.direction;
					}
					vector16 *= num27;
					if (vector16.X != projectile.velocity.X || vector16.Y != projectile.velocity.Y)
					{
						projectile.netUpdate = true;
					}
					projectile.velocity = vector16;
				}
				else
				{
					projectile.Kill();
				}
			}
			Vector2 vector17 = projectile.Center + (projectile.velocity * 3f);
			Lighting.AddLight(vector17, 0.8f, 0.8f, 0.8f);
			if (Main.rand.Next(3) == 0)
			{
				int num28 = Dust.NewDust(vector17 - projectile.Size / 2f, projectile.width, projectile.height, 63, projectile.velocity.X, projectile.velocity.Y, 100, default(Color), 2f);
				Main.dust[num28].noGravity = true;
				Main.dust[num28].position -= projectile.velocity;
			}


			projectile.position = player.RotatedRelativePoint(player.MountedCenter) - projectile.Size / 2f;
			projectile.rotation = projectile.velocity.ToRotation() + num;
			projectile.spriteDirection = projectile.direction;
			projectile.timeLeft = 2;
			player.ChangeDir(projectile.direction);
			player.heldProj = projectile.whoAmI;
			player.itemTime = 2;
			player.itemAnimation = 2;
			player.itemRotation = (float)Math.Atan2(projectile.velocity.Y * (float)projectile.direction, projectile.velocity.X * (float)projectile.direction);

			return false;
		}

        public override bool? CanHitNPC(NPC target)
        {
			Player player = Main.player[projectile.owner];
			return !target.friendly && player.itemAnimation > 1;
			
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.immune[projectile.owner] = 5;
		}
		
    }
}

