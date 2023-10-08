using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using CalamityMod.Schematics;
using System;
using static CalamityMod.World.MechanicShed;
using CalamityMod;
using System.Collections.Generic;

namespace Calgen.Items
{
    public class Shed : ModItem
    {
        public override string Texture => "CalamityMod/Items/Accessories/StatMeter";
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Mechanic's Shed Placer");
            /* Tooltip.SetDefault("Places a Mechanic Shed on your cursor when used\n" +
                "Your cursor is positioned at the top left corner of the shed\n" +
                "[c/C61B40:Do NOT use in a location where the shed will place on a chest or unique lab furniture']"); */
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.value = 0;
            Item.autoReuse = false;
            Item.useStyle = 4;
            Item.UseSound = CalamityMod.Sounds.CommonCalamitySounds.LaserCannonSound;
            Item.width = 54;
            Item.height = 46;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.HotPink>();
        }

        public override bool? UseItem(Player player)
        {
            string mapKey = "Mechanic Key";
            bool hasPlacedLogAndSchematic = false;
            SchematicManager.PlaceSchematic(mapKey, new Point((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16), SchematicAnchor.TopLeft,
            ref hasPlacedLogAndSchematic, new Action<Chest, int, bool>(FillMechanicChest));
            return true;
        }
    }
}