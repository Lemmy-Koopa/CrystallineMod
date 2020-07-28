using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace CrystallineMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class AquariusBoots : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aquarius Boots");
			Tooltip.SetDefault("3% increased range damage \n2% increased range critical strike chance");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.defense = 1;
			item.value = 25000;
			

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SharkFin, 3);
			recipe.AddIngredient(mod.ItemType("WaterElement"), 15);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.15f; // Makes the movement speed 15% faster + means that it increases the moveSpeed 
			
		}
	}
}

