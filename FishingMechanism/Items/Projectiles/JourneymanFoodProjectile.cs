using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace EastsFishing.FishingMechanism.Items.Projectiles
{
    public class JourneymanFoodProjectile : ModProjectile
    {
		protected int SpawnerTimer = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Journeyman Food");
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
    public override void AI()
    {
		Player player = Main.player[projectile.owner];
		bool Ocean = ((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).ZoneOcean;
		for (int l = 0; l < Main.projectile.Length; l++)
        { 
		        Projectile projec = Main.projectile[l];
                if (projec.active && projec.type == mod.ProjectileType("ApprenticeFoodProjectile") && projec.owner == player.whoAmI)
                { 
                    projec.active = false;
                }
        }
		if (projectile.wet)
		{
			projectile.active = true;
		}
        if (Main.rand.Next(10) == 0)
        {
          int index = Dust.NewDust(projectile.Center, 8, 8, 45, 0.0f, 0.0f, 0, new Color(), 1f);
          Main.dust[index].position = projectile.Center;
          Main.dust[index].velocity *= 0.2f;
          Main.dust[index].noGravity = true;
          Main.dust[index].scale = 1.2f;
        }
		SpawnerTimer++;
		
		if (SpawnerTimer == 300)
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
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier2Fish"));  
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
                NPC.NewNPC((int)projectile.position.X - Main.rand.Next(-50, 50), (int)projectile.position.Y - Main.rand.Next(-50, 50), mod.NPCType("Tier3Fish"));  
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
		if (Main.rand.Next(8000000) == 0 && Ocean)
		{
		    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-50, 50)), (int)(player.position.Y - Main.rand.Next(50, 50)), (mod.NPCType("Swordfish")));
		}
		if (Main.rand.Next(8000000) == 0 && Ocean)
		{
		    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-50, 50)), (int)(player.position.Y - Main.rand.Next(50, 50)), (mod.NPCType("SawtoothShark")));
		}
	}
}
}