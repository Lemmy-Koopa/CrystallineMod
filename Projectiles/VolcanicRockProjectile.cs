using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CrystallineMod.Projectiles
{
    class VolcanicRockProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = -1;
            projectile.aiStyle = 1;
            projectile.timeLeft = 120;

            aiType = 686;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 60);
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {

            {
                
                float projectilespeedX = 0f;
                float projectilespeedY = 3f;
                float projectileknockBack = 4f;
                int projectiledamage = 25;
                float numberProjectiles = 2;
                float rotation = MathHelper.ToRadians(60);
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Projectile.NewProjectile(projectile.position.X, projectile.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("SmallHellstoneProjectile"), projectiledamage, projectileknockBack, projectile.owner, 0f, 0f);
                }
            }
            return true;
        }
        // the explotion is place holder until i get a sprite for it



    }
}
