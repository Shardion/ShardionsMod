using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Linq;
using static ShardionsMod.Content.Balancing.Recipes.BalancingConditions;

namespace ShardionsMod.Content.Balancing.Recipes
{
    public class MagiluminescenceRecipeNerf : ModSystem
    {
        public static Recipe MagiluminescenceCorruptionRecipe;
        public static Recipe MagiluminescenceCrimsonRecipe;
        
        public override void AddRecipes() 
        {

            MagiluminescenceCorruptionRecipe = Main.recipe.Take(Recipe.numRecipes)
                .Where(recipe => recipe.HasIngredient(ItemID.Topaz))
                .Where(recipe => recipe.HasIngredient(ItemID.DemoniteBar))
                .Where(recipe => recipe.HasTile(TileID.Anvils))
                .Where(recipe => recipe.HasResult(ItemID.Magiluminescence))
                .FirstOrDefault();

            if (MagiluminescenceCorruptionRecipe != null)
            {
                if (!MagiluminescenceCorruptionRecipe.HasCondition(IsMagiluminescenceRecipeNerfNotEnabled)) 
                {
                    MagiluminescenceCorruptionRecipe.AddCondition(IsMagiluminescenceRecipeNerfNotEnabled);
                }
            }

            MagiluminescenceCrimsonRecipe = Main.recipe.Take(Recipe.numRecipes)
                .Where(recipe => recipe.HasIngredient(ItemID.Topaz))
                .Where(recipe => recipe.HasIngredient(ItemID.CrimtaneBar))
                .Where(recipe => recipe.HasTile(TileID.Anvils))
                .Where(recipe => recipe.HasResult(ItemID.Magiluminescence))
                .FirstOrDefault();

            if (MagiluminescenceCrimsonRecipe != null)
            {
                if (!MagiluminescenceCrimsonRecipe.HasCondition(IsMagiluminescenceRecipeNerfNotEnabled)) 
                {
                    MagiluminescenceCrimsonRecipe.AddCondition(IsMagiluminescenceRecipeNerfNotEnabled);
                }
            }

            Mod.CreateRecipe(ItemID.Magiluminescence).AddCondition(IsMagiluminescenceRecipeNerfEnabled).AddIngredient(ItemID.Topaz, 5).AddIngredient(ItemID.DemoniteBar, 12).AddIngredient(ItemID.ShadowScale, 4).AddTile(TileID.Anvils).Register();
            Mod.CreateRecipe(ItemID.Magiluminescence).AddCondition(IsMagiluminescenceRecipeNerfEnabled).AddIngredient(ItemID.Topaz, 5).AddIngredient(ItemID.CrimtaneBar, 12).AddIngredient(ItemID.TissueSample, 4).AddTile(TileID.Anvils).Register();
        }

        public override void Unload()
        {
            MagiluminescenceCorruptionRecipe = null;
            MagiluminescenceCrimsonRecipe = null;
        }
    }
}