using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism.Items.Projectiles
{
	public class NorthernStarProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Northern Star");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.Starfury);
			aiType = ProjectileID.Starfury;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.Starfury;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			for (int i = 0; i < 1; i++)
			{
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, mod.ItemType("NorthernStar"));
			}
			return true;
		}
	}
}