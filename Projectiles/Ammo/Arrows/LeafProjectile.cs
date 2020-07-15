using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace CrystallineMod.Projectiles.Ammo.Arrows
{
    public class LeafProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leaf");
            //Main.projFrames[projectile.type] = 5;
        }

        public override void SetDefaults()
        {
            projectile.width = 24;
            projectile.height = 14;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.aiStyle = -1;
            projectile.damage = 6;
            projectile.knockBack = 0.3f;
            projectile.penetrate = 3;
        }
        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation();
            /*if(++projectile.frameCounter >= 5)
            {
                projectile.frame++;
                if(projectile.frame == 5) projectile.frame = 0;
                projectile.frameCounter = 0;
            }*/
        }
    }
}