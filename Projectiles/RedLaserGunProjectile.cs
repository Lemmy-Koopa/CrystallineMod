using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using System;

namespace CrystallineMod.Projectiles
{
    class RedLaserGunProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 4;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.light = 0.75f;
            projectile.extraUpdates = 2;
            projectile.scale = 1.4f;
            projectile.timeLeft = 600;
            projectile.magic = true;
        }

        private bool rotChanged = false;

        public override void AI()
        {
            if (!rotChanged)
            {
                projectile.rotation = projectile.DirectionTo(Main.MouseWorld).ToRotation() - MathHelper.PiOver2;
                rotChanged = true;
            }
        }
    }
}