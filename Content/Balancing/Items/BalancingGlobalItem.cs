using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.Linq;
using static Terraria.ModLoader.ModContent;

namespace ShardionsMod.Content.Balancing.Items
{
	public class BalancingGloalItem : GlobalItem
	{
        public override void ModifyItemLoot(Item item, ItemLoot itemLoot) {
			if (ModContent.GetInstance<Utilities.BalancingConfig>().SwapSoaringInsignia) {
				if (item.type == ItemID.FairyQueenBossBag) {
					itemLoot.RemoveWhere(
						rule => rule is Common drop
				  		&& drop.ItemID == ItemID.EmpressFlightBooster
					);
					itemLoot.Add(ItemDropRule.Common(ItemID.GravityGlobe, 1));
				} else if (item.type == ItemID.MoonLordBossBag) {
					itemLoot.RemoveWhere(
						rule => rule is Common drop
						&& drop.ItemID == ItemID.GravityGlobe
					);
					itemLoot.Add(ItemDropRule.Common(ItemID.EmpressFlightBooster, 1));
				}
			}
		}
    }
}