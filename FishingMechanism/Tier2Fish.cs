using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism
{
	public class Tier2Fish : ModNPC
	{
		protected float speed = 7f;
		protected float speedY = 4f;
		protected float acceleration = 0.25f;
		protected float accelerationY = 0.2f;
		protected float correction = 0.95f;
		protected bool targetDryPlayer = true;
		protected float idleSpeed = 3f;
		protected bool bounces = true;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fish");
			Main.npcFrameCount[npc.type] = 4;
		}
		public override void SetDefaults()
		{
            npc.width = 26;
            npc.height = 26;
            npc.aiStyle = 16;
            npc.damage = 0;
            npc.defense = 999;
			npc.noGravity = true;
            npc.lifeMax = 4;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
			animationType = NPCID.Goldfish;
			aiType = NPCID.Goldfish;
		}
        public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Tier2FishGore1"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Tier2FishGore2"), 1f);
            }
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			for (int i = 0; i < 1; ++i)
		    {
		        Player player = Main.player[i];
				if (((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).fisherPerfume == true)
				{
				    return SpawnCondition.WaterCritter.Chance * 440;	
				}
				else
				{
				    return SpawnCondition.WaterCritter.Chance * 400;
				}
			}
			return SpawnCondition.WaterCritter.Chance * 400;
		}
		public override void AI()
		{
		{
		{
			if (npc.direction == 0)
			{
				npc.TargetClosest(true);
			}
			if (npc.width == 20)
			{
				bool flag30 = false;
				npc.TargetClosest(false);
				if (Main.player[npc.target].wet && !Main.player[npc.target].wet && !Main.player[npc.target].dead)
				{
					flag30 = true;
				}
				if (flag30)
				{
					if (npc.collideX)
					{
						npc.velocity.X *= -1f;
						npc.direction *= -1;
						npc.netUpdate = true;
					}
					if (npc.collideY)
					{
						npc.netUpdate = true;
						if (npc.velocity.Y > 0f)
						{
							npc.velocity.Y = -npc.velocity.Y;
							npc.directionY = -1;
							npc.ai[0] = -1f;
						}
						else if (npc.velocity.Y < 0f)
						{
							npc.velocity.Y = -npc.velocity.Y;
							npc.directionY = 1;
							npc.ai[0] = 1f;
						}
					}
				}
				{
					{
						npc.velocity.X += (float)npc.direction * 0.1f * idleSpeed;
						if (npc.velocity.X < -idleSpeed || npc.velocity.X > idleSpeed)
						{
							npc.velocity.X *= 0.95f;
						}
						if (npc.ai[0] == -1f)
						{
							npc.velocity.Y -= 0.01f * idleSpeed;
							if ((double)npc.velocity.Y < -0.3)
							{
								npc.ai[0] = 1f;
							}
						}
						else
						{
							npc.velocity.Y += 0.01f * idleSpeed;
							if ((double)npc.velocity.Y > 0.3)
							{
								npc.ai[0] = -1f;
							}
						}
					}
					int num358 = (int)(npc.position.X + (float)(npc.width / 2)) / 16;
					int num359 = (int)(npc.position.Y + (float)(npc.height / 2)) / 16;
					if (Main.tile[num358, num359 - 1] == null)
					{
						Main.tile[num358, num359 - 1] = new Tile();
					}
					if (Main.tile[num358, num359 + 1] == null)
					{
						Main.tile[num358, num359 + 1] = new Tile();
					}
					if (Main.tile[num358, num359 + 2] == null)
					{
						Main.tile[num358, num359 + 2] = new Tile();
					}
					if (Main.tile[num358, num359 - 1].liquid > 128)
					{
						if (Main.tile[num358, num359 + 1].active())
						{
							npc.ai[0] = -1f;
						}
						else if (Main.tile[num358, num359 + 2].active())
						{
							npc.ai[0] = -1f;
						}
					}
					if (!targetDryPlayer && ((double)npc.velocity.Y > 0.4 || (double)npc.velocity.Y < -0.4))
					{
						npc.velocity.Y *= 0.95f;
					}
				}
			}
			npc.rotation = npc.velocity.Y * (float)npc.direction * 0.1f;
			if ((double)npc.rotation < -0.2)
			{
				npc.rotation = -0.2f;
			}
			if ((double)npc.rotation > 0.2)
			{
				npc.rotation = 0.2f;
			}
		}
		    if (npc.wet != true)
		    {
			    npc.active = false;
		    }
		}
		if (npc.wet)
		{
		    Lighting.AddLight(npc.position, 0.25f, 0.25f, 0.25f);
        }		
		
		if (Main.LocalPlayer.FindBuffIndex(mod.BuffType("Fishing")) > -1)
		{
			npc.dontTakeDamage = false;
		}
		else
		{
			npc.dontTakeDamage = true;
		}
		}
		public override void NPCLoot ()
		{
		for (int i = 0; i < 1; ++i)
		{
		    Player player = Main.player[i];
		    if (Main.rand.Next(15) == 0 && ((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).radioactiveGoo)
            {
                NPC.NewNPC((int)(npc.position.X), (int)(npc.position.Y), (mod.NPCType("Tier3Fish")));
            }
        }			
		}
	}
}
