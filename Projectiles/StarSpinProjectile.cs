using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using System;

namespace CrystallineMod.Projectiles
{
    class StarSpinProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 25;
            projectile.height = 26;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.penetrate = -1;
            projectile.aiStyle = -1;
          //  projectile.alpha = 100;
            projectile.timeLeft = 99999;
        }
       
        public override void AI()
        {
			projectile.rotation += 0.4f * projectile.direction;
           
			
			Player player = Main.player[projectile.owner];
			double distance = 80;
			double degree = (double)projectile.ai[1] + (120 * projectile.ai[0]);
			double radius = degree * (Math.PI / 180);
			
			projectile.position.X = player.Center.X - (int)(Math.Cos(radius) * distance) - projectile.width / 2;
			projectile.position.Y = player.Center.Y - (int)(Math.Sin(radius) * distance) - projectile.height / 2;
			projectile.ai[1] += 4f;
			
			Vector2 circularMotion = new Vector2(projectile.width / 1.25f, projectile.height / 1.25f) * projectile.scale * 1.15f;
			circularMotion /= 2f;
			Vector2 realCircularMotion = Vector2.UnitY.RotatedByRandom(6.2831854820251465) * circularMotion;
			for (int i = 0; i < 1; i++) 
			{
				int numDust = Dust.NewDust(projectile.Center, 0, 0, 264);
				Main.dust[numDust].position = realCircularMotion + projectile.Center;
				Main.dust[numDust].scale = 0.65f;
				Main.dust[numDust].position += projectile.velocity;
				Main.dust[numDust].velocity.X = projectile.velocity.X / 3;
				Main.dust[numDust].velocity.Y = projectile.velocity.Y / 3;
				Main.dust[numDust].noGravity = true;
			}
			
			
			if(!player.GetModPlayer<CrystallineModPlayer>().StarlitArmorSet)
			{
				projectile.Kill();
			}
        }
        public override void Kill(int timeLeft)
        {
            
           
            Vector2 usePos = projectile.position;
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);

            for (int i = 0; i < 5; i++)
            {
                // Create a new dust
                Dust dust = Dust.NewDustDirect(usePos, projectile.width, projectile.height, 264);
                dust.position = (dust.position + projectile.Center) / 2f;
                dust.velocity *= 0.5f;
                dust.noGravity = true;
            }          
        }
    }
}