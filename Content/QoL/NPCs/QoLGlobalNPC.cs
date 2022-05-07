using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;
using Terraria.GameContent.ItemDropRules;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ShardionsMod.Content.QoL.NPCs
{
	public class QoLGlobalNPC : GlobalNPC
	{
        public override bool InstancePerEntity => true;
        int[] mushroomEnemies = {
            NPCID.SporeBat,
            NPCID.SporeSkeleton,
            NPCID.ZombieMushroom,
            NPCID.ZombieMushroomHat,
            NPCID.MushiLadybug,
            NPCID.FungiBulb,
            NPCID.FungoFish,
            NPCID.AnomuraFungus,
            NPCID.GiantFungiBulb
        };
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (mushroomEnemies.Contains<int>(npc.type) && ModContent.GetInstance<Utilities.QoLConfig>().MushroomEnemiesDropSeeds) {
                npcLoot.Add(ItemDropRule.Common(ItemID.MushroomGrassSeeds, 10));
            }
            if ((npc.type == NPCID.TruffleWorm || npc.type == NPCID.TruffleWormDigger) && ModContent.GetInstance<Utilities.QoLConfig>().MushroomEnemiesDropSeeds) {
                npcLoot.Add(ItemDropRule.Common(ItemID.MushroomGrassSeeds, 100, 2, 2));
            }
            base.ModifyNPCLoot(npc, npcLoot);
        }
    }
}