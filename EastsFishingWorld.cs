using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Events;
using Terraria.GameContent.Generation;
using Terraria.GameContent.Tile_Entities;
using Terraria.Graphics.Capture;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Map;
using Terraria.ObjectData;
using Terraria.Utilities;
using Terraria.World.Generation;
using System.IO;
using Terraria;
using Terraria.ModLoader;

namespace EastsFishing
{
    public class EastsFishingWorld : ModWorld
    {
        public static bool spawnOre = false;
        private const int saveVersion = 0;
		public static int marbleTiles = 0;
		public static int graniteTiles = 0;				
		public static int hiveTiles = 0;				
		public static int grassTiles = 0;			
		public override void TileCountsAvailable(int[] tileCounts)
		{
			graniteTiles = tileCounts[368];
			marbleTiles = tileCounts[367];	
			grassTiles = tileCounts[2];
			hiveTiles = tileCounts[225];
		}
    }
}
