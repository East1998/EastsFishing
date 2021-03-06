using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism.Crates
{
    public class WoodenCrate : ModNPC
    {
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Crate");
		}
        public override void SetDefaults()
        {
            npc.width = 20;
            npc.height = 20;
            npc.aiStyle = 0;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 1;
            npc.DeathSound = SoundID.NPCHit15;
            npc.catchItem = (short)2334;
            npc.npcSlots = 0.1f;
        }
		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/WoodenCrateGore1"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/WoodenCrateGore2"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/WoodenCrateGore3"), 1f);
            }
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.WaterCritter.Chance * 400;
		}
		public override void AI()
		{
		    npc.velocity.X = 0f;
			if (npc.wet)
            {
                if (npc.collideY)
                    npc.velocity.Y = -2f;
                if ((double) npc.velocity.Y < 0.0 && (double) npc.ai[3] == (double) npc.position.X)
                {
                    npc.direction *= -1;
                    npc.ai[2] = 200f;
                }
                if ((double) npc.velocity.Y > 0.0)
                    npc.ai[3] = npc.position.X;
                {
                    if ((double) npc.velocity.Y > 2.0)
                        npc.velocity.Y *= 0.9f;
                        npc.velocity.Y -= 0.5f;
                    if ((double) npc.velocity.Y < -4.0)
                        npc.velocity.Y = -4f;
                }
                if ((double) npc.ai[2] == 1.0)
                    npc.TargetClosest(true);
            }
		}
    }
}