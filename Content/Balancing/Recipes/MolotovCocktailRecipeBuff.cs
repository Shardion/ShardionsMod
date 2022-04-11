using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Linq;
using static ShardionsMod.Content.Balancing.Recipes.BalancingConditions;

namespace ShardionsMod.Content.Balancing.Recipes
{
    public class MolotovCocktailRecipeBuff : ModSystem
    {
        public static Recipe MolotovCocktailRecipe;

        public override void AddRecipes() 
        {
            MolotovCocktailRecipe = Main.recipe.Take(Recipe.numRecipes)
                .Where(recipe => recipe.HasIngredient(ItemID.Ale))
                .Where(recipe => recipe.HasIngredient(ItemID.PinkGel))
                .Where(recipe => recipe.HasIngredient(ItemID.Silk))
                .Where(recipe => recipe.HasIngredient(ItemID.Torch))
                .Where(recipe => recipe.HasResult(ItemID.MolotovCocktail))
                .FirstOrDefault();

            if (MolotovCocktailRecipe != null)
            {
                if (!MolotovCocktailRecipe.HasCondition(IsMolotovCocktailRecipeBuffNotEnabled)) 
                {
                    MolotovCocktailRecipe.AddCondition(IsMolotovCocktailRecipeBuffNotEnabled);
                }
            }

            Mod.CreateRecipe(ItemID.MolotovCocktail, 5).AddCondition(IsMolotovCocktailRecipeBuffEnabled).AddIngredient(ItemID.Ale, 5).AddIngredient(ItemID.Gel, 5).AddIngredient(ItemID.Silk, 1).AddIngredient(ItemID.Torch, 1).Register();
        }

        public override void Unload()
        {
            MolotovCocktailRecipe = null;
        }
    }
}