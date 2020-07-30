using Terraria.ModLoader;
using Terraria.ID;

namespace CrystallineMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class TundraFrogChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("TundraFrog Chestplate");
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
			//recipe.AddIngredient(ItemID.SharkFin, 3);
			recipe.AddIngredient(mod.ItemType("FrostElement"), 15);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}