using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;
using static ShardionsMod.Content.VV.Recipes.VVConditions;

namespace ShardionsMod.Content.VV.Recipes
{
    public class VanillaThreadRecipeReplacer : ModSystem
    {
        public static Recipe GreenThreadRecipe;
        
        public override void AddRecipes() 
        {
            GreenThreadRecipe = Main.recipe.Take(Recipe.numRecipes)
                .Where(recipe => recipe.HasIngredient(ItemID.JungleGrassSeeds))
                .Where(recipe => recipe.HasTile(TileID.Loom))
                .Where(recipe => recipe.HasResult(ItemID.GreenThread))
                .FirstOrDefault();

            if (GreenThreadRecipe != null)
            {
                if (!GreenThreadRecipe.HasCondition(IsVVNotEnabled)) 
                {
                    GreenThreadRecipe.AddCondition(IsVVNotEnabled);
                }
            }

            int[,] vanillaThreads = {
                {ItemID.GreenThread, ItemID.GreenDye},
                {ItemID.BlackThread, ItemID.BlackDye},
                {ItemID.PinkThread, ItemID.PinkDye}
            };

            for (int i = 0; i < 3; i++)
            {
                Recipe.Create(vanillaThreads[i, 0], 3)
                .AddCondition(IsVVEnabled)
                .AddIngredient(Mod, "WhiteThread", 3)
                .AddIngredient(vanillaThreads[i, 1], 1)
                .AddTile(TileID.Loom)
                .Register();

                Recipe.Create(vanillaThreads[i, 0], 6)
                .AddCondition(IsVVEnabled)
                .AddIngredient(Mod, "WhiteThread", 6)
                .AddIngredient(vanillaThreads[i, 1], 1)
                .AddTile(TileID.Loom)
                .Register();
            }
        }

        public override void Unload() {
            if (GreenThreadRecipe != null)
            {
                if (GreenThreadRecipe.HasCondition(IsVVNotEnabled)) 
                {
                    GreenThreadRecipe.RemoveCondition(IsVVNotEnabled);
                }
            }
            GreenThreadRecipe = null;
        }
    }
}
