using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystallineMod.Projectiles
{
    public class CeriumBoltB : ModProjectile
    {
        public override void SetDefaults()
        {
            //projectile.name = "Cerium Bolt";
            projectile.width = 28;
            projectile.height = 60;
            projectile.aiStyle = 1;
            projectile.friendly = false;
            //projectile.magic = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 240;
            //projectile.alpha = 255;
            projectile.extraUpdates = 0;
            projectile.light = 1;
            aiType = ProjectileID.BoneJavelin;

        }

        public override void AI()
        {
            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 5, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);

            Player player = Main.LocalPlayer;

            if (player.Center.X - projectile.Center.X <= 0 && player.Center.Y - projectile.Center.Y <= 0)
            {
                player.statLife += 5;
                projectile.Kill();
            }

        }

        public override void Kill(int timeLeft)
        {
            for (int i = 0; i < 5; i++)
            {
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 5);
            }
            Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y);
        }
    }
}