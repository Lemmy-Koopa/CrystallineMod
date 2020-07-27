using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using static Terraria.ModLoader.ModContent;
using System;

namespace CrystallineMod.Items.Weapons
{
	public class CrossBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The Longer you hold down the mouse the stronger it gets");
		}

		public override void SetDefaults()
		{
			item.damage = 1;
			item.ranged = true;
			item.width = 22;
			item.height = 32;
			item.useTime = 28;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = ProjectileID.PurificationPowder;
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.Arrow;
			item.channel = true;
		}
		int ShootCount;
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Projectile.NewProjectile(player.Center.X, player.Center.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0f, 0f);
			bool channeled = (player.itemAnimation > 1 || player.channel) && !player.noItems && !player.CCed;


			if (channeled)
			{
				ShootCount++; // if item is being held it incresses the shoot count
			}


			if (ShootCount == 5)
			{
				item.damage *= 10;
			}


			/*if(ShootCount <= 4)
            {
				item.damage = 1;
            }*/



			return false;	
        }
		
		
        public override void ModifyWeaponDamage(Player player, ref float add, ref float mult, ref float flat) 
        {

			bool channeled = (player.itemAnimation > 1 || player.channel) && !player.noItems && !player.CCed;


			if (!channeled)
			{
				 
				ShootCount = 0;
			}


			if (ShootCount <= 4)
			{
				item.damage = 1;
			}

		}
    }
}