using Terraria.ID;
using Terraria.ModLoader;
using ShardionsMod.Utilities;

namespace ShardionsMod.Content.VV.Items.Vanity.Sophisticated
{
    [AutoloadEquip(EquipType.Body)]
    public class SophisticatedSweater : ShardItem
    {
        public override void SetStaticDefaults()
        {
            //Tooltip.SetDefault("'A boring sweater for a boring person'");
            int bodySlot = EquipLoader.GetEquipSlot(Mod, Name, EquipType.Body);
            ArmorIDs.Body.Sets.HidesHands[bodySlot] = false;
        }

        public override void SetDefaults()
        {
            
            Developer = (int)DevIndex.Shardion;
            Item.width = 30;
            Item.height = 20;
            Item.value = 0;
            Item.rare = 0;
            Item.vanity = true;
            Item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            this.CreateRecipe()
                .AddCondition(Content.VV.Recipes.VVConditions.AreThreadRecipesEnabled)
                .AddIngredient(Mod, "Fabric", 4)
                .AddIngredient(ItemID.BlackThread, 3)
                .AddTile(TileID.Loom)
                .Register();

            this.CreateRecipe()
                .AddCondition(Content.VV.Recipes.VVConditions.AreDyeRecipesEnabled)
                .AddIngredient(Mod, "Fabric", 4)
                .AddIngredient(ItemID.BlackDye, 1)
                .AddTile(TileID.Loom)
                .Register();
            
            this.CreateRecipe()
                .AddCondition(Content.VV.Recipes.VVConditions.AreNoColorRecipesEnabled)
                .AddIngredient(Mod, "Fabric", 4)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
