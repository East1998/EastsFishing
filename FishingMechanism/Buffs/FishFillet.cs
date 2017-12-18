using System.Collections.Generic;
using Terraria;
using System.Collections.Generic;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace EastsFishing.FishingMechanism.Buffs
{
    public class FishFillet : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
			DisplayName.SetDefault("Fish Fillet");
			Description.SetDefault("You should feel lucky that you aren't poisoned");
        }
        public override void Update(Player player, ref int buffIndex)
        {
			player.statDefense += 2;
			player.magicCrit += 2;
			player.thrownCrit += 2;
			player.rangedCrit += 2;
			player.meleeCrit += 2;
			player.meleeSpeed += 0.05f;
			((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).fishingDamage += 0.05f;	
			player.magicDamage += 0.05f;
			player.rangedDamage += 0.05f;
			player.meleeDamage += 0.05f;
			player.thrownDamage += 0.05f;
			player.minionDamage += 0.05f;
			player.minionKB += 0.5f;
			player.moveSpeed += 0.2f;
        }
    }
}