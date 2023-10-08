using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using CalamityMod.Schematics;
using System;
using static CalamityMod.World.VernalPass;
using CalamityMod;
using System.Collections.Generic;

namespace Calgen.Items
{
    public class VernalPass : ModItem
    {
        public override string Texture => "CalamityMod/Items/Placeables/VernalSoil";
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Vernal Pass Placer");
            /* Tooltip.SetDefault("Places a Vernal Pass on your cursor when used\n" +
                "Your cursor is positioned at the top left corner of the pass\n" +
                "[c/C61B40:Do NOT use in a location where the pass will place on a chest or unique lab furniture']"); */
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.value = 0;
            Item.autoReuse = false;
            Item.useStyle = 4;
            Item.UseSound = CalamityMod.Sounds.CommonCalamitySounds.PlagueBoomSound;
            Item.width = 54;
            Item.height = 46;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.HotPink>();
        }

        public override bool? UseItem(Player player)
        {
            string mapKey = "Vernal Pass";
            bool hasPlacedLogAndSchematic = false;
            SchematicManager.PlaceSchematic(mapKey, new Point((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16), SchematicAnchor.TopLeft,
            ref hasPlacedLogAndSchematic, new Action<Chest, int, bool>(FillVernalPassChests));
            return true;
        }
    }
}