using ShardionsMod.Utilities;

namespace ShardionsMod.Content.VV.Items.Weapons.Sophisticated {
    public class RealityRipper : ShardItem {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults(); // unsure if i need to do this but vs code auto added it
            Tooltip.SetDefault("'Don't drop it or you'll slice reality in two'\nThrows an aggressively homing starlight scythe that rips enemies in half and emits energy\nRight click to throw it in place, where it will create two homing deathrays");
        }

        public override void SetDefaults() 
        {
            Item.damage = 2222;
        }
    }
}