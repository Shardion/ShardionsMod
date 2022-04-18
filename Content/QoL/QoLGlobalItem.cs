using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;

namespace ShardionsMod.Content.QoL { 
    public class QoLGlobalItem : GlobalItem {
        public override void SetDefaults(Item item)
        {
            int[] gems = {
                ItemID.Topaz,
                ItemID.Amethyst,
                ItemID.Ruby,
                ItemID.Sapphire,
                ItemID.Emerald,
                ItemID.Amber
            };
            if (gems.Contains<int>(item.type) && ModContent.GetInstance<Utilities.QoLConfig>().GemCrafting) {
                item.value = Item.sellPrice(silver: 3, copper: 75);
            }
        }
    }
}