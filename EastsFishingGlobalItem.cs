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
	public class EastsFishingGlobalItem : GlobalItem
    {
		public override bool CanUseItem (Item item, Player player)
		{
			if (Main.LocalPlayer.FindBuffIndex(mod.BuffType("Warped")) > -1)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		public override bool CanEquipAccessory (Item item, Player player, int slot)
		{
			if (Main.LocalPlayer.FindBuffIndex(mod.BuffType("Warped")) > -1)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}