using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;
using Terraria.GameContent.ItemDropRules;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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
						var corruptAndShouldIgnoreCrimson = (item == ItemID.CorruptPlanterBox && ignore.Contains<int>(ItemID.CrimsonPlanterBox));
						var crimsonAndShouldIgnoreCorrupt = (item == ItemID.CrimsonPlanterBox && ignore.Contains<int>(ItemID.CorruptPlanterBox));
						if (!(corruptAndShouldIgnoreCrimson || crimsonAndShouldIgnoreCorrupt))
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
