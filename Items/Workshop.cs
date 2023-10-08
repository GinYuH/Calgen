using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using CalamityMod.Schematics;
using System;
using static CalamityMod.World.DraedonStructures;
using CalamityMod;
using System.Collections.Generic;

namespace Calgen.Items
{
    public class Workshop : ModItem
    {
        public override string Texture => "CalamityMod/Items/Placeables/DraedonStructures/RustedPlating";
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Rusted Workshop Placer");
            /* Tooltip.SetDefault("Places a Rusted Workshop on your cursor when used\n" +
                "Your cursor is positioned at the top left corner of the workshop\n" +
                "[c/C61B40:Do NOT use in a location where the workshop will place on a chest or unique lab furniture']"); */
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.value = 0;
            Item.autoReuse = false;
            Item.useStyle = 4;
            Item.UseSound = CalamityMod.Sounds.CommonCalamitySounds.ExoHitSound;
            Item.width = 54;
            Item.height = 46;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.HotPink>();
        }

        public override bool? UseItem(Player player)
        {
            string mapKey = "Rusted Workshop";
            bool hasPlacedLogAndSchematic = false;
            SchematicManager.PlaceSchematic(mapKey, new Point((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16), SchematicAnchor.TopLeft,
            ref hasPlacedLogAndSchematic, new Action<Chest>(FillWorkshopChest));
            return true;
        }
    }
}