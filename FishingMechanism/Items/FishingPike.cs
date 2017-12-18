using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace EastsFishing.FishingMechanism.Items
{
	public class FishingPike : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fishing Pike");
			Tooltip.SetDefault("Allows you to damage fishes\nRight-click to throw your spear\nHolding the weapon increases fish spawns on-screen slightly\nFishes requires at least 30*30 pool to spawn");
        }
		public override void SetDefaults()
		{
			item.consumable = false;
				item.crit = 0;
				item.maxStack = 999;
            item.damage = 6;
			item.useStyle = 5;
			item.useAnimation = 35;
			item.useTime = 35;
			item.shootSpeed = 2f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType("FishingPikeSpearProjectile");
			item.noMelee = true; // Important because the spear is acutally a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = false; // Most spears dont autoReuse, but it's possible
		}
		
        public override void HoldItem (Player player)	
		{
			player.AddBuff(mod.BuffType("Fishing"), 2);
			bool Ocean = ((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).ZoneOcean;
			bool FisherPerfume = ((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).fisherPerfume;
			if (FisherPerfume == false)
			{
			for (int index2 = 0; index2 < 200; ++index2)
            {
                NPC npc = Main.npc[index2];
				if (Main.rand.Next(125000) == 0)
				{
				    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-100, 100)), (int)(player.position.Y + Main.rand.Next(140, 340)), (mod.NPCType("Tier1Fish")));
				}
				if (Main.rand.Next(275000) == 0)
				{
				    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-100, 100)), (int)(player.position.Y + Main.rand.Next(140, 340)), (mod.NPCType("Tier2Fish")));
				}
				if (Main.rand.Next(400000) == 0)
				{
				    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-100, 100)), (int)(player.position.Y + Main.rand.Next(140, 340)), (mod.NPCType("Tier3Fish")));
				}
				if (Main.rand.Next(4000000) == 0 && Ocean)
				{
				    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-100, 100)), (int)(player.position.Y + Main.rand.Next(140, 340)), (mod.NPCType("SawtoothShark")));
				}
				if (Main.rand.Next(4000000) == 0 && Ocean)
				{
				    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-100, 100)), (int)(player.position.Y + Main.rand.Next(140, 340)), (mod.NPCType("Swordfish")));
				}
			}
			}
			else
			for (int index2 = 0; index2 < 200; ++index2)
            {
                NPC npc = Main.npc[index2];
				if (Main.rand.Next(112500) == 0)
				{
				    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-100, 100)), (int)(player.position.Y + Main.rand.Next(140, 340)), (mod.NPCType("Tier1Fish")));
				}
				if (Main.rand.Next(247500) == 0)
				{
				    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-100, 100)), (int)(player.position.Y + Main.rand.Next(140, 340)), (mod.NPCType("Tier2Fish")));
				}
				if (Main.rand.Next(360000) == 0)
				{
				    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-100, 100)), (int)(player.position.Y + Main.rand.Next(140, 340)), (mod.NPCType("Tier3Fish")));
				}
				if (Main.rand.Next(10000000) == 0 && Ocean)
				{
				    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-100, 100)), (int)(player.position.Y + Main.rand.Next(140, 340)), (mod.NPCType("SawtoothShark")));
				}
				if (Main.rand.Next(10000000) == 0 && Ocean)
				{
				    NPC.NewNPC((int)(player.position.X - Main.rand.Next(-100, 100)), (int)(player.position.Y + Main.rand.Next(140, 340)), (mod.NPCType("Swordfish")));
				}
			}
			if (player.name == "East")
			{
				player.noKnockback = true;
				player.statDefense += 10000;
				player.moveSpeed += 0.9f;
				player.accRunSpeed = 10.75f;
			}
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.shoot = mod.ProjectileType("FishingPikeProjectile");
			item.shootSpeed = 16f;
			item.damage = 6;
			item.useStyle = 1;
			item.UseSound = SoundID.Item1;
			item.useAnimation = 35;
			item.useTime = 35;
			item.width = 26;
			item.height = 26;
			item.maxStack = 999;
			item.consumable = true;
			item.crit = 0;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.rare = 1;
			}
			else
			{
				item.consumable = false;
				item.crit = 0;
            item.damage = 6;
			item.useStyle = 5;
			item.useAnimation = 35;
			item.useTime = 35;
			item.shootSpeed = 2f;
			item.maxStack = 999;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType("FishingPikeSpearProjectile");
			item.noMelee = true; // Important because the spear is acutally a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = false; // Most spears dont autoReuse, but it's possible
			}		
			return base.CanUseItem(player);
		}
        public override void GetWeaponDamage(Player player, ref int damage)
		{
			EastsFishingGlobalPlayer modPlayer = player.GetModPlayer<EastsFishingGlobalPlayer>(mod);
			damage = (int)(damage * modPlayer.fishingDamage);
		}
		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			EastsFishingGlobalPlayer modPlayer = Main.LocalPlayer.GetModPlayer<EastsFishingGlobalPlayer>(mod);

			foreach (TooltipLine tooltip in tooltips)
			{
				if (tooltip.Name == "Damage")
				{
					tooltip.text = ((int)(item.damage * modPlayer.fishingDamage)) + " fishing damage";
				}
			}
		}
		public override void AddRecipes()
		{
		    ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.Anvils);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.anyWood = true;
			recipe.anyIronBar = true;
			recipe.SetResult(this,25);
			recipe.AddRecipe();
        }
	}
}
