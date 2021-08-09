using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Pandemonium;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using System;
using Steamworks;
using System.Threading;
using Pandemonium.Items.Materials;

namespace Pandemonium.NPCs
{
    public class BloodBat : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood Bat");
            Main.npcFrameCount[npc.type] = 8;
        }
        public override void SetDefaults()
        {
            npc.width = 25;
            npc.height = 15;
            npc.aiStyle = 14;
            npc.damage = 30;
            npc.defense = 2;
            npc.lifeMax = 50;
            npc.value = 25f;
            aiType = 14;
            animationType = NPCID.CaveBat;

        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = 50 + numPlayers * 25;
            npc.damage = 15;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (Main.bloodMoon && spawnInfo.player.ZoneOverworldHeight)
            {
                return SpawnCondition.OverworldNight.Chance * 0.2f;
            }
            else
            {
                return SpawnCondition.OverworldDay.Chance * 0f;
            }
        }
    }
}
