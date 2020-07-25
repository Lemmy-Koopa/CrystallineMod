using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CrystallineMod.Projectiles
{
    class BlizzardProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 25;
            projectile.height = 26;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.penetrate = 2;
            projectile.aiStyle = 1;
            projectile.timeLeft = 120;
            projectile.alpha = 255;

        }
        public override void AI()
        {
            Dust.NewDust(projectile.Center - new Vector2(2, 2), 0, 0, 68, 0, 0, 100, Color.LightBlue);
        }
    }
}
