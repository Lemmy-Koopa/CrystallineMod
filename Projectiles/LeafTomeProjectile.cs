
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;


namespace CrystallineMod.Projectiles
{
    class LeafTomeProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.penetrate = -1;
            //projectile.aiStyle = -1;
            projectile.timeLeft = 360;
           
        }
        

        int Timer;


        public override void AI()
        {
            
            Projectile projectile = base.projectile;
            projectile.velocity.X = projectile.velocity.X * 0.93f;
            Projectile projectile2 = projectile;
            projectile2.velocity.Y = projectile2.velocity.Y * 0.93f;

            //Projectile Dust
            int dustIndex = Dust.NewDust(new Vector2(projectile.Center.X, projectile.Center.Y), projectile.width, projectile.height, 110, 0f, 0f, 100, default(Color), 2f);
            Main.dust[dustIndex].scale *= 0.8f;
            Main.dust[dustIndex].noGravity = true;

            //Timer
            Timer++;
            if (Timer >= 15)
            {
                for (int i = 0; i < 2; i++)
                {
                    float ReqBad = Main.rand.Next(-1, 4);                  
                    float speedX = projectile.velocity.X * 0.8f; 
                    float speedY = projectile.velocity.Y * 0.8f * 0.01f + Main.rand.Next(-5, 5) * 0.4f;
                    Projectile.NewProjectile(projectile.position.X + speedX, projectile.position.Y + speedY, speedX, speedY + ReqBad, mod.ProjectileType("RazorLeafProjectile"), (int)(projectile.damage * 0.8), 0f, Main.myPlayer, 0f, 1f);
                    
                }
                projectile.Kill();
            }
        }

    }
}

