using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace EastsFishing.FishingMechanism.Items.Projectiles
{
    public class SilverFishermenTokenProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver Fishermen Token");
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
			if (Main.rand.Next(84) == 0 && projectile.wet) // 25
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 2423); // FrogLeg
			}
			if (Main.rand.Next(104) == 0 && projectile.wet) // 31
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 3225); // BalloonPufferfish
			}
			if (Main.rand.Next(263) == 0 && projectile.wet) // 78
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 2420); // ZephyrFish
			}
			if (Main.rand.Next(5) == 0 && projectile.wet)
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 72, Main.rand.Next(1, 50)); // Coin
			}
			if (Main.rand.Next(34) == 0 && projectile.wet && player.ZoneSnow && (player.ZoneHoly &&(player.ZoneCorrupt || player.ZoneCrimson))) // 10
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 2429); // ScallyTruffle
			}
		}
    }
}