using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystallineMod.Items.Elements
{
    public class LeafElement : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Used to Craft Leaf Items.");
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