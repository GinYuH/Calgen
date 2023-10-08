using Terraria;
using Terraria.ModLoader;
using CalamityMod;
using Terraria.Audio;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using CalamityMod.Schematics;
using System;
using static CalamityMod.World.UndergroundShrines;

namespace Calgen.Items
{
    public abstract class BaseGenerator : ModItem
    {
        public override string Texture => "CalamityMod/Items/Placeables/Ores/AerialiteOre";

        public abstract SoundStyle UseSound { get; }
        public abstract string StructName { get; }
        public abstract string ShortName { get; }
        public abstract void GenerationFunction(Player player);
        public abstract bool IsPlacer { get; }

        public override void SetStaticDefaults()
        {
            string lastName = "Generator";
            string firstLine = "Generates";
            if (IsPlacer)
            {
                lastName = "Placer";
                firstLine = "Places";
            }
            // DisplayName.SetDefault(StructName + " " + lastName);
            /* Tooltip.SetDefault(firstLine + " a " + StructName + " Ice Shrine when used\n" +
                "Your cursor is positioned at the top left corner of the " + ShortName+"\n" +
                "[c/C61B40:Do NOT use in a location where the "+ShortName+" will place on a chest or unique lab furniture']"); */
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.value = 0;
            Item.autoReuse = false;
            Item.useStyle = 4;
            Item.UseSound = UseSound;
            Item.width = 54;
            Item.height = 46;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.HotPink>();
        }

        public override bool? UseItem(Player player)
        {
            GenerationFunction(player);
            return true;
        }
    }
}