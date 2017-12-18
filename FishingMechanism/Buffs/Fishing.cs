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
    public class Fishing : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true;
			DisplayName.SetDefault("Fishing");
			Description.SetDefault("You can now fish using weapons");
        }
        public override void Update(Player player, ref int buffIndex)
        {
        }
    }
}