using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace CrystallineMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class AquariusChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aquarius Chestplate");
			Tooltip.SetDefault("3% increased range damage \n2% increased range critical strike chance");
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
			recipe.AddIngredient(ItemID.SharkFin, 5);
			recipe.AddIngredient(mod.ItemType("WaterElement"), 25);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override void UpdateEquip(Player player)
        {
			player.rangedDamage += 0.03f;
			player.rangedCrit += 2;
        }
    }
}
