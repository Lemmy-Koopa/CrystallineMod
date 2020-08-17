using Terraria.ModLoader;
using Terraria.ID;
using System.Security.Policy;
using Terraria;

namespace CrystallineMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class TundraFrogChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tundra Frog Chestplate");
			Tooltip.SetDefault("5% increased magic damage and crit");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.defense = 3;
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
       

        public override void UpdateArmorSet(Player player)
        {
			player.magicDamage += 0.05f;
			player.magicCrit = 5;
        }
    }
}