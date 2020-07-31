using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using System;

namespace CrystallineMod.Projectiles
{
    class RedLaserGunProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 22;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.aiStyle = -1;
            projectile.timeLeft = 120;
            projectile.hide = true;
        }

        public override void AI()
        {
			float num620 = projectile.Center.X;
			float num621 = projectile.Center.Y;
			float num622 = 400f;
			bool flag9 = false;
			int num623 = 0;
			
				for (int num624 = 0; num624 < 200; num624++)
				{
					if (Main.npc[num624].CanBeChasedBy(this) && projectile.Distance(Main.npc[num624].Center) < num622 && Collision.CanHit(projectile.Center, 1, 1, Main.npc[num624].Center, 1, 1))
					{
						float num625 = Main.npc[num624].position.X + (float)(Main.npc[num624].width / 2);
						float num626 = Main.npc[num624].position.Y + (float)(Main.npc[num624].height / 2);
						float num627 = Math.Abs(projectile.position.X + (float)(projectile.width / 2) - num625) + Math.Abs(projectile.position.Y + (float)(projectile.height / 2) - num626);
						if (num627 < num622)
						{
							num622 = num627;
							num620 = num625;
							num621 = num626;
							flag9 = true;
							num623 = num624;
						}
					}
				}

			if (flag9)
			{
							
				float num633 = 28f;
				
				Vector2 vector50 = new Vector2(projectile.position.X + (float)projectile.width * 0.5f, projectile.position.Y + (float)projectile.height * 0.5f);
				float num634 = num620 - vector50.X;
				float num635 = num621 - vector50.Y;
				float num636 = (float)Math.Sqrt(num634 * num634 + num635 * num635);
				float num637 = num636;
				num636 = num633 / num636;
				num634 *= num636;
				num635 *= num636;
				
				projectile.velocity.X = (projectile.velocity.X * 20f + num634) / 21f;
				projectile.velocity.Y = (projectile.velocity.Y * 20f + num635) / 21f;
				
			}

			int dustIndex = Dust.NewDust(new Vector2(projectile.Center.X, projectile.Center.Y), projectile.width, projectile.height, 90, 0f, 0f, 100, default(Color), 2f);
			Main.dust[dustIndex].scale *= 0.737f;
			Main.dust[dustIndex].noGravity = true;
		}
	}   
}