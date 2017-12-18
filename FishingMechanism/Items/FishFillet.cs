using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism.Items
{
	public class FishFillet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fish Steak");
			Tooltip.SetDefault("Increases all stats slightly\nEating raw can poison you");
		}

		public override void SetDefaults()
		{
			item.UseSound = SoundID.Item2;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;
            item.consumable = true;
            item.width = 12;
            item.height = 12;
            item.buffType = mod.BuffType("FishFillet");
            item.buffTime = 3600;
            item.rare = 1;
		}
		public override bool UseItem (Player player)
		{
		    if (Main.rand.Next(3) == 0)
		    {
				player.AddBuff(20, 300);
			}
			return true;
        }
	}
}