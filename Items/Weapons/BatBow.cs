
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CrystallineMod.Items.Weapons
{
	public class BatBow : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Converts Arrows into Eco Arrows which bounce off walls.");
		}

		public override void SetDefaults() {
			item.damage = 20;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; 
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Arrows;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.WoodenArrowFriendly)
			{
				type = ModContent.ProjectileType<EcoArrow>();
			}
			return true;
		}
    }
}
