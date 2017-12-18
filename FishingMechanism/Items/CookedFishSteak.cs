using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism.Items
{
	public class CookedFishSteak : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cooked Fish Steak");
			Tooltip.SetDefault("Increases all stats slightly");
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
            item.buffTime = 7200;
            item.rare = 1;
		}
		public override void AddRecipes()
		{
		    ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.CookingPots);
			recipe.AddIngredient(mod.ItemType("FishFillet"), 1);
			recipe.anyWood = true;
			recipe.anyIronBar = true;
			recipe.SetResult(this,1);
			recipe.AddRecipe();
        }
	}
}