using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Linq;
using static ShardionsMod.Content.QoL.Recipes.QoLConditions;

namespace ShardionsMod.Content.QoL.Recipes
{
    public class ChlorophyteBarRecipeBuff : ModSystem
    {
        public static Recipe ChlorophyteBarRecipe;

        public override void AddRecipes() 
        {
            ChlorophyteBarRecipe = Main.recipe.Take(Recipe.numRecipes)
                .Where(recipe => recipe.HasIngredient(ItemID.ChlorophyteOre))
                .Where(recipe => recipe.HasTile(TileID.AdamantiteForge))
                .Where(recipe => recipe.HasResult(ItemID.ChlorophyteBar))
                .FirstOrDefault();

            if (ChlorophyteBarRecipe != null)
            {
                if (!ChlorophyteBarRecipe.HasCondition(IsChlorophyteBarRecipeBuffNotEnabled)) 
                {
                    ChlorophyteBarRecipe.AddCondition(IsChlorophyteBarRecipeBuffNotEnabled);
                }
            }

            Recipe.Create(ItemID.ChlorophyteBar).AddCondition(IsChlorophyteBarRecipeBuffEnabled).AddIngredient(ItemID.ChlorophyteOre, 4).AddTile(TileID.AdamantiteForge).Register();
        }

        public override void Unload()
        {
            ChlorophyteBarRecipe = null;
        }
    }
}