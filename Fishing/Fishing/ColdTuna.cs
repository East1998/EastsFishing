using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.Items.Fishing
{
	public class ColdTuna : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 14;
			item.height = 18;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 15, 0);
			item.rare = 2;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Cold Tuna");
      Tooltip.SetDefault("");
    }

	}
}
