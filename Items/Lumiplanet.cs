using Terraria;
using Terraria.ModLoader;
using CalamityMod;

namespace Calgen.Items
{
    public class Lumiplanet : ModItem
    {
        public override string Texture => "CalamityMod/Items/Placeables/Ores/ExodiumCluster";
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Luminite Planetoid Generator");
            // Tooltip.SetDefault("Attempts to generate Luminite Planetoids when used");
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.value = 0;
            Item.autoReuse = false;
            Item.useStyle = 4;
            Item.UseSound = CalamityMod.Sounds.CommonCalamitySounds.OtherwordlyHitSound;
            Item.width = 54;
            Item.height = 46;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.rare = ModContent.RarityType<CalamityMod.Rarities.HotPink>();
        }

        public override bool? UseItem(Player player)
        {
            CalamityMod.World.Planets.LuminitePlanet.GenerateLuminitePlanetoids(); 
            return true;
        }
    }
}