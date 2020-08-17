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
			DisplayName.SetDefault("Tundra Frog Helement");
			Tooltip.SetDefault("15% increased magic damage");
		}

		public override void SetDefaults()
		{
			item.width = 5;
			item.height = 19;
			item.defense = 2;
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

		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.15f;
			player.setBonus = "Shoots out a forst mist around the player when you collide with an enemy";
			CrystallineModPlayer mPlayer = player.GetModPlayer<CrystallineModPlayer>();
			mPlayer.TundraFrogArmorSet = true;
		}
	}
}