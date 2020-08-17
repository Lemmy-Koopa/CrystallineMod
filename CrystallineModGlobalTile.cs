using CrystallineMod.Items.Elements;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystallineMod
{
    public class CrystallineModGlobalTile : GlobalTile
    {
        public override bool Drop(int i, int j, int type)
        {
            if (Main.netMode != NetmodeID.MultiplayerClient && !WorldGen.noTileActions && !WorldGen.gen)
            {
                if (type == TileID.Trees) // Checking if the tree is planted on grass (Forest)
                {
                    if (Main.rand.Next(6) == 0) // 1 in 6 chance
                        Item.NewItem(i * 16, (j - 5) * 16, 32, 32, ModContent.ItemType<LeafElement>());
                }
            }

            return base.Drop(i, j, type);
        }
    }
}
