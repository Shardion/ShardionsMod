using Terraria.ModLoader;
using Terraria.ID;
using static ShardionsMod.Content.QoL.Recipes.QoLConditions;

namespace ShardionsMod.Content.QoL.Recipes
{
    public class GemCrafting : ModSystem
    {
        public override void AddRecipes() 
        {
            int[] gems = {
                ItemID.Topaz,
                ItemID.Amethyst,
                ItemID.Ruby,
                ItemID.Sapphire,
                ItemID.Emerald,
                ItemID.Amber
            };
            foreach (int gem in gems) {
                Mod.CreateRecipe(ItemID.Diamond)
                    .AddCondition(IsGemCraftingEnabled)
                    .AddIngredient(gem)
                    .AddTile(TileID.DemonAltar)
                    .Register();
                Mod.CreateRecipe(gem)
                    .AddCondition(IsGemCraftingEnabled)
                    .AddIngredient(ItemID.Diamond)
                    .AddTile(TileID.DemonAltar)
                    .Register();
            }
        }
    }
}
            