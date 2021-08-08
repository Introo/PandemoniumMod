using Microsoft.Xna.Framework;
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

namespace Pandemonium
{
    public class PandemoniumWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if(shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("Lithium Deposits", GenerateLithiumOre));
            }
            if(NPC.downedGolemBoss = true)
            {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("Lithium Deposits", GenerateBasalite));
            }
        }

        private void GenerateLithiumOre(GenerationProgress progress)
        {
            progress.Message = "Generating Lithium Deposits";
            for(var i = 0; i < (Main.maxTilesY * Main.maxTilesX) * 6E-05; i++)
            {
                int x = WorldGen.genRand.Next(200, Main.maxTilesX - 200);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY - 500);

                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(6, 12), WorldGen.genRand.Next(3, 6), ModContent.TileType<Items.Tiles.LithiumOre>());
            }
        }
        private void GenerateBasalite(GenerationProgress progress)
        {
            if(NPC.downedGolemBoss && Main.hardMode)
            {
                int x = WorldGen.genRand.Next(19200, 17000);
                int y = WorldGen.genRand.Next(19200, 17000);

                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 5), WorldGen.genRand.Next(3, 6), ModContent.TileType<Items.Tiles.BasaltOre>());
            }
        }
        public override void PostWorldGen()
        {
            if (NPC.downedGolemBoss == true)
            {
                int x = WorldGen.genRand.Next(Main.maxTilesX, Main.maxTilesX - Main.maxTilesX);
                int y = WorldGen.genRand.Next(Main.maxTilesY, Main.maxTilesX - Main.maxTilesX);
                Tile t = Framing.GetTileSafely(x, y);
                if (t.active())
                {
                    if(t.type == TileID.Ash)
                    {
                        WorldGen.OreRunner(x, y, WorldGen.genRand.Next(3, 5), WorldGen.genRand.Next(3, 6), (ushort)ModContent.TileType<Items.Tiles.BasaltOre>());
                    }
                }
            }
        }

    }
}
