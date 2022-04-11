using Terraria.ModLoader;
using Terraria.Localization;
using static Terraria.Recipe;

namespace ShardionsMod.Content.VV.Recipes
{
    public class VVConditions : ModSystem
    {
        public static readonly Condition IsVVEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsVVNotEnabled"), _ => ModContent.GetInstance<Utilities.VariousVanitiesConfig>().VariousVanitiesEnabled);
        public static readonly Condition IsVVNotEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsVVEnabled"), _ => !ModContent.GetInstance<Utilities.VariousVanitiesConfig>().VariousVanitiesEnabled);
        public static readonly Condition AreThreadRecipesEnabled = new Condition(NetworkText.FromKey("RecipeConditions.AreThreadRecipesEnabled"), _ => ModContent.GetInstance<Utilities.VariousVanitiesConfig>().DoDyedThreads && ModContent.GetInstance<Utilities.VariousVanitiesConfig>().VariousVanitiesEnabled);
        public static readonly Condition AreDyeRecipesEnabled = new Condition(NetworkText.FromKey("RecipeConditions.AreDyeRecipesEnabled"), _ => ModContent.GetInstance<Utilities.VariousVanitiesConfig>().DoDyes && ModContent.GetInstance<Utilities.VariousVanitiesConfig>().VariousVanitiesEnabled);
        public static readonly Condition AreNoColorRecipesEnabled = new Condition(NetworkText.FromKey("RecipeConditions.AreNoColorRecipesEnabled"), _ => ModContent.GetInstance<Utilities.VariousVanitiesConfig>().DoNone && ModContent.GetInstance<Utilities.VariousVanitiesConfig>().VariousVanitiesEnabled);
    }
}