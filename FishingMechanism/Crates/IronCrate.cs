using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism.Crates
{
    public class IronCrate : ModNPC
    {
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Crate");
		}
        public override void SetDefaults()
        {
            npc.width = 20;
            npc.height = 20;
            npc.aiStyle = 0;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 1;
            npc.DeathSound = SoundID.NPCHit4;
            npc.catchItem = (short)2335;
            npc.npcSlots = 0.1f;
        }
		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/IronCrateGore1"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/IronCrateGore2"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/IronCrateGore2"), 1f);
            }
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.WaterCritter.Chance * 200;
		}
		public override void AI()
		{
		    npc.velocity.X = 0f;
		}
    }
}