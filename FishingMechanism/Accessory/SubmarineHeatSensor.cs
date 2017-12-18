using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EastsFishing.FishingMechanism.Accessory
{
    public class SubmarineHeatSensor : ModItem
    {


        public override void SetDefaults()
        {

            item.width = 24;
            item.height = 24;
            item.value = 15000;
            item.rare = 3;
            item.accessory = true;
        }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Submarine Heat Sensor");
      Tooltip.SetDefault("Your fishing weapon projectiles can home in enemies and fishes");
    }
    }
}
