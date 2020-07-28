
using CrystallineMod.Items.Weapons;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace CrystallineMod
{
    class CrystallineModWorld : ModWorld
    {
        public override void PostWorldGen()
        {

            // Place some items in Ice Chests
            int[] itemsToPlaceInIceChests = {ModContent.ItemType<BlizzardStaff>()};
			int itemsToPlaceInIceChestsChoice = 0;
			for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
			{
				Chest chest = Main.chest[chestIndex];
				if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 11 * 36)
				{
					for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
					{
						if (chest.item[inventoryIndex].type == ItemID.None)
						{
							chest.item[inventoryIndex].SetDefaults(itemsToPlaceInIceChests[itemsToPlaceInIceChestsChoice]);
							itemsToPlaceInIceChestsChoice = (itemsToPlaceInIceChestsChoice + 1) % itemsToPlaceInIceChests.Length; chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInIceChests)); 
							// Alternate approach: Random instead of cyclical: chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInIceChests));
							break;
						}
					}
				}
			}
		}
	}
    
}
