using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Linq;
using static ShardionsMod.Content.Balancing.Recipes.BalancingConditions;

namespace ShardionsMod.Content.Balancing.Recipes
{
    public class TerrasparkBootsRecipeNerf : ModSystem
    {
        public static Recipe TerrasparkBootsRecipe;
        
        public override void AddRecipes() 
        {

            TerrasparkBootsRecipe = Main.recipe.Take(Recipe.numRecipes)
                .Where(recipe => recipe.HasIngredient(ItemID.FrostsparkBoots))
                .Where(recipe => recipe.HasIngredient(ItemID.LavaWaders))
                .Where(recipe => recipe.HasTile(TileID.TinkerersWorkbench))
                .Where(recipe => recipe.HasResult(ItemID.TerrasparkBoots))
                .FirstOrDefault();

            if (TerrasparkBootsRecipe != null)
            {
                if (!TerrasparkBootsRecipe.HasCondition(IsTerrasparkBootsRecipeNerfNotEnabled)) 
                {
                    TerrasparkBootsRecipe.AddCondition(IsTerrasparkBootsRecipeNerfNotEnabled);
                }
            }

            Mod.CreateRecipe(ItemID.TerrasparkBoots)
                .AddCondition(IsTerrasparkBootsRecipeNerfEnabled)
                .AddIngredient(ItemID.FrostsparkBoots)
                .AddIngredient(ItemID.LavaWaders)
                .AddIngredient(ItemID.SoulofFright)
                .AddIngredient(ItemID.SoulofMight)
                .AddIngredient(ItemID.SoulofSight)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }

        public override void Unload()
        {
            TerrasparkBootsRecipe = null;
        }
    }
}