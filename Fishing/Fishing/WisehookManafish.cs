using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.Items.Fishing
{
	public class WisehookManafish : ModItem
	{
		Player player = Main.player[Main.myPlayer];
		
		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 18;
			item.maxStack = 999;
			item.rare = 2;
			item.consumable = true;
			item.useStyle = 4;
            item.useTime = 30;
            item.UseSound = SoundID.Item29;
            item.useAnimation = 30;
		}
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wisehook Manafish");
            Tooltip.SetDefault("Permanently increases maximum mana by 10\nCan be used after achieving maximum amount of mana and post-hardmode\nThis effect will be reset after updating the mod");
        }
	    public override void ModifyTooltips(List<TooltipLine> tooltips)
	    {
	 	    {
			    TooltipLine line = new TooltipLine(mod, "WisehookManafish", ("You used " + ("" + EastsFishingGlobalPlayer.WisehookManaFishMana + " out of " + (EastsFishingGlobalPlayer.WisehookManaFishManaMax)) + " fishes"));
			    line.overrideColor = new Color(255, 255, 255);
			    tooltips.Add(line);
		    } 
	    }		
	    public override bool UseItem (Player player)
	    {
			if (EastsFishingGlobalPlayer.WisehookManaFishMana < EastsFishingGlobalPlayer.WisehookManaFishManaMax)
			{
				EastsFishingGlobalPlayer.WisehookManaFishMana += 1;
				player.ManaEffect(10);
			}
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (EastsFishingGlobalPlayer.WisehookManaFishMana < EastsFishingGlobalPlayer.WisehookManaFishManaMax && Main.hardMode && (player.statManaMax >= 200))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
