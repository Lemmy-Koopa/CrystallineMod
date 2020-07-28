using Terraria;
using Terraria.ModLoader;

namespace CrystallineMod.Buffs
{
    public class OverclockBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("RangedSpeedIncrease");
            Description.SetDefault("Makes ranges weapons shoot faster.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<CrystallineModPlayer>().OverclockBuff = true;
        }
    }
}