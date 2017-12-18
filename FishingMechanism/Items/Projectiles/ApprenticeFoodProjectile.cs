using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace EastsFishing.FishingMechanism.Items.Projectiles
{
    public class ApprenticeFoodProjectile : ModProjectile
    {
		protected int SpawnerTimer = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Apprentice Food");
        } 
        public override void SetDefaults()
        {
			projectile.timeLeft = 1800;
            projectile.width = 8;
            projectile.height = 8;
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
    public override void AI()
    {
		Player player = Main.player[projectile.owner];
		bool Ocean = ((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).ZoneOcean;
		if (projectile.wet)
		{
			projectile.active = true;
		}
        if (Main.rand.Next(10) == 0)
        {
          int index = Dust.NewDust(projectile.Center, 8, 8, 87, 0.0f, 0.0f, 0, new Color(), 1f);
          Main.dust[index].position = projectile.Center;
          Main.dust[index].velocity *= 0.2f;
          Main.dust[index].noGravity = true;
          Main.dust[index].scale = 1f;
        }
		SpawnerTimer++;
		
		if (SpawnerTimer == 360)
		{
			SpawnerTimer = 0;
		    int choice = Main.rand.Next(15);
            if (choice == 0)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier1Fish"));  
            }
            if (choice == 1)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier1Fish"));  
            }
            if (choice == 2)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier1Fish"));  
            }
			if (choice == 3)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier1Fish"));  
            }
			if (choice == 4)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier1Fish"));  
            }
			if (choice == 5)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier1Fish"));  
            }
			if (choice == 6)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier1Fish"));  
            }
			if (choice == 7)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier1Fish"));  
            }
			if (choice == 8)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier1Fish"));  
            }
			if (choice == 9)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier2Fish"));  
            }
			if (choice == 10)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier2Fish"));  
            }
			if (choice == 11)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier2Fish"));  
            }
			if (choice == 12)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier2Fish"));  
            }
			if (choice == 13)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier3Fish"));  
            }
			if (choice == 14)
            {
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier3Fish"));  
            }
		}
		if (Main.rand.Next(9000000) == 0 && Ocean)
		{
		    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-50, 50)), (int)(player.position.Y - Main.rand.Next(50, 50)), (mod.NPCType("Swordfish")));
		}
		if (Main.rand.Next(9000000) == 0 && Ocean)
		{
		    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-50, 50)), (int)(player.position.Y - Main.rand.Next(50, 50)), (mod.NPCType("SawtoothShark")));
		}
	}
}
}