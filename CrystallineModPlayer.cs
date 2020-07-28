
using CrystallineMod.Buffs;
using System.Security.Policy;
using Terraria.ModLoader;

namespace CrystallineMod
{
    public class CrystallineModPlayer : ModPlayer
    {
        public bool OverclockBuff;

        public override void ResetEffects()// Resets the bool to false
        {
            OverclockBuff = false;
            
        }

        public override void Initialize()// it Initializes the bool as false
        {
            OverclockBuff = false;
        }

        public override void PostUpdateMiscEffects()
        {
            if (OverclockBuff)
            {

            }

            if (!player.HasBuff(ModContent.BuffType<OverclockBuff>()))
            {
                OverclockBuff = false;
            }
        }
    }
}
