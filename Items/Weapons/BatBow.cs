
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace CrystallineMod.Items.Weapons
{
	public class BatBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Converts Arrows into Eco Arrows which bounce off walls.");
		}

		public override void SetDefaults() {
			item.damage = 20;
			item.ranged = true;
			item.width = 32;
			item.height = 64;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 0, 20, 0);
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = ProjectileID.PurificationPowder; 
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.Arrow;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.WoodenArrowFriendly)
			{
				type = ModContent.ProjectileType<Projectiles.Ammo.Arrows.EcoArrow>();
			}
			return true;
		}
    }
}
