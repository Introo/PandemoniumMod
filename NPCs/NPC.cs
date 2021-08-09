﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;


namespace Pandemonium.NPCs
{
    public class NPCs : GlobalNPC
    {
        public override void NPCLoot(Terraria.NPC npc)
        {
            if(npc.type == NPCID.Golem && NPC.downedGolemBoss == true)
            {
                Main.NewText("Basalite pollutes the ash");
                int x = WorldGen.genRand.Next(200, Main.maxTilesX - 200);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY - 500);

                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(2, 12), WorldGen.genRand.Next(2, 6), ModContent.TileType<Items.Tiles.BasaltOre>());
            }
            if (npc.type == NPCID.WallofFlesh && !Main.hardMode)
            {
                Main.NewText("Glaciers arise from the cold Tundra");
                int x = WorldGen.genRand.Next(200, Main.maxTilesX - 200);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY - 500);

                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(2, 12), WorldGen.genRand.Next(3, 6), ModContent.TileType<Items.Tiles.GlacieriteOre>());
            }
        }
    }
}
