using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System.Linq;
using static Terraria.ModLoader.ModContent;

namespace ShardionsMod.Content.VV
{
	public class VVPlayer : ModPlayer
	{
        public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath) 
        {
            if (Player.name == "shardion" && Player.Male == false)
                return new Item[2] { GetInstance<VV.Items.Vanity.Sophisticated.SophisticatedStockings>().Item, GetInstance<VV.Items.Vanity.Sophisticated.SophisticatedSweater>().Item };
            return Enumerable.Empty<Item>();
        }
    }
}