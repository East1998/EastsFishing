using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism
{
    public class FishDropTable : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
			for (int i = 0; i < 1; ++i)
			{
		        Player player = Main.player[i];
				int tileX = (int)(player .Center.X / 16f);
		        int tileY = (int)(player .Center.Y / 16f);
		        bool inSky = (double)tileY < Main.worldSurface * (Main.hardMode? 0.44999998807907104 : 0.34999999403953552);
				bool UnderworldUndergroundCavern = tileY > Main.worldSurface;
				bool DeepUnderground = tileY > Main.maxTilesY - 450;
				bool GoldenCarp = (double) tileY > Main.worldSurface;
				bool Ocean = ((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).ZoneOcean;
				bool Hell = ((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).ZoneHell;
				bool Granite = ((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).ZoneGranite;
				bool Marble = ((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).ZoneMarble;
				bool Forest = ((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).ZoneForest;
				bool SkySurface = (double) tileY <= Main.worldSurface;
				int anglerQuestItemNetId = Main.anglerQuestItemNetIDs[Main.anglerQuest];
				
				    //if (npc.type == mod.NPCType("Tier1Fish") || npc.type == mod.NPCType("Tier2Fish") || npc.type == mod.NPCType("Tier3Fish"))
                    //{
						//Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, anglerQuestItemNetId); // works for the quest compability
                    //}
				if (npc.type == mod.NPCType("SawtoothShark"))
				{
					if (Main.rand.Next(1) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2342); // SawtoothShark
					}
				}
				if (npc.type == mod.NPCType("Hellfish"))
				{
					if (Hell)
					{
						if (Main.rand.Next(5) == 0)
					    {
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CookedFishSteak")); // FishFillet
					    }
						if (Main.rand.Next(10) == 0)
					    {
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SilverFishermenToken"), Main.rand.Next(1, 3)); // Token
					    }
						if (Main.rand.Next(15) == 0)
					    {
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GoldenFishermenToken"), Main.rand.Next(1, 3)); // Token
					    }
					    if (Main.rand.Next(20) == 0)
					    {
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PlatinumFishermenToken"), Main.rand.Next(1, 3)); // Token
					    }
						int choice = Main.rand.Next(2);
			            {                   
                            if (choice == 0 && (Main.rand.Next(2) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2315); // obsidifish
                            }
						    if (choice == 1 && (Main.rand.Next(4) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2312); // flarefin    
                            }
			            }
					}
				}
				if (npc.type == mod.NPCType("Swordfish"))
				{
					if (Main.rand.Next(1) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2332); // Swordfish
					}
				}
				if (npc.type == mod.NPCType("Tier1Fish"))
				{
					if (Main.rand.Next(5) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FishFillet")); // FishFillet
					}
				}
				if (npc.type == mod.NPCType("Tier1Fish"))
				{
					if (Main.rand.Next(10) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CopperFishermenToken"), Main.rand.Next(1, 3)); // Token
					}
				}
				if (npc.type == mod.NPCType("Tier2Fish"))
				{
					if (Main.rand.Next(10) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SilverFishermenToken"), Main.rand.Next(1, 3)); // Token
					}
				}
				if (npc.type == mod.NPCType("Tier2Fish"))
				{
					if (Main.rand.Next(15) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GoldenFishermenToken"), Main.rand.Next(1, 3)); // Token
					}
				}
				if (npc.type == mod.NPCType("Tier3Fish"))
				{
					if (Main.rand.Next(10) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PlatinumFishermenToken"), Main.rand.Next(1, 3)); // Token
					}
				}
				if (npc.type == mod.NPCType("Tier2Fish"))
				{
					if (Main.rand.Next(5) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FishFillet"), Main.rand.Next(1, 2)); // FishFillet
					}
				}
				if (npc.type == mod.NPCType("Tier3Fish"))
				{
					if (Main.rand.Next(5) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FishFillet"), Main.rand.Next(2, 3)); // FishFillet
					}
				}
				if (npc.type == mod.NPCType("Tier2Fish") || npc.type == mod.NPCType("Tier3Fish"))
				{
				    if (Granite)
				    {                
                        if (Main.rand.Next(5) == 0)
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GraniteCod")); // hemopiranha
                        }
				    }
					else if (Marble)
				    {                
                        if (Main.rand.Next(5) == 0)
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HopliteEel")); // hemopiranha
                        }
				    }
				}
				if (npc.type == mod.NPCType("Tier3Fish"))
				{
					if (player.ZoneSnow)
					{                
                        if (Main.rand.Next(10) == 0)
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ColdTuna")); // hemopiranha
                        }
					}
					if (player.ZoneDesert)
					{                
                        if (Main.rand.Next(8) == 0)
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DesertPredator")); // hemopiranha
                        }
					}
					if (UnderworldUndergroundCavern)
					{
						if (Main.rand.Next(25) == 0 && player.ZoneHoly)
						{
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2317); // chaos fish
						}
						if (Main.rand.Next(50) == 0)
						{
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2308); // golden carp
						}
						if (Main.rand.Next(10) == 0 && player.ZoneSnow)
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FrozenHake")); // hemopiranha
                        }
					}
					else if (player.ZoneSkyHeight)
					{
						if (Main.rand.Next(10) == 0)
						{
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WisehookManafish")); // chaos fish
						}
					}
					else if (Forest)
					{
						if (Main.rand.Next(10) == 0)
						{
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Heartfish")); // chaos fish
						}
					}
                    else if (DeepUnderground)
					{
						if (Main.rand.Next(10) == 0)
						{
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MoltenFish")); // chaos fish
						}
					}
                    else if (player.ZoneJungle)
					{
						if (Main.rand.Next(10) == 0)
						{
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("JungleSpitterfish")); // chaos fish
						}
					}					
					else if (player.ZoneHoly)
					{
						int choice = Main.rand.Next(3);
			            {                   
                            if (choice == 0 && (Main.rand.Next(12) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2310); // prismite
                            }
						    if (choice == 1 && (Main.rand.Next(4) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2307); // princess fish   
                            }
							if (choice == 2 && (Main.rand.Next(10) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HolyZander")); // princess fish   
                            }
			            }
					}
					else if (Ocean)
					{
			            if (Main.rand.Next(10) == 0)
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Stingray")); // damselfish    
                        }
					}
				}
				if (npc.type == mod.NPCType("Tier2Fish"))
				{
					if (player.ZoneSnow)
					{
						int choice = Main.rand.Next(3);
			            {                   
                            if (choice == 0 && (Main.rand.Next(4) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2306); // frost minnow
                            }
							if (choice == 1 && (Main.rand.Next(5) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SnowPuffy")); // frost minnow
                            }
						    if (choice == 2	&& (Main.rand.Next(4) == 0) && Main.raining)
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BlizzardSwimmer")); // crimson tigerfish    
                            }
			            }
					}
				    else if (player.ZoneCrimson)
					{
						int choice = Main.rand.Next(2);
			            {                   
                            if (choice == 0 && (Main.rand.Next(4) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2319); // hemopiranha
                            }
						    if (choice == 1 && (Main.rand.Next(3) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2305); // crimson tigerfish    
                            }
			            }
					}
					else if (DeepUnderground)
					{
						int choice = Main.rand.Next(2);
			            {                   
                            if (choice == 0 && (Main.rand.Next(5) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Hotfish")); // prismite
                            }
							if (choice == 1 && (Main.rand.Next(5) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Knifish")); // princess fish   
                            }
			            }
					}
					else if (player.ZoneJungle)
					{
						int choice = Main.rand.Next(3);
			            {                   
                            if (choice == 0 && (Main.rand.Next(4) == 0) && SkySurface)
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2313); // double cod
                            }
						    if (choice == 1 && (Main.rand.Next(4) == 0) && UnderworldUndergroundCavern)
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2311); // variegated lardfish    
                            }
							if (choice == 2 && (Main.rand.Next(5) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("JunglePiranha")); // variegated lardfish    
                            }
			            }
					}
					else if (player.ZoneHoly)
					{
						if (Main.rand.Next(5) == 0)
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Lightfish")); // damselfish    
                        }
					}
					if (player.ZoneDesert)
					{
						int choice = Main.rand.Next(2);
			            {                   
                            if (choice == 0 && (Main.rand.Next(4) == 0) && Main.dayTime)
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SunFish")); // double cod
                            }
						    if (choice == 1 && (Main.rand.Next(4) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SandShrimp")); // variegated lardfish    
                            }
			            }
					}
					if (UnderworldUndergroundCavern)
					{
						int choice = Main.rand.Next(5);
			            {                   
                            if (choice == 0 && (Main.rand.Next(4) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2303); // armored cavefish
                            }
						    if (choice == 1 && (Main.rand.Next(2) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2309); // specular fish    
                            }
							if (choice == 2	&& (Main.rand.Next(5) == 0) && player.ZoneSnow)
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FrostScalefish")); // crimson tigerfish    
                            }
							if (choice == 3	&& (Main.rand.Next(5) == 0) && player.ZoneSnow)
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ColdWatersAngler")); // crimson tigerfish    
                            }
							if (choice == 4	&& (Main.rand.Next(4) == 0) && player.gravDir == -1f)
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GravityCavefish")); // crimson tigerfish    
                            }
			            }
					}
					else if (Forest)
					{
						int choice = Main.rand.Next(3);
			            {                   
                            if (choice == 0 && (Main.rand.Next(5) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ESFish")); // armored cavefish
                            }
						    if (choice == 1 && (Main.rand.Next(5) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MossyKoi")); // specular fish    
                            }
							if (choice == 2 && (Main.rand.Next(5) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SwiftMinnow")); // specular fish    
                            }
			            }
					}
					else if (player.ZoneSkyHeight)
					{
						int choice = Main.rand.Next(3);
			            {                   
                            if (choice == 0 && (Main.rand.Next(4) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2304); // damselfish    
                            }
						    if (choice == 1 && (Main.rand.Next(5) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Skyray")); // specular fish    
                            }
							if (choice == 2 && (Main.rand.Next(5) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WingedSkyfish")); // specular fish    
                            }
			            }
					}
					else if (Ocean)
					{
			            if (Main.rand.Next(5) == 0)
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PalmFish")); // damselfish    
                        }
					}
					else if (player.ZoneCorrupt)
					{
						if (Main.rand.Next(12) == 0)
						{
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2318); // ebonkoi
						}
					}
					else if (!player.ZoneCorrupt && !player.ZoneHoly)
					{
						if (Main.rand.Next(15) == 0 && UnderworldUndergroundCavern)
						{
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2321); // stinkfish
						}
					}
				}	
				if (npc.type == mod.NPCType("Tier1Fish"))
				{
					if (Ocean)
					{
						int choice = Main.rand.Next(4);
			            {                   
                            if (choice == 0 && (Main.rand.Next(4) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2301); // red snapper
                            }
						    if (choice == 1 && (Main.rand.Next(3) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2316); // shrimp    
                            }
							if (choice == 2 && (Main.rand.Next(1) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2297); // trout    
                            }
							if (choice == 3 && (Main.rand.Next(2) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2300); // tuna    
                            }
			            }
					}
					else if (Forest)
					{
						int choice = Main.rand.Next(2);
			            {                   
                            if (choice == 0 && (Main.rand.Next(1) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2298); // salmon
                            }
						    if (choice == 1 && (Main.rand.Next(1) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2290); // bass    
                            }
			         	}
					}
					else if (player.ZoneSnow)
					{
						int choice = Main.rand.Next(2);
			            {                   
                            if (choice == 0 && (Main.rand.Next(2) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2299); // atlantic cod
                            }
						    if (choice == 1 && (Main.rand.Next(1) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2290); // bass    
                            }
			         	}
					}
					else if (player.ZoneJungle)
					{
						int choice = Main.rand.Next(2);
			            {                   
                            if (choice == 0 && (Main.rand.Next(2) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2302); // neon tetra
                            }
						    if (choice == 1 && (Main.rand.Next(1) == 0))
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2290); // bass    
                            }
			            }
					}
					else if (!Ocean && !player.ZoneJungle && !player.ZoneSnow && Forest)
					{
						if (Main.rand.Next(1) == 0 && UnderworldUndergroundCavern)
						{
						    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 2290); // bass
						}
					}
				}
			}
        }                       
    }
}  