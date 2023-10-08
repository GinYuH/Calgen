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
    public class AstralMonolith : BaseGenerator
    {
        public override string Texture => "CalamityMod/Items/Placeables/AstralMonolith";
        public override string StructName => "Astral Beacon Tower";
        public override string ShortName => "tower";
        public override Terraria.Audio.SoundStyle UseSound => CalamityMod.NPCs.AstrumDeus.AstrumDeusHead.SpawnSound;
        public override bool IsPlacer => true;
        public override void GenerationFunction(Player player)
        {
            string mapKey = "Astral Beacon";
            bool place = true;
            SchematicManager.PlaceSchematic<Action<Chest>>(mapKey, new Point((int)(Main.MouseWorld.X / 16), (int)(Main.MouseWorld.Y / 16)), SchematicAnchor.TopLeft, ref place);
        }
    }
}