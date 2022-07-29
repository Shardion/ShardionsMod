using Terraria.ID;
using Terraria.ModLoader;
using ShardionsMod.Utilities;

namespace ShardionsMod.Content.VV.Items.Vanity.Sophisticated
{
    [AutoloadEquip(EquipType.Legs)]
    public class SophisticatedStockings : ShardItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sophisticated Stockings");
        }

        public override void SetDefaults()
        {
            FemaleLegsTexture = "SophisticatedStockings_FemaleLegs";
            Developer = (int)DevIndex.Shardion;
            Item.width = 22;
            Item.height = 32;
            Item.value = 0;
            Item.rare = 0;
            Item.vanity = true;
            Item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            this.CreateRecipe()
                .AddCondition(Content.VV.Recipes.VVConditions.AreThreadRecipesEnabled)
                .AddIngredient(Mod, "Fabric", 3)
                .AddIngredient(Mod, "WhiteThread", 1)
                .AddTile(TileID.Loom)
                .Register();
            
            this.CreateRecipe()
                .AddCondition(Content.VV.Recipes.VVConditions.AreDyeRecipesEnabled)
                .AddIngredient(Mod, "Fabric", 3)
                .AddIngredient(ItemID.BrightSilverDye, 1)
                .AddTile(TileID.Loom)
                .Register();
            
            this.CreateRecipe()
                .AddCondition(Content.VV.Recipes.VVConditions.AreNoColorRecipesEnabled)
                .AddIngredient(Mod, "Fabric", 3)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
    // long ago, there were variants of this item
    // now, they only live as layers in the krita files, doomed to eternal obscurity
}
