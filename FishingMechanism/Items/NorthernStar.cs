using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.UI.Chat;

namespace EastsFishing.FishingMechanism.Items
{
	public class NorthernStar : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Northern Star");
		    Tooltip.SetDefault("Controls the unmatched order of the galactic objects\nUses 100 health");
        }
		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 34;
			item.height = 30;
			item.maxStack = 1;
			item.value = Item.sellPrice(0, 5, 0, 0);
			item.rare = 3;
			item.noMelee = true;
			item.autoReuse = false;
		}
		public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
		public override bool UseItem(Player player)
        {
			if (Main.rand.Next(player.itemAnimation > 0 ? 10 : 20) == 0)
			{
				Dust.NewDust(new Vector2(player.itemLocation.X, player.itemLocation.Y), 0, 0, 15);
			}
			Lighting.AddLight(player.position, 1f, 1f, 0f);
			{
				item.UseSound = SoundID.Item30;
			    if (Main.time > 54000.0)
		        {
			        Main.time = 0.0;
					if (player.name != "East")
                    {						
                        player.statLifeMax2 -= 100;
					}					
			    }
			    if (Main.time < 54000.0)
		        {
			        Main.time = 54000.0;
					if (player.name != "East")
                    {						
                        player.statLifeMax2 -= 100;
					}					
			    }
			}
		    return true;
		}
	}
}
