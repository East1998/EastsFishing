using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism.Items
{
	public class CopperFishermenToken : ModItem
	{
		public override void SetDefaults()
		{
			item.noMelee = true;
			item.consumable = true;
			item.noUseGraphic = true;
			item.maxStack = 999;
			item.width = 20;
			item.height = 20;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 1;
			item.rare = 0;
			item.UseSound = SoundID.Item7;
			item.shootSpeed = 9f;
			item.shoot = mod.ProjectileType("CopperFishermenTokenProjectile");
		}
		public override bool UseItem (Player player)
	    {
			Main.PlaySound(15, player.position);
			return true;
		}
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Copper Fishermen Token");
			Tooltip.SetDefault("Throwing this into the water might grant you useful items\nUsing the token in a respective biome can cause that biome's item to drop\nYou can get multiple drops at once");
        }
	}
}
