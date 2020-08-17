using Terraria.ModLoader;
using System;
using System.Security.Policy;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace CrystallineMod.Projectiles
{
    class IgnitedSwordProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 6;
        }
        public override void SetDefaults()
        {
            projectile.width = 159;
            projectile.height = 97;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 120;
            projectile.tileCollide = false;
            projectile.ownerHitCheck = true;
            //projectile.localNPCHitCooldown = -1;
            //projectile.usesLocalNPCImmunity = true;

        }

        public override bool PreAI()
        {

            Player player = Main.player[projectile.owner];
            Vector2 vector = player.RotatedRelativePoint(player.MountedCenter, true);
            bool channeling = player.itemAnimation > 0 && !player.noItems && !player.CCed;


            if (player.velocity.Y <= 1) //checks if the player is on the ground
            {
                
            }





            if (!channeling)
            {
                projectile.Kill();
            }
            if (player.itemAnimation > (int)(8 * (float)player.itemAnimationMax / 9))
            {
                projectile.frame = 0;
            }
            else if (player.itemAnimation > (int)(7 * (float)player.itemAnimationMax / 9))
            {
                projectile.frame = 1;
            }
            else if (player.itemAnimation > (int)(6 * (float)player.itemAnimationMax / 9))
            {
                projectile.frame = 2;
            }
            else if (player.itemAnimation > (int)(5 * (float)player.itemAnimationMax / 9))
            {
                projectile.frame = 3;
            }
            else if (player.itemAnimation > (int)(4 * (float)player.itemAnimationMax / 9))
            {
                projectile.frame = 4;
            }
            else if (player.itemAnimation > (int)(3 * (float)player.itemAnimationMax / 9))
            {
                projectile.frame = 5;
            }
            else if (player.itemAnimation > (int)(2 * (float)player.itemAnimationMax / 9))
            {
                projectile.frame = 6;
            }
            else if (player.itemAnimation > (int)((float)player.itemAnimationMax / 9))
            {
                projectile.frame = 7;
            }
            else
            {
                projectile.frame = 8;
            }
            projectile.position = (projectile.velocity + vector) - projectile.Size / 2f;
            projectile.rotation = projectile.velocity.ToRotation() + (projectile.direction == -1 ? 3.14f : 0);
            projectile.spriteDirection = projectile.direction;
            player.heldProj = projectile.whoAmI;
            player.itemRotation = (float)Math.Atan2((double)(projectile.velocity.Y * (float)projectile.direction), (double)(projectile.velocity.X * (float)projectile.direction));
            return false;


        }


    }
}
