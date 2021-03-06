using Terraria.ModLoader;
using Terraria.Localization;
using static Terraria.Recipe;

namespace ShardionsMod.Content.QoL.Recipes
{
    public class QoLConditions : ModSystem
    {
        public static readonly Condition IsQoLEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsQoLEnabled"), _ => ModContent.GetInstance<Utilities.QoLConfig>().QoLModuleEnabled);
        public static readonly Condition IsQoLNotEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsQoLNotEnabled"), _ => !ModContent.GetInstance<Utilities.QoLConfig>().QoLModuleEnabled);
        public static readonly Condition IsCrateCraftingEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsCrateCraftingEnabled"), _ => ModContent.GetInstance<Utilities.QoLConfig>().QoLModuleEnabled && ModContent.GetInstance<Utilities.QoLConfig>().CrateCrafting);
        public static readonly Condition IsGemCraftingEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsGemCraftingEnabled"), _ => ModContent.GetInstance<Utilities.QoLConfig>().QoLModuleEnabled && ModContent.GetInstance<Utilities.QoLConfig>().GemCrafting);
        public static readonly Condition IsDiscountCookieEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsDiscountCookieEnabled"), _ => ModContent.GetInstance<Utilities.QoLConfig>().DiscountCookie);
        public static readonly Condition IsChlorophyteBarRecipeBuffEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsChlorophyteBarRecipeBuffEnabled"), _ => ModContent.GetInstance<Utilities.QoLConfig>().ChlorophyteBarRecipeBuff);
        public static readonly Condition IsChlorophyteBarRecipeBuffNotEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsChlorophyteBarRecipeBuffNotEnabled"), _ => !ModContent.GetInstance<Utilities.QoLConfig>().ChlorophyteBarRecipeBuff);
    }
}