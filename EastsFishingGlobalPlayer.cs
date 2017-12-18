using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace EastsFishing
{
	public class EastsFishingGlobalPlayer : ModPlayer
    {
		public float fishingDamage = 1f;
		private const int saveVersion = 0;
        public static bool hasProjectile;
		public static int WisehookManaFishMana = 0;
		public const int WisehookManaFishManaMax = 10;
		public bool holyPotion = false;
		public bool fisherPerfume = false;
		public bool radioactiveGoo = false;
		public bool ZoneGranite = false;
		public bool ZoneMarble = false;		
		public bool ZoneForest = false;		
		public bool ZoneOcean = false;		
		public bool ZoneHive = false;		
		public bool ZoneHell = false;	
		public override void ResetEffects()
        {
			holyPotion = false;
			fisherPerfume = false;
			radioactiveGoo = false;
			fishingDamage = 1f;
        }
		public override void PreUpdate()
		{
			holyPotion = false;
			fisherPerfume = false;
			radioactiveGoo = false;
			fishingDamage = 1f;
			if (player.statManaMax >= 200)
			{
				player.statManaMax = ((WisehookManaFishMana * 10) + 200);
			}
		}
		public override void PostUpdate()
	    {
			
		}
		public override void UpdateBiomes()
		{
			int tileX = (int)(player .Center.X / 16f);
			int tileY = (int)(player .Center.Y / 16f);
			bool inSky = (double)tileY < Main.worldSurface * (Main.hardMode? 0.44999998807907104 : 0.34999999403953552);
			ZoneGranite = (EastsFishingWorld.graniteTiles > 80);
			ZoneMarble = (EastsFishingWorld.marbleTiles > 80);			
			ZoneForest = (EastsFishingWorld.grassTiles > 80);			
			ZoneHive = (EastsFishingWorld.hiveTiles > 20);			
			ZoneOcean = ((tileX < 250 || tileX > Main.maxTilesX - 250) && tileY < Main.worldSurface  && !inSky);
			ZoneHell = (player.position.Y / 16f > Main.maxTilesY - 200);
		}
		public override bool CustomBiomesMatch(Player other)
		{
			EastsFishingGlobalPlayer modOther = other.GetModPlayer<EastsFishingGlobalPlayer>(mod);
			return ZoneMarble == modOther.ZoneMarble;
			return ZoneForest == modOther.ZoneForest;
			return ZoneGranite == modOther.ZoneGranite;
			return ZoneOcean == modOther.ZoneOcean;
			return ZoneHive == modOther.ZoneHive;
			return ZoneHell == modOther.ZoneHell;
		}

		public override void CopyCustomBiomesTo(Player other)
		{
			EastsFishingGlobalPlayer modOther = other.GetModPlayer<EastsFishingGlobalPlayer>(mod);
			modOther.ZoneMarble = ZoneMarble;
			modOther.ZoneForest = ZoneForest;
			modOther.ZoneGranite = ZoneGranite;
			modOther.ZoneOcean = ZoneOcean;
			modOther.ZoneHive = ZoneHive;
			modOther.ZoneHell = ZoneHell;
		}

		public override void SendCustomBiomes(BinaryWriter writer)
		{
			BitsByte flags = new BitsByte();
			flags[0] = ZoneMarble;
			flags[1] = ZoneGranite;			
			flags[2] = ZoneForest;			
			flags[3] = ZoneOcean;			
			flags[4] = ZoneHive;			
			flags[5] = ZoneHell;			
			writer.Write(flags);
		}

		public override void ReceiveCustomBiomes(BinaryReader reader)
		{
			BitsByte flags = reader.ReadByte();
			ZoneMarble = flags[0];
			ZoneGranite = flags[1];			
			ZoneForest = flags[2];			
			ZoneOcean = flags[3];			
			ZoneHive = flags[4];			
			ZoneHell = flags[5];			
		}
		public override void SetupStartInventory(IList<Item> items)
		{
			Item item = new Item();
			item.SetDefaults(mod.ItemType("Proximephia"));
			item.stack = 1;
			items.Add(item);
		}
		public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
        {
			int tileX = (int)(player .Center.X / 16f);
			int tileY = (int)(player .Center.Y / 16f);
			bool inSky = (double)tileY < Main.worldSurface * (Main.hardMode? 0.44999998807907104 : 0.34999999403953552);
            if (!(tileX < 250 || tileX > Main.maxTilesX - 250) && !player.ZoneCorrupt && !inSky  && !player.ZoneCrimson && !player.ZoneHoly && !player.ZoneJungle && !player.ZoneSnow && !player.ZoneDesert && !player.ZoneGlowshroom && liquidType == 0 && tileY < Main.worldSurface  && Main.rand.Next(10) == 0)  	
            {
                caughtType = mod.ItemType("SwiftMinnow");
            }	
            if (!(tileX < 250 || tileX > Main.maxTilesX - 250) && !player.ZoneCorrupt && !inSky  && !player.ZoneCrimson && !player.ZoneHoly && !player.ZoneJungle && !player.ZoneSnow && !player.ZoneDesert && !player.ZoneGlowshroom && liquidType == 0 && tileY < Main.worldSurface  && Main.rand.Next(10) == 0)  	
            {
                caughtType = mod.ItemType("ESFish");
            }	
            if (!(tileX < 250 || tileX > Main.maxTilesX - 250) && !player.ZoneCorrupt && !inSky  && !player.ZoneCrimson && !player.ZoneHoly && !player.ZoneJungle && !player.ZoneSnow && !player.ZoneDesert && !player.ZoneGlowshroom && liquidType == 0 && tileY < Main.worldSurface  && Main.rand.Next(20) == 0)  	
            {
                caughtType = mod.ItemType("Heartfish");
            }	
            if (!(tileX < 250 || tileX > Main.maxTilesX - 250) && !player.ZoneCorrupt && !inSky  && !player.ZoneCrimson && !player.ZoneHoly && !player.ZoneJungle && !player.ZoneSnow && !player.ZoneDesert && !player.ZoneGlowshroom && liquidType == 0 && tileY < Main.worldSurface  && Main.rand.Next(10) == 0)  	
            {
                caughtType = mod.ItemType("MossyKoi");
            }	
			if ((tileX < 250 || tileX > Main.maxTilesX - 250) && tileY < Main.worldSurface  && !inSky  && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("PalmFish");
            }			
			if ((tileX < 250 || tileX > Main.maxTilesX - 250) && tileY < Main.worldSurface  && !inSky  && Main.rand.Next(20) == 0)
			{
                caughtType = mod.ItemType("Stingray");
            }	
			if (player.ZoneSnow  && tileY < Main.worldSurface && !inSky && Main.raining && Main.rand.Next(8) == 0)
			{
                caughtType = mod.ItemType("BlizzardSwimmer");
            }	
			if (player.ZoneSnow  && tileY < Main.worldSurface && !inSky && liquidType == 0 && Main.rand.Next(20) == 0)
			{
                caughtType = mod.ItemType("ColdTuna");
            }		
			if (player.ZoneSnow  && tileY < Main.worldSurface && !inSky && liquidType == 0 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("SnowPuffy");
            }	
			if (player.ZoneSnow  && tileY > Main.worldSurface && !inSky && liquidType == 0 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("FrostScalefish");
            }	
			if (player.ZoneSnow  && tileY > Main.worldSurface && !inSky && liquidType == 0 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("ColdWatersAngler");
            }	
			if (player.ZoneSnow  && tileY > Main.worldSurface && !inSky && liquidType == 0 && Main.rand.Next(20) == 0)
			{
                caughtType = mod.ItemType("FrozenHake");
            }			
			if (!(tileX < 250 || tileX > Main.maxTilesX - 250) && player.ZoneDesert  && tileY < Main.worldSurface && !inSky && liquidType == 0 && Main.rand.Next(20) == 0)
			{
                caughtType = mod.ItemType("DesertPredator");
            }	
			if (!(tileX < 250 || tileX > Main.maxTilesX - 250) && player.ZoneDesert  && tileY < Main.worldSurface && !inSky && liquidType == 0 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("SandShrimp");
            }	
			if (!(tileX < 250 || tileX > Main.maxTilesX - 250) && Main.time < 54000.0 && player.ZoneDesert  && tileY < Main.worldSurface && !inSky && liquidType == 0 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("Sunfish");
            }	
			if (this.ZoneGranite && liquidType == 0 && Main.rand.Next(10) == 0)
			{
				caughtType = mod.ItemType("GraniteCod");
            }
			if (this.ZoneMarble && liquidType == 0 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("HopliteEel");
            }
			if (player.ZoneHoly  && tileY < Main.worldSurface && !inSky && liquidType == 0 && Main.rand.Next(20) == 0)
			{
                caughtType = mod.ItemType("HolyZander");
            }	
			if (player.ZoneHoly  && tileY < Main.worldSurface && !inSky && liquidType == 0 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("Lightfish");
            }				
			if (liquidType == 2 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("HoneyCod");
            }	
			if (tileY > Main.maxTilesY - 450 && liquidType == 0 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("Hotfish");
            }				
			if (tileY > Main.maxTilesY - 450 && liquidType == 0 && Main.rand.Next(20) == 0)
			{
                caughtType = mod.ItemType("Moltenfish");
            }	
			if (tileY > Main.maxTilesY - 450 && liquidType == 0 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("Sirfish");
            }	
            if (!(tileX < 250 || tileX > Main.maxTilesX - 250) && !player.ZoneCorrupt && !inSky  && !player.ZoneCrimson && !player.ZoneHoly && !player.ZoneJungle && !player.ZoneSnow && !player.ZoneDesert && !player.ZoneGlowshroom && liquidType == 0 && tileY > Main.rockLayer  && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("Knifish");
            }				
			if (player.gravDir == -1f && !(tileX < 250 || tileX > Main.maxTilesX - 250) && !player.ZoneCorrupt && !inSky  && !player.ZoneCrimson && !player.ZoneHoly && !player.ZoneJungle && !player.ZoneSnow && !player.ZoneDesert && !player.ZoneGlowshroom && liquidType == 0 && tileY > Main.rockLayer  && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("GravityCavefish");
            }	
			if (player.ZoneJungle  && tileY < Main.worldSurface && !inSky && liquidType == 0 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("JunglePiranha");
            }	
			if (player.ZoneJungle  && tileY < Main.worldSurface && !inSky && liquidType == 0 && Main.rand.Next(20) == 0)
			{
                caughtType = mod.ItemType("JungleSpitterfish");
            }	
			if (player.ZoneSkyHeight && liquidType == 0 && Main.rand.Next(20) == 0)
			{
                caughtType = mod.ItemType("WisehookManafish");
            }	
			if (player.ZoneSkyHeight && liquidType == 0 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("Skyray");
            }	
			if (player.wingTimeMax > 0 && player.ZoneSkyHeight && liquidType == 0 && Main.rand.Next(10) == 0)
			{
                caughtType = mod.ItemType("WingedSkyfish");
            }				
		}
		public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            if(this.holyPotion)
            {
                player.ClearBuff(mod.BuffType("Holy"));
                player.AddBuff(mod.BuffType("Resurrected"), 600 * 60);
                player.statLife = player.statLifeMax2;
                player.HealEffect(player.statLifeMax2);
                player.immune = true;
                player.immuneTime = player.longInvince ? 180 : 120;
                for (int k = 0; k < player.hurtCooldowns.Length; k++)
                {
                    player.hurtCooldowns[k] = player.longInvince ? 180 : 120;
                }
                Main.PlaySound(SoundID.Item29, player.position);
                return false;
            }
            return true;
        }
	}
}