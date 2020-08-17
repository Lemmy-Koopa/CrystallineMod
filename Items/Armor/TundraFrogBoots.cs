using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace CrystallineMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class TundraFrogBoots : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tundra Frog Boots");
			Tooltip.SetDefault("Provides extra mobility on ice \nIce will not break when you fall on it");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.defense = 2;
			item.value = 25000;


		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddIngredient(ItemID.IceBlock, 3);
			recipe.AddIngredient(mod.ItemType("FrostElement"), 15);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void UpdateEquip(Player player)
		{
			player.iceSkate = true;
			player.autoJump = true;
			player.jumpBoost = true;			
		}
	}
}
