using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using System;

namespace CrystallineMod.Projectiles
{
    class StarProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 25;
            projectile.height = 26;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.penetrate = 2;
            projectile.aiStyle = 5;
            projectile.timeLeft = 180;
        }
       
        public override void AI()
        {
            projectile.rotation += 0.4f * projectile.direction;
        }
    }
}