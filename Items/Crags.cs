using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.Linq;
using CalamityMod;
using CalamityMod.Rarities;
using CalamityMod.Sounds;
using CalamityMod.World;

namespace Calgen.Items
{
    public class Crags : ModItem
    {
        public override string Texture => "CalamityMod/BiomeManagers/BrimstoneCragsIcon";
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Brimstone Crag Generator");
            // Tooltip.SetDefault("Generates a Brimstone Crag");
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.value = 0;
            Item.autoReuse = false;
            Item.useStyle = 4;
            Item.UseSound = CommonCalamitySounds.FlareSound;
            Item.width = 54;
            Item.height = 46;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.rare = ModContent.RarityType<HotPink>();
        }

        public override void ModifyTooltips(List<TooltipLine> list)
        {
            Player player = Main.LocalPlayer;
            TooltipLine line0 = list.FirstOrDefault(x => x.Mod == "Terraria" && x.Name == "Tooltip0");
            string side = "right";
            if (Abyss.AtLeftSideOfWorld)
            {
                side = "left";
            }
            line0.Text = "Generates a Brimstone Crag at the " + side + " side of the world";
        }

        public override bool? UseItem(Player player)
        {
            BrimstoneCrag.GenAllCragsStuff();
            return true;
        }
    }
}