﻿using Terraria.ModLoader;
using Terraria.ID;

namespace CrystallineMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class StarlitChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Starlit Chestplate");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.defense = 4;
			item.value = 25000;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
