using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using CrystallineMod.Projectiles;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace CrystallineMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class TundraFrogHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("TundraFrog Helement");
		}

		public override void SetDefaults()
		{
			item.width = 5;
			item.height = 19;
			item.defense = 3;
			item.value = 2000;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddIngredient(ItemID.SharkFin, 4);
			recipe.AddIngredient(mod.ItemType("FrostElement"), 20);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<TundraFrogChestplate>() && legs.type == ModContent.ItemType<TundraFrogBoots>();
		}
	}
}