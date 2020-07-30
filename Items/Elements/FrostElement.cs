using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystallineMod.Items.Elements
{
    public class FrostElement : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Used to Craft Frost Items.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = ItemRarityID.Blue;

        }


    }
}