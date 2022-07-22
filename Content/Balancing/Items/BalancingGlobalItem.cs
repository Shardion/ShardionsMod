using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.Linq;
//using static Terraria.GameContent.ItemDropRules.ItemDropRule;
using static Terraria.ModLoader.ModContent;

namespace ShardionsMod.Content.Balancing.Items
{
	public class BalancingGloalItem : GlobalItem
	{
        public override void ModifyItemLoot(Item item, ItemLoot itemLoot) {
			if (ModContent.GetInstance<Utilities.BalancingConfig>().SwapSoaringInsignia) {
				if (item.type == ItemID.FairyQueenBossBag) {
					itemLoot.RemoveWhere(
						rule => rule is CommonDrop drop
						&& drop.itemId == ItemID.EmpressFlightBooster
					);
					itemLoot.Add(ItemDropRule.Common(ItemID.GravityGlobe, 1));
				} else if (item.type == ItemID.MoonLordBossBag) {
					itemLoot.RemoveWhere(
						rule => rule is CommonDrop drop
						&& drop.itemId == ItemID.GravityGlobe
					);
					itemLoot.Add(ItemDropRule.Common(ItemID.EmpressFlightBooster, 1));
				}
			}
		}
    }
}
