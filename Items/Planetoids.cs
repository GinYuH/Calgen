using Terraria;
using Terraria.ModLoader;
using CalamityMod;

namespace Calgen.Items
{
    public class Planetoids : ModItem
    {
        public override string Texture => "CalamityMod/Items/Placeables/Ores/AerialiteOre";
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Aerialite Generator");
            // Tooltip.SetDefault("Attempts to generate Aerialite in the clouds when used");
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.value = 0;
            Item.autoReuse = false;
            Item.useStyle = 4;
            Item.UseSound = CalamityMod.Tiles.Ores.AerialiteOre.MineSound;
            Item.width = 54;
            Item.height = 46;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.HotPink>();
        }

        public override bool? UseItem(Player player)
        {
            CalamityMod.World.AerialiteOreGen.Generate(false);
            return true;
        }
    }
}