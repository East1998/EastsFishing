using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace EastsFishing.Items.Potions
{
    public class SunPotion : ModItem
    {
        public override void SetDefaults()
        {

            item.UseSound = SoundID.Item3;  
            item.useStyle = 2;    
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;         
            item.consumable = true; 
			item.value = Item.sellPrice(0, 0, 2, 0);
            item.width = 20;
            item.height = 28;

            item.rare = 1;
            item.buffType = mod.BuffType("Sun"); 
            item.buffTime = 20000;    // 20000 = 6 min
            return;
        }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Sun Potion");
      Tooltip.SetDefault("Increase stats during the day");
    }
		public override void AddRecipes()
		{
		    ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.Bottles);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(null, "Sunfish", 1);
			recipe.AddIngredient(ItemID.Daybloom, 3); 
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
