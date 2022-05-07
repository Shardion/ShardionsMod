using ShardionsMod.Utilities;

namespace ShardionsMod.Content.VV.Items.Weapons.Sophisticated 
{
    public class RealityRipper : ShardItem 
    {
        public override void SetStaticDefaults()
        {
            UsePlaceholderSprite = true;
            Tooltip.SetDefault("Unfinished, will not do what it says\nYou probably shouldn't have this\n'Don't drop it or you'll slice reality in two'\nThrows an aggressively homing starlight scythe that rips enemies in half and emits energy\nRight click to throw it in place, where it will create two homing deathrays");
        }

        public override void SetDefaults() 
        {
            Item.damage = 2222;
            Developer = (int)DevIndex.Shardion;
        }
    }
}