using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;


namespace CrystallineMod.Projectiles
{
    class RazorLeafProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 4;
        }
        public override void SetDefaults()
        {
            projectile.width = 31;
            projectile.height = 18;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.penetrate = -1;
            projectile.aiStyle = -1;
            projectile.timeLeft = 180;

        }
        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)// if its a bool make it return to true or false
        {
            projectile.frameCounter++;
            if (projectile.frameCounter >= 5)
            {
                projectile.frame++;
                projectile.frameCounter = 0;
                if (projectile.frame > 3)
                {
                    projectile.frame = 0;
                }
            }

            return true;
        }
        public override void AI()
        {
            int dustIndex = Dust.NewDust(new Vector2(projectile.Center.X, projectile.Center.Y), projectile.width, projectile.height, 110, 0f, 0f, 100, default(Color), 2f);
            Main.dust[dustIndex].scale *= 0.28f;
            Main.dust[dustIndex].noGravity = true;
        }

        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 5; i++)
            {
                int dustIndex = Dust.NewDust(new Vector2(projectile.Center.X, projectile.Center.Y), projectile.width, projectile.height, 110, 0f, 0f, 100, default(Color), 2f);
                Main.dust[dustIndex].scale *= 0.5f;
                Main.dust[dustIndex].noGravity = true;

            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.immune[projectile.owner] = 5; // it changes the enemies immunites frames that way you can hit the enemies more without the problem of immunies frames
        }
    }
}

