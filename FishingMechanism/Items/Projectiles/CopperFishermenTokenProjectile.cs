using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace EastsFishing.FishingMechanism.Items.Projectiles
{
    public class CopperFishermenTokenProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Copper Fishermen Token");
        } 
        public override void SetDefaults()
        {
			projectile.timeLeft = 2400;
            projectile.width = 12;
            projectile.height = 12;
            projectile.aiStyle = 2;
			aiType = 510;
        }
		public override void Kill(int timeLeft)
		{
			Player player = Main.player[projectile.owner];
			Main.PlaySound(18, projectile.position);
			if (Main.rand.Next(94) == 0 && projectile.wet)
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 2423); // FrogLeg
			}
			if (Main.rand.Next(116) == 0 && projectile.wet)
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 3225); // BalloonPufferfish
			}
			if (Main.rand.Next(292) == 0 && projectile.wet)
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 2420); // ZephyrFish
			}
			if (Main.rand.Next(5) == 0 && projectile.wet)
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 71, Main.rand.Next(1, 99)); // Coin
			}
			if (Main.rand.Next(37) == 0 && projectile.wet && player.ZoneSnow && (player.ZoneHoly &&(player.ZoneCorrupt || player.ZoneCrimson)))
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 2429); // ScallyTruffle
			}
		}
    }
}