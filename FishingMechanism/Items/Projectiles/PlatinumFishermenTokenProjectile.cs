using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace EastsFishing.FishingMechanism.Items.Projectiles
{
    public class PlatinumFishermenTokenProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Platinum Fishermen Token");
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
			if (Main.rand.Next(61) == 0 && projectile.wet)
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 2423); // FrogLeg
			}
			if (Main.rand.Next(81) == 0 && projectile.wet)
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 3225); // BalloonPufferfish
			}
			if (Main.rand.Next(205) == 0 && projectile.wet)
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 2420); // ZephyrFish
			}
			if (Main.rand.Next(10) == 0 && projectile.wet)
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 74, Main.rand.Next(1, 3)); // Coin
			}
			if (Main.rand.Next(75) == 0 && projectile.wet && !Main.dayTime)
			{
				Projectile.NewProjectile(projectile.position.X, projectile.position.Y - 1000, 1f, 15f, mod.ProjectileType("NorthernStarProj"), 100, 10f, projectile.owner, 0f, 0f);//Northern Star
				Main.NewText("A bright star... Your wish came true !", 255, 255, 0);
			}
			if (Main.rand.Next(21) == 0 && projectile.wet && player.ZoneSnow && (player.ZoneHoly &&(player.ZoneCorrupt || player.ZoneCrimson)))
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, 2429); // ScallyTruffle
			}
		}
    }
}