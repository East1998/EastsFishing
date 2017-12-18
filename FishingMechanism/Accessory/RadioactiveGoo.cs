using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism.Accessory
{
    public class RadioactiveGoo : ModItem
    {


        public override void SetDefaults()
        {

            item.width = 24;
            item.height = 24;

            item.value = 20000;
            item.rare = 2;
            item.accessory = true;
        }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Radioactive Goo");
      Tooltip.SetDefault("Fish can rarely become higher tier fish when killed");
    }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			((EastsFishingGlobalPlayer)player.GetModPlayer(mod, "EastsFishingGlobalPlayer")).radioactiveGoo= true;
        }
    }
}
