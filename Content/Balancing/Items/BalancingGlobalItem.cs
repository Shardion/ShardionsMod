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
        public override bool PreOpenVanillaBag(string context, Player player, int arg)
        {
			if (context == "bossBag" && arg == ItemID.FairyQueenBossBag && ModContent.GetInstance<Utilities.BalancingConfig>().SwapSoaringInsignia) { // EoL bag
				// We have to manually re-implement the drops
				// Might not be 100% accurate to the original bag but I can't find the code in vanilla for bags so
				var entitySource = player.GetSource_OpenItem(ItemID.FairyQueenBossBag);
				var pickOneOfFour = Main.rand.Next(4);
				if (Main.rand.NextBool(7)) { player.QuickSpawnItem(entitySource, ItemID.FairyQueenMask); } // Empress of Light Mask
				switch (pickOneOfFour) {
					case 0:
						player.QuickSpawnItem(entitySource, ItemID.FairyQueenMagicItem); // Nightglow
						break;
					case 1:
						player.QuickSpawnItem(entitySource, ItemID.PiercingStarlight); // Starlight
						break;
					case 2:
						player.QuickSpawnItem(entitySource, ItemID.RainbowWhip); // Kaleidoscope
						break;
					case 3:
						player.QuickSpawnItem(entitySource, ItemID.FairyQueenRangedItem); // Eventide
						break;
				}
				player.QuickSpawnItem(entitySource, ItemID.GravityGlobe); // Gravity Globe
				if (Main.rand.NextBool(10)) { player.QuickSpawnItem(entitySource, ItemID.RainbowWings); } // Empress Wings
				if (Main.rand.NextBool(20)) { player.QuickSpawnItem(entitySource, ItemID.SparkleGuitar); } // Stellar Tune
				if (Main.rand.NextBool(20)) { player.QuickSpawnItem(entitySource, ItemID.RainbowCursor); } // Rainbow Cursor
				if (Main.rand.NextBool(4)) { player.QuickSpawnItem(entitySource, ItemID.HallowBossDye); } // Prismatic Dye
				player.QuickSpawnItem(entitySource, ItemID.GoldCoin, 25); // 25 Gold Coins

				return false;
			}
			return base.PreOpenVanillaBag(context, player, arg);
        }
    }
}