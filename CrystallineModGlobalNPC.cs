﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CrystallineMod
{
    public class CrystallineModGlobalNPC : GlobalNPC
    {
		public override void NPCLoot(NPC npc)
		{

			if (npc.type == NPCID.CaveBat)
			{
				if ((Main.rand.Next(99) == 0))
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BatBow"));
				}
			}

			if (npc.type == NPCID.PinkJellyfish)
			{
				if ((Main.rand.Next(3) == 0))
				{
					Item.NewItem(npc.getRect(), mod.ItemType("WaterElement"), Main.rand.Next(1, 3));
				}
			}

			if (npc.type == NPCID.Shark)
			{
				if ((Main.rand.Next(3) == 0))
				{
					Item.NewItem(npc.getRect(), mod.ItemType("WaterElement"), Main.rand.Next(3, 5));
				}
			}

			if (npc.type == NPCID.Squid)
			{
				if ((Main.rand.Next(2) == 0))
				{
					Item.NewItem(npc.getRect(), mod.ItemType("WaterElement"), Main.rand.Next(3, 5));
				}
			}

			if (npc.type == NPCID.PinkJellyfish)
			{
				if ((Main.rand.Next(2) == 0))
				{
					Item.NewItem(npc.getRect(), mod.ItemType("WaterElement"), Main.rand.Next(1, 3));
				}
			}

			if (npc.type == NPCID.SeaSnail)
			{
				if ((Main.rand.Next(2) == 0))
				{
					Item.NewItem(npc.getRect(), mod.ItemType("WaterElement"), Main.rand.Next(3, 5));
				}
			}

			if (npc.type == NPCID.FlyingFish)
			{
				if ((Main.rand.Next(4) == 0))
				{
					Item.NewItem(npc.getRect(), mod.ItemType("WaterElement"), Main.rand.Next(3, 5));
				}
			}

			if (npc.type == NPCID.Hellbat)
			{
				if ((Main.rand.Next(4) == 0))
				{
					Item.NewItem(npc.getRect(), mod.ItemType("FireElement"), Main.rand.Next(1, 3));
				}
			}

			if (npc.type == NPCID.LavaSlime)
			{
				if ((Main.rand.Next(4) == 0))
				{
					Item.NewItem(npc.getRect(), mod.ItemType("FireElement"), Main.rand.Next(1, 3));
				}
			}

			if (npc.type == NPCID.FireImp)
			{
				if ((Main.rand.Next(5) == 0))
				{
					Item.NewItem(npc.getRect(), mod.ItemType("FireElement"), Main.rand.Next(2, 4));
				}
			}

			if (npc.type == NPCID.Demon)
			{
				if ((Main.rand.Next(7) == 0))
				{
					Item.NewItem(npc.getRect(), mod.ItemType("FireElement"), Main.rand.Next(4, 8));
				}
			}
		}
	}
}