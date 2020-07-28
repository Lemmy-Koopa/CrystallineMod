using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CrystallineMod.Projectiles
{
    class BlizzardProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.penetrate = -1;
            projectile.aiStyle = 1;
            projectile.timeLeft = 120;
            projectile.hide = true;
            
            

        }
        public override void AI()
        {
            
            //Dust.NewDust(projectile.Center - new Vector2(0, 0), 0, 0, 68, 0, 0, 150, Color.Snow);
            
            Vector2 drawPos = projectile.Center - Main.screenPosition;
            Vector2 circularMotion = new Vector2(projectile.width, projectile.height) * projectile.scale * 0.95f;
            circularMotion /= 2f;
            Vector2 realCircularMotion = Vector2.UnitY.RotatedByRandom(6.2831854820251465) * circularMotion;           
            
            int numDust = Dust.NewDust(projectile.Center + realCircularMotion, 0, 0, 264);
            Main.dust[numDust].position = realCircularMotion + projectile.Center;
            Main.dust[numDust].velocity = Vector2.Zero;
            Main.dust[numDust].scale *= 1.5f;
            Main.dust[numDust].noGravity = true;
            int dustIndex = Dust.NewDust(new Vector2(projectile.Center.X, projectile.Center.Y), projectile.width, projectile.height, 15 , 0f, 0f, 100, default(Color), 2f);
            Main.dust[dustIndex].scale *= 1.35f;
            Main.dust[dustIndex].noGravity = true;

            if(projectile.scale <= 3) // this scales the projectiles util it scales the projectile until its 3 times the original projectile
            {
                projectile.scale *= 1.03f;
                projectile.width = (int)(projectile.scale * 20); // make the width hitbox bigger
                projectile.height = (int)(projectile.scale * 24);  // makes the height hitbox bigger
            }
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            {
                target.AddBuff(BuffID.Frostburn, 120);
                target.AddBuff(BuffID.Chilled, 120);
            }
        }
    }
}
