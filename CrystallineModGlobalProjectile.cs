
using CrystallineMod.Buffs;
using Terraria;
using Terraria.ModLoader;



namespace CrystallineMod
{
    public class CrystallineModGlobalProjectile : GlobalProjectile
    {
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
             
        }

        public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit) // the player has a 1 out of 10 chance to gain the buff
        {
			Player player = Main.player[projectile.owner];// This defines that player is the person who shot the projectile
            if(projectile.owner == Main.myPlayer)
            {
                if (projectile.ranged)
                {					
					if(player.GetModPlayer<CrystallineModPlayer>().OverclockArmor == true)
					{
						if (Main.rand.Next(19) == 0)// change to 19
						{
							if (!player.HasBuff(ModContent.BuffType<OverclockBuff>()))
							{
								player.AddBuff(ModContent.BuffType<OverclockBuff>(), 420, false);
							}
							
						}
					}
                }
            }
        }
    }
}
