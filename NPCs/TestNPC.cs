using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestBoss.NPCs
{
    [AutoloadBossHead]
    public class Nathan : ModNPC
    {
        public override void SetDefaults()
        {
            NPC.width = 10;
            NPC.height = 10;
            NPC.aiStyle = NPCAIStyleID.KingSlime;
            NPC.defense = 35;
            NPC.lifeMax = 100;
            NPC.boss = true;

            Main.npcFrameCount[NPC.type] = 1;
            NPCID.Sets.ExtraFramesCount[NPC.type] = 0;
            NPCID.Sets.AttackFrameCount[NPC.type] = 0;
        }

        public override List<string> SetNPCNameList()
        {
            return new List<string>()
            {
                "Nathan"
            };
        }

/*        public override string GetChat()
        {
            return "I like Coding :3";
        }*/
    }
    
}
