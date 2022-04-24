using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;
using Terraria.GameContent.ItemDropRules;

namespace ShardionsMod.Content.Balancing.NPCs
{
	public class BalancingGlobalNPC : GlobalNPC
	{
		int[] planterBoxes = {
			ItemID.CorruptPlanterBox,
			ItemID.CrimsonPlanterBox,
			ItemID.DayBloomPlanterBox,
			ItemID.MoonglowPlanterBox,
			ItemID.BlinkrootPlanterBox,
			ItemID.WaterleafPlanterBox,
			ItemID.FireBlossomPlanterBox,
			ItemID.ShiverthornPlanterBox
		};
		public override bool InstancePerEntity => true;
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
			if (npc.type == NPCID.HallowBoss) { // what a descriptive name, thanks red
				npcLoot.Remove(ItemDropRule.ByCondition(new Conditions.IsExpert(), ItemID.EmpressFlightBooster));
			}
		}
		public override void SetupShop(int type, Chest shop, ref int nextSlot) {
			if (type == NPCID.Dryad && ModContent.GetInstance<Utilities.BalancingConfig>().AlwaysSellPlanterBoxes) {
				int[] ignore = {};
				foreach(Item item in shop.item) {
					if (planterBoxes.Contains<int>(item.type)) {
						ignore = ignore.Append<int>(item.type).ToArray<int>();
					}
				}
				foreach(int item in planterBoxes) {
					if (!ignore.Contains<int>(item)) {
						// AWFUL if statement
						if (!(
							(item == ItemID.CorruptPlanterBox && ignore.Contains<int>(ItemID.CrimsonPlanterBox))
							|| (item == ItemID.CrimsonPlanterBox && ignore.Contains<int>(ItemID.CorruptPlanterBox)) 
						))
						{
							shop.item[nextSlot].SetDefaults(item);
							nextSlot++;
						}
					}
				}
            }
        }
    }
}