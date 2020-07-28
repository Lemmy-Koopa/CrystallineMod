using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CrystallineMod.Projectiles
{
    class RockFragmentProjectile2 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.penetrate = -1;
            projectile.aiStyle = 14;
            projectile.timeLeft = 120;
            projectile.hide = true;



        }
    }
}
