using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.Linq;
using CalamityMod;

namespace Calgen.Items
{
    public class SulphurSea : ModItem
    {
        public override string Texture => "CalamityMod/BiomeManagers/AbyssLayer2Icon";
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Abyss and Sulphurous Sea Generator");
            // Tooltip.SetDefault("Generates an Abyss and Sulphurous Sea on the right side of the world\n"+"Don't worry if the game freezes, it'll take around a 15 seconds to a minute at most but things will run fine after");
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.value = 0;
            Item.autoReuse = false;
            Item.useStyle = 4;
            Item.UseSound = CalamityMod.Sounds.CommonCalamitySounds.FlareSound;
            Item.width = 54;
            Item.height = 46;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.HotPink>();
        }

        public override void ModifyTooltips(List<TooltipLine> list)
        {
            Player player = Main.LocalPlayer;
            TooltipLine line0 = list.FirstOrDefault(x => x.Mod == "Terraria" && x.Name == "Tooltip0");
            string side = "right";
            if (CalamityMod.World.Abyss.AtLeftSideOfWorld)
            {
                side = "left";
            }
            line0.Text = "Generates an Abyss and Sulphurous Sea at the " + side + " side of the world";
        }

        public override bool? UseItem(Player player)
        {
            CalamityMod.World.SulphurousSea.PlaceSulphurSea();
            CalamityMod.World.Abyss.PlaceAbyss();
            CalamityMod.World.SulphurousSea.SulphurSeaGenerationAfterAbyss();
            return true;
        }
    }
}