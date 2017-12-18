using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism.Items
{
	public class MasterFood : ModItem
	{
		public override void SetDefaults()
		{
			item.noMelee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 1;
			item.rare = 3;
			item.UseSound = SoundID.Item106;
			item.shootSpeed = 9f;
			item.shoot = mod.ProjectileType("MasterFoodProjectile");
		}
		public override bool AltFunctionUse(Player player)
		{
			for (int k = 0; k < Main.projectile.Length; k++)
            { 
		        Projectile proj = Main.projectile[k];
                if (proj.active && proj.type == item.shoot && proj.owner == player.whoAmI)
                { 
                    proj.Kill();
                }
            }
            return false;
		}
        public override bool CanUseItem(Player player) // this allows player to use the item if there aren't any dragon skulls
		{
			for (int z = 0; z < Main.projectile.Length; z++)
            { 
		        Projectile proj = Main.projectile[z];
                if (proj.active && proj.type == item.shoot && proj.owner == player.whoAmI)
                { 
                    return false;
                }
            }
            return true;
		}
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Master Food Bottle");
			Tooltip.SetDefault("Throws a master bait to attract fishes every 4 seconds\nOnly one bait can be used at a time\nRight-click to destroy existing baits\nBaits won't work outside the water");
        }
		public override void AddRecipes()
		{
		    ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2676, 20);
            recipe.AddIngredient(126, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
