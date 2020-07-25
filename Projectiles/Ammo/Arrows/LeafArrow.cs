using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace CrystallineMod.Projectiles.Ammo.Arrows
{
    public class LeafArrow : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Can Penetrate 3 enemies at a time");
            //Main.projFrames[projectile.type] = 5;
        }

        public override void SetDefaults()
        {
            projectile.width = 24;
            projectile.height = 14;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.aiStyle = 1;
            projectile.damage = 6;
            projectile.knockBack = 0.3f;
            projectile.penetrate = 3;
        }
       
    }
}