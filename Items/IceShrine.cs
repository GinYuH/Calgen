using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using CalamityMod.Schematics;
using System;
using static CalamityMod.World.UndergroundShrines;

namespace Calgen.Items
{
    public class IceShrine : BaseGenerator
    {
        public override string Texture => "CalamityMod/Items/Mounts/TundraLeash";
        public override string StructName => "Ice Shrine";
        public override string ShortName => "shrine";
        public override Terraria.Audio.SoundStyle UseSound => CalamityMod.Sounds.CommonCalamitySounds.LightningSound;
        public override bool IsPlacer => true;
        public override void GenerationFunction(Player player)
        {
            string mapKey = StructName;
            bool hasPlacedLogAndSchematic = false;
            SchematicManager.PlaceSchematic(mapKey, new Point((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16), SchematicAnchor.TopLeft,
            ref hasPlacedLogAndSchematic, new Action<Chest>(FillIceShrineChest));
        }
    }
    public class DesertShrine : BaseGenerator
    {
        public override string Texture => "CalamityMod/Items/Accessories/LuxorsGift";
        public override string StructName => "Desert Shrine";
        public override string ShortName => "shrine";
        public override Terraria.Audio.SoundStyle UseSound => CalamityMod.Sounds.CommonCalamitySounds.LightningSound;
        public override bool IsPlacer => true;
        public override void GenerationFunction(Player player)
        {
            string mapKey = StructName;
            bool hasPlacedLogAndSchematic = false;
            SchematicManager.PlaceSchematic(mapKey, new Point((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16), SchematicAnchor.TopLeft,
            ref hasPlacedLogAndSchematic, new Action<Chest>(FillDesertShrineChest));
        }
    }
    public class GraniteShrine : BaseGenerator
    {
        public override string Texture => "CalamityMod/Items/Accessories/UnstableGraniteCore";
        public override string StructName => "Granite Shrine";
        public override string ShortName => "shrine";
        public override Terraria.Audio.SoundStyle UseSound => CalamityMod.Sounds.CommonCalamitySounds.LightningSound;
        public override bool IsPlacer => true;
        public override void GenerationFunction(Player player)
        {
            string mapKey = StructName;
            bool hasPlacedLogAndSchematic = false;
            SchematicManager.PlaceSchematic(mapKey, new Point((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16), SchematicAnchor.TopLeft,
            ref hasPlacedLogAndSchematic, new Action<Chest>(FillGraniteShrineChest));
        }
    }
    public class MarbleShrine : BaseGenerator
    {
        public override string Texture => "CalamityMod/Items/Accessories/GladiatorsLocket";
        public override string StructName => "Marble Shrine";
        public override string ShortName => "shrine";
        public override Terraria.Audio.SoundStyle UseSound => CalamityMod.Sounds.CommonCalamitySounds.LightningSound;
        public override bool IsPlacer => true;
        public override void GenerationFunction(Player player)
        {
            string mapKey = StructName;
            bool hasPlacedLogAndSchematic = false;
            SchematicManager.PlaceSchematic(mapKey, new Point((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16), SchematicAnchor.TopLeft,
            ref hasPlacedLogAndSchematic, new Action<Chest>(FillMarbleShrineChest));
        }
    }
    public class CorruptionShrine : BaseGenerator
    {
        public override string Texture => "CalamityMod/Items/Placeables/Furniture/CorruptionEffigy";
        public override string StructName => "Corruption Shrine";
        public override string ShortName => "shrine";
        public override Terraria.Audio.SoundStyle UseSound => CalamityMod.Sounds.CommonCalamitySounds.LightningSound;
        public override bool IsPlacer => true;
        public override void GenerationFunction(Player player)
        {
            string mapKey = StructName;
            bool hasPlacedLogAndSchematic = false;
            SchematicManager.PlaceSchematic(mapKey, new Point((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16), SchematicAnchor.TopLeft,
            ref hasPlacedLogAndSchematic, new Action<Chest>(FillCorruptionShrineChest));
        }
    }
    public class CrimsonShrine : BaseGenerator
    {
        public override string Texture => "CalamityMod/Items/Placeables/Furniture/CrimsonEffigy";
        public override string StructName => "Crimson Shrine";
        public override string ShortName => "shrine";
        public override Terraria.Audio.SoundStyle UseSound => CalamityMod.Sounds.CommonCalamitySounds.LightningSound;
        public override bool IsPlacer => true;
        public override void GenerationFunction(Player player)
        {
            string mapKey = StructName;
            bool hasPlacedLogAndSchematic = false;
            SchematicManager.PlaceSchematic(mapKey, new Point((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16), SchematicAnchor.TopLeft,
            ref hasPlacedLogAndSchematic, new Action<Chest>(FillCrimsonShrineChest));
        }
    }
    public class MushroomShrine : BaseGenerator
    {
        public override string Texture => "CalamityMod/Items/Accessories/FungalSymbiote";
        public override string StructName => "Mushroom Shrine";
        public override string ShortName => "shrine";
        public override Terraria.Audio.SoundStyle UseSound => CalamityMod.Sounds.CommonCalamitySounds.LightningSound;
        public override bool IsPlacer => true;
        public override void GenerationFunction(Player player)
        {
            string mapKey = StructName;
            bool hasPlacedLogAndSchematic = false;
            SchematicManager.PlaceSchematic(mapKey, new Point((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16), SchematicAnchor.TopLeft,
            ref hasPlacedLogAndSchematic, new Action<Chest>(FillMushroomShrineChest));
        }
    }
    public class SurfaceShrine : BaseGenerator
    {
        public override string Texture => "CalamityMod/Items/Accessories/TrinketofChi";
        public override string StructName => "Surface Shrine";
        public override string ShortName => "shrine";
        public override Terraria.Audio.SoundStyle UseSound => CalamityMod.Sounds.CommonCalamitySounds.LightningSound;
        public override bool IsPlacer => true;
        public override void GenerationFunction(Player player)
        {
            string mapKey = StructName;
            bool hasPlacedLogAndSchematic = false;
            SchematicManager.PlaceSchematic(mapKey, new Point((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16), SchematicAnchor.TopLeft,
            ref hasPlacedLogAndSchematic, new Action<Chest>(FillSurfaceShrineChest));
        }
    }
}