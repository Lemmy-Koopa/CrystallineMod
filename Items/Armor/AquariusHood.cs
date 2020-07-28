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
	public class AquariusHood: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("AquariusHood");
			Tooltip.SetDefault("Allows you to swim in water");
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
			recipe.AddIngredient(ItemID.SharkFin, 4);
			recipe.AddIngredient(mod.ItemType("WaterElement"), 20);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<AquariusChestplate>() && legs.type == ModContent.ItemType<AquariusBoots>();
		}


		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Low chance to increase fire rate of all ranged weapons";
			Lighting.AddLight(player.Bottom, 0.75f, 0.71f, 1.08f);
			player.GetModPlayer<CrystallineModPlayer>().OverclockArmor = true;

		}

        public override void ArmorSetShadows(Player player)
        {
			player.armorEffectDrawShadow = true;
			player.armorEffectDrawOutlines = true;
        }

		
	}
}

		
