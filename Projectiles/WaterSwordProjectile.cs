using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace CrystallineMod.Projectiles
{
    class WaterSwordProjectile : ModProjectile
    {



        public override void SetDefaults()
        {
            projectile.width = 25;
            projectile.height = 26;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = 2;
            projectile.aiStyle = 3;
            

        }
      
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            {
                target.AddBuff(BuffID.OnFire, 60);
                float projectilespeedX = 0f;
                float projectilespeedY = 3f;
                float projectileknockBack = 4f;
                int projectiledamage = 25;
                float numberProjectiles = 2;
                float rotation = MathHelper.ToRadians(60);
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Projectile.NewProjectile(projectile.position.X, projectile.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("SandStormFlaskProjectile"), projectiledamage, projectileknockBack, projectile.owner, 0f, 0f);
                }
            }

        }

    }
}
