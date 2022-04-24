using Terraria.ModLoader;
using Terraria.Localization;
using static Terraria.Recipe;

namespace ShardionsMod.Content.Balancing.Recipes
{
    public class BalancingConditions : ModSystem
    {
        public static readonly Condition IsBalancingEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsBalancingEnabled"), _ => ModContent.GetInstance<Utilities.BalancingConfig>().BalancingModuleEnabled);
        public static readonly Condition IsBalancingNotEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsBalancingNotEnabled"), _ => !ModContent.GetInstance<Utilities.BalancingConfig>().BalancingModuleEnabled);
        public static readonly Condition IsMolotovCocktailRecipeBuffEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsMolotovCocktailRecipeBuffEnabled"), _ => ModContent.GetInstance<Utilities.BalancingConfig>().MolotovRecipeBuff);
        public static readonly Condition IsMolotovCocktailRecipeBuffNotEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsMolotovCocktailRecipeBuffNotEnabled"), _ => !ModContent.GetInstance<Utilities.BalancingConfig>().MolotovRecipeBuff);
        public static readonly Condition IsMagiluminescenceRecipeNerfEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsMagiluminescenceRecipeNerfEnabled"), _ => ModContent.GetInstance<Utilities.BalancingConfig>().MagiluminescenceRecipeNerf);
        public static readonly Condition IsMagiluminescenceRecipeNerfNotEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsMagiluminescenceRecipeNerfNotEnabled"), _ => !ModContent.GetInstance<Utilities.BalancingConfig>().MagiluminescenceRecipeNerf);
        public static readonly Condition IsTerrasparkBootsRecipeNerfEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsTerrasparkBootsRecipeNerfEnabled"), _ => ModContent.GetInstance<Utilities.BalancingConfig>().TerrasparkBootsRecipeNerf);
        public static readonly Condition IsTerrasparkBootsRecipeNerfNotEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsTerrasparkBootsRecipeNerfNotEnabled"), _ => !ModContent.GetInstance<Utilities.BalancingConfig>().TerrasparkBootsRecipeNerf);
    }
}