using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using CrystallineMod.Projectiles;
using static Terraria.ModLoader.ModContent;

namespace CrystallineMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class StarlitHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("StarlitHelmet");
		}

		public override void SetDefaults()
		{
			item.width = 5;
			item.height = 19;
			item.defense = 3;
			item.value = 2000;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemType<StarlitChestplate>() && legs.type == ItemType<StarlitBoots>();
		}
		int projTimer = 0;
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Spawns 3 stars around the player and all damage is increased by 10%";
			player.meleeDamage += 0.1f;
			player.thrownDamage += 0.1f;
			player.rangedDamage += 0.1f;
			player.magicDamage += 0.1f;
			player.minionDamage += 0.1f;
			if(player.ownedProjectileCounts[ProjectileType<Projectiles.StarProjectile>()] < 3)
			{
				if(++projTimer >= 24)
				{
					Projectile.NewProjectile(player.Center,Vector2.Zero,ProjectileType<Projectiles.StarProjectile>(),10,2,player.whoAmI,40/*This is the offset value for projectiles*/ * player.ownedProjectileCounts[ProjectileType<Projectiles.StarProjectile>()]);
				}
			}
		}
	}
}
