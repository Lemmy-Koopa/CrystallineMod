
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystallineMod.Projectiles.Ammo.Arrows
{
    class EcoArrow : ModProjectile
    {
        int Bounces;
        

        //TODO: Make gel on arrow pink (Crim's already on it)

        public override void SetDefaults()
        {
            projectile.arrow = true;
            projectile.width = 10;
            projectile.height = 10;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.noDropItem = true;
            projectile.penetrate = 3;
            Bounces = 2;
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (Bounces > 0)
            {
                Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
                Main.PlaySound(SoundID.Item56, projectile.position);
                if (projectile.velocity.X != oldVelocity.X)
                {
                    projectile.velocity.X = -oldVelocity.X * 0.75f;
                }
                if (projectile.velocity.Y != oldVelocity.Y)
                {
                    projectile.velocity.Y = -oldVelocity.Y * 0.75f;
                }
                projectile.penetrate -= 1;
                Bounces -= 1;
            }
        }
         public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Bounces > 0)
            {
                projectile.velocity.X = -projectile.oldVelocity.X * 0.75f;
                if (projectile.oldVelocity.Y > 0)
                {
                    projectile.velocity.Y = -projectile.oldVelocity.Y * 0.5f;
                }
                else
                {
                    projectile.velocity.Y = -projectile.oldVelocity.Y * 1.5f;
                }
            }
        }
    }
}

   