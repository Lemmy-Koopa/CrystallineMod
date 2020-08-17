using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CrystallineMod.Projectiles
{
    class TundraFrogMistProjectile : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 3;
        }
        public override void SetDefaults()
        {
            projectile.width = 48;
            projectile.height = 63;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.penetrate = -1;
            projectile.aiStyle = 4;
            projectile.timeLeft = 120;
        }

        public override void AI()
        {
           
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            {
                target.AddBuff(BuffID.Frostburn, 120);
                target.AddBuff(BuffID.Chilled, 120);
            }
        }
    }
}
