﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;


namespace CrystallineMod
{
    public class CrystallineModGlobalItem : GlobalItem
    {
        int OverclockBuff;
        public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (item.ranged)
            {

                if (player.GetModPlayer<CrystallineModPlayer>().OverclockBuff == true)
                {
                    if (OverclockBuff == 0)
                    {
                        item.useTime -= 1;
                        item.useAnimation -= 1;
                        OverclockBuff = 1;
                    }

                }

                else if(OverclockBuff == 1)
                {
                    OverclockBuff = 0;
                    item.useTime = item.useTime + 1;
                    item.useAnimation = item.useAnimation + 1;
                }               
            }
            return true;
        }
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }

        }


        public override bool CloneNewInstances
        {
            get
            {
                return true;
            }

        }

        int OverclockBuff2;
        public override void OnConsumeAmmo(Item item, Player player)
        {
            if (item.ranged)
            {
                if (player.GetModPlayer<CrystallineModPlayer>().OverclockBuff == true)
                {

                    if (OverclockBuff2 == 0)
                    {
                        item.useTime -= 1;
                        item.useAnimation -= 1;
                        OverclockBuff2 = 1;
                    }


                }    
                
                else if(OverclockBuff2 == 1)
                {
                    OverclockBuff2 = 0;
                    item.useTime = item.useTime + 1;
                    item.useAnimation = item.useAnimation + 1;
                }
            }
        }

    }
}
