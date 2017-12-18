using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism.Accessory
{
    public class FisherPerfume : ModItem
    {


        public override void SetDefaults()
        {

            item.width = 24;
            item.height = 24;

            item.value = 20000;
            item.rare = 2;
            item.accessory = true;
        }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Fisher Perfume");
      Tooltip.SetDefault("Increases fish spawn rate by 10%\nThis has no effect on baits");
    }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).fisherPerfume= true;
        }
		public override void AddRecipes()
		{
		    ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(313, 4);
            recipe.AddIngredient(2358, 4);
            recipe.AddIngredient(317, 4);
            recipe.AddIngredient(126, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
