using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using CalamityMod;

namespace Calgen.Items
{
    public class SunkenSea : ModItem
    {
        public override string Texture => "CalamityMod/BiomeManagers/SunkenSeaIcon";
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Sunken Sea Generator");
            // Tooltip.SetDefault("Generates a Sunken Sea to the right of you when above sand");
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.value = 0;
            Item.autoReuse = false;
            Item.useStyle = 4;
            Item.UseSound = CalamityMod.NPCs.Cryogen.Cryogen.HitSound;
            Item.width = 54;
            Item.height = 46;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.HotPink>();
        }

        public override bool? UseItem(Player player)
        {
            int sunkenSeaX = (int)(player.position.X / 16);
            int sunkenSeaY = (int)(player.position.Y / 16) + 10;
            CalamityMod.World.SunkenSea.Place(new Point(sunkenSeaX, sunkenSeaY));

            return true;
        }
    }
}