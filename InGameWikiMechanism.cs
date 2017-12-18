using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using System.Linq;
using System.Text;

namespace EastsFishing
{
    public class InGameWikiMechanism : ModProjectile
    {
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("East's Fishingphia Informator");
        } 
        public override void SetDefaults()
        {
            projectile.width = 50;  //Set the hitbox width
            projectile.height = 50;  //Set the hitbox height
            projectile.aiStyle = 1; //How the projectile works
            projectile.tileCollide = false; //Tells the game whether it is hostile to players or not
            aiType = ProjectileID.Bullet;
			projectile.timeLeft = 1;
            projectile.scale = 0f;			
        }
		public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
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
			if (Main.LocalPlayer.FindBuffIndex(mod.BuffType("Educating")) > -1)
			{
				projectile.active = true;
			}
			else
			{
				projectile.active = false;
			}
            Player player = Main.player[projectile.owner];
			
			if (player == Main.player[Main.myPlayer])
            {
                for (int index2 = 0; index2 < 200; ++index2)
				{
                    NPC npc = Main.npc[index2];
                    if ((double) Vector2.Distance(projectile.Center, npc.Center) <= (double) 13f)
                    {
						if (npc.type == mod.NPCType("Tier1Fish"))
			            {
				            Main.NewText("Fish (Tier 1)", 255, 255, 0);
				            Main.NewText("Can be killed with fishing weapons,found everywhere,can be spawned on-screen with fishing weapons and food bottles", 255, 255, 255);				       
				            Main.NewText("Drop Table", 255, 255, 0);
							Main.NewText("Drops can be changed depending on player position", 255, 255, 255);
				            Main.NewText(string.Format("[i:{0}][i:{1}][i:{2}][i:{3}][i:{4}][i:{5}][i:{6}][i:{7}][i:{8}]", mod.ItemType<FishingMechanism.Items.FishFillet>(), mod.ItemType<FishingMechanism.Items.CopperFishermenToken>(), 2299, 2290, 2302, 2301, 2298, 2316, 2297, 2300), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("Tier2Fish"))
			            {
				            Main.NewText("Fish (Tier 2)", 255, 255, 0);
				            Main.NewText("Can be killed with fishing weapons,found everywhere,can be spawned on-screen with fishing weapons and food bottles", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
                            Main.NewText("Drops can be changed depending on player position", 255, 255, 255);							
							Main.NewText(string.Format("[i:{0}][i:{1}][i:{2}][i:{3}][i:{4}][i:{5}][i:{6}][i:{7}][i:{8}][i:{9}][i:{10}][i:{11}][i:{12}][i:{13}][i:{14}][i:{15}][i:{16}][i:{17}][i:{18}][i:{19}][i:{20}][i:{21}][i:{22}][i:{23}][i:{24}][i:{25}][i:{26}][i:{27}][i:{28}][i:{29}][i:{30}][i:{31}]", mod.ItemType<FishingMechanism.Items.FishFillet>(), mod.ItemType<FishingMechanism.Items.SilverFishermenToken>(), mod.ItemType<FishingMechanism.Items.GoldenFishermenToken>(), mod.ItemType<Items.Fishing.SnowPuffy>(), mod.ItemType<Items.Fishing.BlizzardSwimmer>(), 2306, 2319, 2305, mod.ItemType<Items.Fishing.Hotfish>(), mod.ItemType<Items.Fishing.Knifish>(), 2313, 2311, mod.ItemType<Items.Fishing.JunglePiranha>(), mod.ItemType<Items.Fishing.Lightfish>(), mod.ItemType<Items.Fishing.Sunfish>(), mod.ItemType<Items.Fishing.SandShrimp>(), 2303, 2309, mod.ItemType<Items.Fishing.FrostScalefish>(), mod.ItemType<Items.Fishing.ColdWatersAngler>(), mod.ItemType<Items.Fishing.GravityCavefish>(), mod.ItemType<Items.Fishing.ESFish>(), mod.ItemType<Items.Fishing.MossyKoi>(), mod.ItemType<Items.Fishing.SwiftMinnow>(), 2304, mod.ItemType<Items.Fishing.Skyray>(), mod.ItemType<Items.Fishing.WingedSkyfish>(), mod.ItemType<Items.Fishing.PalmFish>(), 2318, 2321, mod.ItemType<Items.Fishing.GraniteCod>(), mod.ItemType<Items.Fishing.HopliteEel>()), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("Tier3Fish"))
			            {
				            Main.NewText("Fish (Tier 3)", 255, 255, 0);
				            Main.NewText("Can be killed with fishing weapons,found everywhere,can be spawned on-screen with fishing weapons and food bottles", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
							Main.NewText("Drops can be changed depending on player position", 255, 255, 255);
				            Main.NewText(string.Format("[i:{0}][i:{1}][i:{2}][i:{3}][i:{4}][i:{5}][i:{6}][i:{7}][i:{8}][i:{9}][i:{10}][i:{11}][i:{12}][i:{13}][i:{14}][i:{15}][i:{16}]", mod.ItemType<FishingMechanism.Items.FishFillet>(), mod.ItemType<FishingMechanism.Items.PlatinumFishermenToken>(), mod.ItemType<Items.Fishing.ColdTuna>(), mod.ItemType<Items.Fishing.DesertPredator>(), 2317, 2308, mod.ItemType<Items.Fishing.FrozenHake>(), mod.ItemType<Items.Fishing.WisehookManafish>(), mod.ItemType<Items.Fishing.Heartfish>(), mod.ItemType<Items.Fishing.Moltenfish>(), mod.ItemType<Items.Fishing.JungleSpitterfish>(), 2310, 2307, mod.ItemType<Items.Fishing.HolyZander>(), mod.ItemType<Items.Fishing.Stingray>(), mod.ItemType<Items.Fishing.GraniteCod>(), mod.ItemType<Items.Fishing.HopliteEel>()), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("Hellfish"))
			            {
				            Main.NewText("Hellfish", 255, 255, 0);
				            Main.NewText("Can be killed with lava fishing weapons,can be spawned on-screen with lava fishing weapons and hellish food bottle", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}][i:{1}][i:{2}][i:{3}][i:{4}][i:{5}]", mod.ItemType<FishingMechanism.Items.CookedFishSteak>(), mod.ItemType<FishingMechanism.Items.SilverFishermenToken>(), mod.ItemType<FishingMechanism.Items.GoldenFishermenToken>(), mod.ItemType<FishingMechanism.Items.PlatinumFishermenToken>(), 2315, 2312), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("Swordfish"))
			            {
				            Main.NewText("Swordfish", 255, 255, 0);
				            Main.NewText("Can be killed with fishing weapons,found in the ocean rarely,can be spawned on-screen with fishing weapons and food bottles", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 2332), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("SawtoothShark"))
			            {
				            Main.NewText("Sawtooth Shark", 255, 255, 0);
				            Main.NewText("Can be killed with fishing weapons,found in the ocean rarely,can be spawned on-screen with fishing weapons and food bottles", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 2342), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("WoodenCrate"))
			            {
				            Main.NewText("Wooden Crate", 255, 255, 0);
				            Main.NewText("Can be broken with weapons making it useless,found everywhere,crate detector and bug nets can be used to catch it,can be spawned on-screen with crate detector", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 2334), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("IronCrate"))
			            {
				            Main.NewText("Iron Crate", 255, 255, 0);
				            Main.NewText("Can be broken with weapons making it useless,found everywhere,crate detector and bug nets can be used to catch it,can be spawned on-screen with crate detector", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 2335), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("GoldenCrate"))
			            {
				            Main.NewText("Golden Crate", 255, 255, 0);
				            Main.NewText("Can be broken with weapons making it useless,found everywhere,crate detector and bug nets can be used to catch it,can be spawned on-screen with crate detector", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 2336), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("JungleCrate"))
			            {
				            Main.NewText("Jungle Crate", 255, 255, 0);
				            Main.NewText("Can be broken with weapons making it useless,found in the jungle,crate detector and bug nets can be used to catch it,can be spawned on-screen with crate detector", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 3208), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("SkyCrate"))
			            {
				            Main.NewText("Sky Crate", 255, 255, 0);
				            Main.NewText("Can be broken with weapons making it useless,found in the sky,crate detector and bug nets can be used to catch it,can be spawned on-screen with crate detector", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 3206), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("CorruptCrate"))
			            {
				            Main.NewText("Corrupt Crate", 255, 255, 0);
				            Main.NewText("Can be broken with weapons making it useless,found in the corruption,crate detector and bug nets can be used to catch it,can be spawned on-screen with crate detector", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 3203), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("CrimsonCrate"))
			            {
				            Main.NewText("Crimson Crate", 255, 255, 0);
				            Main.NewText("Can be broken with weapons making it useless,found in the crimson,crate detector and bug nets can be used to catch it,can be spawned on-screen with crate detector", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 3204), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("HallowedCrate"))
			            {
				            Main.NewText("Hallowed Crate", 255, 255, 0);
				            Main.NewText("Can be broken with weapons making it useless,found in the hallowed,crate detector and bug nets can be used to catch it,can be spawned on-screen with crate detector", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 3207), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("DungeonCrate"))
			            {
				            Main.NewText("Dungeon Crate", 255, 255, 0);
				            Main.NewText("Can be broken with weapons making it useless,found in the dungeon,crate detector and bug nets can be used to catch it,can be spawned on-screen with crate detector", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 3205), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("OldShoe"))
			            {
				            Main.NewText("Old Shoe", 255, 255, 0);
				            Main.NewText("Cannot be broken with weapons,found everywhere,crate detector and bug nets can be used to catch it,can be spawned on-screen with crate detector", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 2337), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("Seaweed"))
			            {
				            Main.NewText("Seaweed", 255, 255, 0);
				            Main.NewText("Cannot be broken with weapons,found everywhere,crate detector and bug nets can be used to catch it,can be spawned on-screen with crate detector", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 2338), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("TinCan"))
			            {
				            Main.NewText("Tin Can", 255, 255, 0);
				            Main.NewText("Cannot be broken with weapons,found everywhere,crate detector and bug nets can be used to catch it,can be spawned on-screen with crate detector", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 2339), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("DashingSlime"))
			            {
				            Main.NewText("Potent Red Slime", 255, 255, 0);
				            Main.NewText("Can be found in forest rarely after defeating King Slime,can dash and has an unpredictable AI", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 23), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("BombSlime"))
			            {
				            Main.NewText("Potent Black Slime", 255, 255, 0);
				            Main.NewText("Can be found in forest rarely after defeating King Slime,explodes after death dealing massive damage", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 23), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("ExpandingSlime"))
			            {
				            Main.NewText("Potent Green Slime", 255, 255, 0);
				            Main.NewText("Can be found in forest rarely after defeating King Slime,duplicates itself after dying,duplicates won't drop loot", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 23), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("ExpandingSlimeAlt"))
			            {
				            Main.NewText("Potent Green Slime Duplicate", 255, 255, 0);
				            Main.NewText("Can be found after killing a Expanding Slime,duplicates itself after dying,duplicates won't drop loot", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("ExpandingSlimeAltAlt"))
			            {
				            Main.NewText("Potent Green Slime Shadow", 255, 255, 0);
				            Main.NewText("Can be spawned after killing a Expanding Slime Duplicate", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("WarpSlime"))
			            {
				            Main.NewText("Potent Purple Slime", 255, 255, 0);
				            Main.NewText("Can be found in forest rarely after defeating King Slime,spawns a warp portal after dying that teleports you randomly", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 23), 0, 0, 0);
							projectile.Kill();
						}
						if (npc.type == mod.NPCType("PotentBlueSlime"))
			            {
				            Main.NewText("Potent Blue Slime", 255, 255, 0);
				            Main.NewText("Can be found in forest rarely after defeating King Slime,grows bigger and stronger after each succesful hit", 255, 255, 255);
				            Main.NewText("Drop Table", 255, 255, 0);
				            Main.NewText(string.Format("[i:{0}]", 23), 0, 0, 0);
							projectile.Kill();
						}
                    }
                }
            }
		}
    }
}