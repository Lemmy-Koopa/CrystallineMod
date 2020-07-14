using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystallineMod.Projectiles
{
    public class CeriumBolt : ModProjectile
    {
        public override void SetDefaults()
        {
            //projectile.name = "Cerium Bolt";
            projectile.width = 14;
            projectile.height = 30;
            projectile.aiStyle = 0;
            projectile.friendly = true;
            //projectile.magic = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 2000;
            //projectile.alpha = 255;
            projectile.extraUpdates = 0;
            projectile.light = 1;
            aiType = ProjectileID.BoneJavelin;

        }

        public override void AI()
        {
            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 5, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (target.life <= 0)
            {
                float speedX1 = -projectile.velocity.X * 0.8f/* + Main.rand.NextFloat(4f, 8f)*/;
                float speedY1 = -projectile.velocity.Y * 0.8f * 0.01f + Main.rand.Next(-5, 5) * 0.4f;
                Projectile.NewProjectile(projectile.position.X + speedX1, projectile.position.Y + speedY1, speedX1, speedY1, mod.ProjectileType("CeriumBoltB"), (int)(projectile.damage * 4), 0f, Main.myPlayer, 0f, 1f);

                float speedX2 = -projectile.velocity.X * 0.8f/* + Main.rand.NextFloat(4f, 8f)*/;
                float speedY2 = -projectile.velocity.Y * 0.8f * 0.01f + Main.rand.Next(-5, 5) * 0.4f;
                Projectile.NewProjectile(projectile.position.X + speedX2, projectile.position.Y + speedY2, speedX2, speedY2, mod.ProjectileType("CeriumBoltB"), (int)(projectile.damage * 4), 0f, Main.myPlayer, 0f, 1f);
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