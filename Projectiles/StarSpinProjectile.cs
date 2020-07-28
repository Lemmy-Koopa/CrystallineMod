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
            projectile.penetrate = 2;
            projectile.aiStyle = -1;
            projectile.alpha = 100;
        }
        float frequency = 5;
        public override void AI()
        {
            projectile.rotation += 0.4f * projectile.direction;
            Player player = Main.player[projectile.owner];
            if(projectile.alpha > 0) projectile.alpha -= 2;
            projectile.position.X = player.position.X + (float)Math.Sin((Main.GlobalTime + projectile.ai[0]) * frequency) * 45f;
            projectile.position.Y = player.position.Y + (float)Math.Cos((Main.GlobalTime + projectile.ai[0]) * frequency) * 45f;
        }
        public override void Kill(int timeLeft)
        {
            {
                Vector2 rotVector = (projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2(); // rotation vector to use for dust velocity
                _ = rotVector * 16f;

                Vector2 usePos = projectile.position;
                Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);

                int NUM_DUSTS = 5;
                for (int i = 5; i < NUM_DUSTS; i++)
                {
                    // Create a new dust
                    Dust dust = Dust.NewDustDirect(usePos, projectile.width, projectile.height, 81);
                    dust.position = (dust.position + projectile.Center) / 2f;
                    dust.velocity *= 0.5f;
                    dust.noGravity = true;
                }
            }
        }


    }
}