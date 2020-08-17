using System;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using CrystallineMod.Buffs;
using static Terraria.ModLoader.ModContent;

namespace CrystallineMod
{
    public class CrystallineModPlayer : ModPlayer
    {
        public bool OverclockBuff;
        public bool OverclockArmor;
        public bool StarlitArmorSet;
        public bool TundraFrogArmorSet;
        public override void ResetEffects()// Resets the bool to false
        {
            OverclockBuff = false;
            OverclockArmor = false;
            StarlitArmorSet = false;
            TundraFrogArmorSet = false;
            
        }

        public override void Initialize()// it Initializes the bool as false
        {
            OverclockBuff = false;
            OverclockArmor = false;
            StarlitArmorSet = false;
            TundraFrogArmorSet = false;
        }
		
		public override void UpdateDead()// it upadtes bools to false when player is dead or something
        {
            OverclockBuff = false;
            OverclockArmor = false;
            StarlitArmorSet = false;
            TundraFrogArmorSet = false;
        }

        public override void OnHitByNPC(NPC npc, int damage, bool crit)
        {
            if (TundraFrogArmorSet)
            {
                float rotation = MathHelper.ToRadians(0);
                for (int i = 0; i < 1; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(player.velocity.X, player.velocity.Y).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (2 - 1))) * .2f;
                    Projectile.NewProjectile(player.Center, perturbedSpeed, ProjectileType<Projectiles.TundraFrogMistProjectile>(), 10, 2, player.whoAmI, i);
                }

            }

        }

        public override void PostUpdateMiscEffects()
        {
            if (!player.HasBuff(ModContent.BuffType<OverclockBuff>()))
            {
                OverclockBuff = false;
            }
			if(StarlitArmorSet)
			{
				float rotation = MathHelper.ToRadians(120);
				if(player.ownedProjectileCounts[ProjectileType<Projectiles.StarSpinProjectile>()] < 3)
				{			
					for (int pp = 0; pp < 10; pp++) 
					{
						int dustIndex = Dust.NewDust(new Vector2(player.velocity.X, player.velocity.Y), player.width, player.height, 264, 0f, 0f, 100, default(Color), 2f);
						Main.dust[dustIndex].scale *= 1.15f;
						Main.dust[dustIndex].noGravity = true;
					}
				
					for (int i = 0; i < 3; i++)
					{
						Vector2 perturbedSpeed = new Vector2(player.velocity.X, player.velocity.Y).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (3 - 1))) * .2f;
						Projectile.NewProjectile(player.Center, perturbedSpeed, ProjectileType<Projectiles.StarSpinProjectile>(), 10, 2, player.whoAmI, i);
					}
				}
			}
        }

        
    }
}
