using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
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
                Recipe.Create(ItemID.Diamond)
                    .AddCondition(IsGemCraftingEnabled)
                    .AddIngredient(gem)
                    .AddTile(TileID.DemonAltar)
                    .Register();
                Recipe.Create(gem)
                    .AddCondition(IsGemCraftingEnabled)
                    .AddIngredient(ItemID.Diamond)
                    .AddTile(TileID.DemonAltar)
                    .Register();
            }
        }
    }
}
            