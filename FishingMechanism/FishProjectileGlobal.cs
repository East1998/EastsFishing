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

namespace EastsFishing.FishingMechanism
{
    public class FishProjectileGlobal : GlobalProjectile
    {
		public bool SubmarineHeatSensor = false;
		public override void AI (Projectile projectile)
		{
			if (SubmarineHeatSensor == true && projectile.type == mod.ProjectileType("FishingPikeProjectile"))
			{
			    if (projectile.alpha > 70)
			    {
				    projectile.alpha -= 15;
				    if (projectile.alpha < 70)
				    {
					    projectile.alpha = 70;
				    }
			    }
			    if (projectile.localAI[0] == 0f)
			    {
				    AdjustMagnitude(ref projectile.velocity);
				    projectile.localAI[0] = 1f;
			    }
			    Vector2 move = Vector2.Zero;
			    float distance = 400f;
			    bool target = false;
			    for (int k = 0; k < 200; k++)
			    {
				    if (Main.npc[k].active && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].lifeMax > 1 && Main.npc[k].type != 488)
				    {
					    Vector2 newMove = Main.npc[k].Center - projectile.Center;
					    float distanceTo = (float)Math.Sqrt(newMove.X * newMove.X + newMove.Y * newMove.Y);
					    if (distanceTo < distance)
					    {
						    move = newMove;
						    distance = distanceTo;
						    target = true;
					    }
				    }
			    }
			    if (target)
			    {
				    AdjustMagnitude(ref move);
				    projectile.velocity = (20 * projectile.velocity + move) / 3f;
				    AdjustMagnitude(ref projectile.velocity);
			    }
            }
		}
		public override void PostAI (Projectile projectile)
	    {
			Player player = Main.player[projectile.owner];
			for(int i = 0; i < 8 + player.extraAccessorySlots; i++)
			{ 
		        if(player.armor[i].type == mod.ItemType("SubmarineHeatSensor"))
                {
                    SubmarineHeatSensor = true;
                }
			}
		}
		private void AdjustMagnitude(ref Vector2 vector)
		{
			{
			    float magnitude = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
			    if (magnitude > 6f)
			    {
				    vector *= 6f / magnitude;
			    }
		    }
        }
        public override bool InstancePerEntity
		{
			get
			{
				return true;
			}
		}		
    }
}  