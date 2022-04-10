using Terraria.ID;
using Terraria.ModLoader;
using ShardionsMod.Utilities;

namespace ShardionsMod.Content.VV.Items.Crafting
{
    public class Fabric : ShardItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Simple, tough fabric for practical applications'");
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 32;
            Item.value = 0;
            Item.rare = 0;
            Item.maxStack = 9999;
        }

        public override void AddRecipes()
        {
            this.CreateRecipe()
                .AddCondition(ShardRecipeHandler.IsVVEnabled)
                .AddIngredient(ItemID.Cobweb, 12)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
