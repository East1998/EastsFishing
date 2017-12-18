using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism.Items.Projectiles
{
    public class CrateDetectorProjectile : ModProjectile
    {
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crate Detector");
        } 
        public override void SetDefaults()
        {
            projectile.width = 14;  //Set the hitbox width
            projectile.height = 14;  //Set the hitbox height
            projectile.aiStyle = 1; //How the projectile works
            projectile.tileCollide = true; //Tells the game whether it is hostile to players or not
            aiType = ProjectileID.WoodenArrowFriendly;
			projectile.timeLeft = 7200;
			projectile.penetrate = 1000;
			projectile.usesLocalNPCImmunity = false;
			projectile.damage = 0;
            projectile.scale = 1f;
            Main.projFrames[projectile.type] = 8;			
        }
		public override bool OnTileCollide(Vector2 oldVelocity)
        {
			{
			    projectile.active = true;
		    }
			return false;
        }
        public override void AI()
        {
			if (projectile.wet)
			{
				projectile.active = true;
			}
			else
			{
				projectile.active = false;
			}
			projectile.frameCounter++;
			
			if (projectile.frameCounter > 4)
			{
			   projectile.frame++;
               projectile.frameCounter = 2;
			}
            if (projectile.frame > 7)
            {
               projectile.frame = 0;
            }
			
            Player player = Main.player[projectile.owner];

			Lighting.AddLight(projectile.position, 0f, 0.68f, 0f);			
			
			projectile.velocity.X = 0f;
			
            int type = 8;
            float num1 = 200f;
            int num2 = 10;
			if (player == Main.player[projectile.owner])
            {
                for (int index2 = 0; index2 < 200; ++index2)
                {
                    NPC npc = Main.npc[index2];
					if (Main.rand.Next(1250000) == 0)
				    {
				        NPC.NewNPC((int)(projectile.position.X - Main.rand.Next(-100, 100)), (int)(projectile.position.Y + Main.rand.Next(140, 200)), (mod.NPCType("Seaweed")));
				    }
					if (Main.rand.Next(1250000) == 0)
				    {
				        NPC.NewNPC((int)(projectile.position.X - Main.rand.Next(-100, 100)), (int)(projectile.position.Y + Main.rand.Next(140, 200)), (mod.NPCType("TinCan")));
				    }
					if (Main.rand.Next(1250000) == 0)
				    {
				        NPC.NewNPC((int)(projectile.position.X - Main.rand.Next(-100, 100)), (int)(projectile.position.Y + Main.rand.Next(140, 200)), (mod.NPCType("OldShoe")));
				    }
                    if (Main.rand.Next(1250000) == 0)
				    {
				        NPC.NewNPC((int)(projectile.position.X - Main.rand.Next(-100, 100)), (int)(projectile.position.Y + Main.rand.Next(140, 200)), (mod.NPCType("WoodenCrate")));
				    }
				    if (Main.rand.Next(2000000) == 0)
				    {
				        NPC.NewNPC((int)(projectile.position.X - Main.rand.Next(-100, 100)), (int)(projectile.position.Y + Main.rand.Next(140, 200)), (mod.NPCType("IronCrate")));
				    }
				    if (Main.rand.Next(3000000) == 0)
				    {
				        NPC.NewNPC((int)(projectile.position.X - Main.rand.Next(-100, 100)), (int)(projectile.position.Y + Main.rand.Next(140, 200)), (mod.NPCType("GoldenCrate")));
				    }
					if (player.ZoneJungle)
					{
						if (Main.rand.Next(3000000) == 0)
				        {
				            NPC.NewNPC((int)(projectile.position.X - Main.rand.Next(-100, 100)), (int)(projectile.position.Y + Main.rand.Next(140, 200)), (mod.NPCType("JungleCrate")));
				        }
					}
					if (player.ZoneSkyHeight)
					{
						if (Main.rand.Next(3000000) == 0)
				        {
				            NPC.NewNPC((int)(projectile.position.X - Main.rand.Next(-100, 100)), (int)(projectile.position.Y + Main.rand.Next(140, 200)), (mod.NPCType("SkyCrate")));
				        }
					}
					if (player.ZoneCorrupt)
					{
						if (Main.rand.Next(3000000) == 0)
				        {
				            NPC.NewNPC((int)(projectile.position.X - Main.rand.Next(-100, 100)), (int)(projectile.position.Y + Main.rand.Next(140, 200)), (mod.NPCType("CorruptCrate")));
				        }
					}
					if (player.ZoneCrimson)
					{
						if (Main.rand.Next(3000000) == 0)
				        {
				            NPC.NewNPC((int)(projectile.position.X - Main.rand.Next(-100, 100)), (int)(projectile.position.Y + Main.rand.Next(140, 200)), (mod.NPCType("CrimsonCrate")));
				        }
					}
					if (player.ZoneHoly)
					{
						if (Main.rand.Next(3000000) == 0)
				        {
				            NPC.NewNPC((int)(projectile.position.X - Main.rand.Next(-100, 100)), (int)(projectile.position.Y + Main.rand.Next(140, 200)), (mod.NPCType("HallowedCrate")));
				        }
					}
					if (player.ZoneDungeon)
					{
						if (Main.rand.Next(3000000) == 0)
				        {
				            NPC.NewNPC((int)(projectile.position.X - Main.rand.Next(-100, 100)), (int)(projectile.position.Y + Main.rand.Next(140, 200)), (mod.NPCType("DungeonCrate")));
				        }
					}
                }
            }
			if (projectile.timeLeft == 7199 && player == Main.player[projectile.owner])
		    {
					projectile.velocity.Y = 1;
			}
		}
    }
}