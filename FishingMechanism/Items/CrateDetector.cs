using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;


namespace EastsFishing.FishingMechanism.Items
{
    public class CrateDetector : ModItem
    {
	    public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crate Detector");
			Tooltip.SetDefault("Spawns a crate detector to summon crates occasionally\nOnly works in the water\nCrates requires atlest 30*30 pool to spawn\nUsing crate detector in a respective biome can cause their crates to be summoned\nCrate detector can summon junks occasionally\nCrate detector requires a solid block to stand on\nRight-click to catch all crates");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.useTime = 30;   //How fast the Weapon is used.
            item.useAnimation = 30;    //How long the Weapon is used for.
            item.useStyle = 5;  //The way your Weapon will be used, 1 is the regular sword swing for example
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
            item.noMelee = true; //so the item's animation doesn't do damage
			item.value = 10000;
            item.knockBack = 2.5f;  //The knockback stat of your Weapon.
            item.rare = 2;   //The color the title of your Weapon when hovering over it ingame  
            item.UseSound = SoundID.Item82;   //The sound played when using your Weapon
            item.autoReuse = false;   //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = mod.ProjectileType("CrateDetectorProjectile");   //This defines what type of projectile this weapon will shot	
        }
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
                item.useTurn = true;
                item.useStyle = 1;
                item.useAnimation = 25;
                item.width = 24;
                item.height = 28;
                item.UseSound = SoundID.Item7;
				item.shoot = mod.ProjectileType("placeholder");   //This defines what type of projectile this weapon will shot
                item.autoReuse = true;
			}
			else
			{
				item.width = 20;
            item.height = 20;
            item.useTime = 30;   //How fast the Weapon is used.
            item.useAnimation = 30;    //How long the Weapon is used for.
            item.useStyle = 5;  //The way your Weapon will be used, 1 is the regular sword swing for example
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 2.5f;  //The knockback stat of your Weapon.
            item.rare = 2;   //The color the title of your Weapon when hovering over it ingame  
            item.UseSound = SoundID.Item82;   //The sound played when using your Weapon
            item.autoReuse = false;   //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = mod.ProjectileType("CrateDetectorProjectile");   //This defines what type of projectile this weapon will shot
			}		
			return base.CanUseItem(player);
		}
        public override bool UseItem (Player player)
		{
		    if (player.altFunctionUse == 2)	
            {
                for (int i1 = 0; i1 < 200; ++i1)
                {
				if (Main.npc[i1].active && (int) Main.npc[i1].catchItem > 0 && (Main.npc[i1].type == mod.NPCType("WoodenCrate") || Main.npc[i1].type == mod.NPCType("IronCrate") || Main.npc[i1].type == mod.NPCType("GoldenCrate") || Main.npc[i1].type == mod.NPCType("DungeonCrate") || Main.npc[i1].type == mod.NPCType("Seaweed") || Main.npc[i1].type == mod.NPCType("OldShoe") || Main.npc[i1].type == mod.NPCType("TinCan") || Main.npc[i1].type == mod.NPCType("HallowedCrate") || Main.npc[i1].type == mod.NPCType("CrimsonCrate") || Main.npc[i1].type == mod.NPCType("CorruptCrate") || Main.npc[i1].type == mod.NPCType("SkyCrate") || Main.npc[i1].type == mod.NPCType("JungleCrate")))
                    {
                        Microsoft.Xna.Framework.Rectangle rectangle = new Microsoft.Xna.Framework.Rectangle((int) Main.npc[i1].position.X, (int) Main.npc[i1].position.Y, Main.npc[i1].width, Main.npc[i1].height);
						{
                            NPC.CatchNPC(i1, Main.myPlayer);
						}
                    }
                }
            }
			return true;
		}
        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
		if (player.altFunctionUse != 2)		
        {
            Vector2 SPos = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);   //this make so the projectile will spawn at the mouse cursor position
            position = SPos;
            for (int l = 0; l < Main.projectile.Length; l++)
            {                                                                  //this make so you can only spawn one of this projectile at the time,
                Projectile proj = Main.projectile[l];
                if (proj.active && proj.type == item.shoot && proj.owner == player.whoAmI)
                {
                    proj.active = false;
                }
            }     
        }
		return true;
		}
		public override void AddRecipes()
		{
		    ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.Anvils);
			recipe.AddIngredient(2356, 1);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(530, 5);
			recipe.anyIronBar = true;
			recipe.SetResult(this,1);
			recipe.AddRecipe();
        }
    }
}