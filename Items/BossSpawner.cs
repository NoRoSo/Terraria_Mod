using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using TestBoss.NPCs;

namespace TestBoss.Items
{
    public class BossSpawner : ModItem
    {
        public override void SetDefaults()
        {
            Item.consumable = true;
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 32;
            Item.useAnimation = 40;
            Item.useTime = 45;
            Item.value = 100;

            Item.useStyle = ItemUseStyleID.HoldUp;

        }

        public override bool CanUseItem(Player player)
        {
            return true;
        }

        public override bool? UseItem(Player player)
        {
            int type = ModContent.NPCType<Nathan>();

            SoundEngine.PlaySound(SoundID.Roar, player.position);
            NPC.SpawnOnPlayer(player.whoAmI, type);
            Main.NewText("Nathan has arrived!");


            return true;
        }
    }
}
