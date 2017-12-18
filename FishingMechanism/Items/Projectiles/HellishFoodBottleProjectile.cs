using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace EastsFishing.FishingMechanism.Items.Projectiles
{
    public class HellishFoodBottleProjectile : ModProjectile
    {
		protected int SpawnerTimer = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hellfish Food");
        } 
        public override void SetDefaults()
        {
			projectile.timeLeft = 2100;
            projectile.width = 10;
            projectile.height = 10;
            projectile.aiStyle = 2;
			aiType = 510;
        }
		public override bool OnTileCollide(Vector2 oldVelocity)
        {
			if (projectile.wet)
			{
			    projectile.active = true;
				projectile.velocity.X = 0f;
				projectile.velocity.Y = 0f;
		    }
			return false;
        }
		public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
    public override void AI()
    {
		Player player = Main.player[projectile.owner];
		bool Hell = ((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).ZoneHell;
        if (Main.rand.Next(10) == 0)
        {
          int index = Dust.NewDust(projectile.Center, 8, 8, 6, 0.0f, 0.0f, 0, new Color(), 1f);
          Main.dust[index].position = projectile.Center;
          Main.dust[index].velocity *= 0.2f;
          Main.dust[index].noGravity = true;
          Main.dust[index].scale = 2f;
        }
		SpawnerTimer++;
		
		if (SpawnerTimer == 300)
		{
			SpawnerTimer = 0;
            if (Hell)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Hellfish"));  
            }
		}
		if (Main.rand.Next(3000000) == 0 && Hell)
		{
		    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-50, 50)), (int)(player.position.Y - Main.rand.Next(50, 50)), (mod.NPCType("ObsidianSwordfish")));
		}
	}
}
}