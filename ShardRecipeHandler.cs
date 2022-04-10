using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using Terraria.ID;
using System.Linq;
using static Terraria.Recipe;

namespace ShardionsMod.Utilities
{
    // TODO: This should really, really be broken into separate files with how large it's gotten
    public class ShardRecipeHandler : ModSystem
    {
        #region Recipe Groups
        public static RecipeGroup StrangeDyes;
        public static Recipe GreenThreadRecipe;
        public static Recipe MolotovCocktailRecipe;
        public static Recipe MagiluminescenceCorruptionRecipe;
        public static Recipe MagiluminescenceCrimsonRecipe;
        public override void AddRecipeGroups()
        {
            StrangeDyes = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Strange Dye", new int[]
            {
                ItemID.AcidDye,
                ItemID.BlueAcidDye,
                ItemID.RedAcidDye,
                ItemID.ChlorophyteDye,
                ItemID.GelDye,
                ItemID.MushroomDye, // Glowing Mushroom Dye
                ItemID.GrimDye,
                ItemID.HadesDye,
                ItemID.BurningHadesDye,
                ItemID.ShadowflameHadesDye,
                ItemID.LivingOceanDye,
                ItemID.LivingFlameDye,
                ItemID.LivingRainbowDye,
                ItemID.MartianArmorDye, // Martian Dye
                ItemID.MidnightRainbowDye,
                ItemID.MirageDye,
                ItemID.NegativeDye,
                ItemID.PixieDye,
                ItemID.PhaseDye,
                ItemID.PurpleOozeDye,
                ItemID.ReflectiveDye,
                ItemID.ReflectiveCopperDye,
                ItemID.ReflectiveGoldDye,
                ItemID.ReflectiveObsidianDye,
                ItemID.ReflectiveMetalDye,
                ItemID.ReflectiveSilverDye,
                ItemID.ShadowDye,
                ItemID.ShiftingSandsDye,
                ItemID.DevDye, // Skiphs' Blood
                ItemID.TwilightDye,
                ItemID.WispDye,
                ItemID.InfernalWispDye,
                ItemID.UnicornWispDye
            });
            RecipeGroup.RegisterGroup("VariousVanities:StrangeDyes", StrangeDyes);
        }
        #endregion Recipe Groups

        #region Recipe Conditions
        public static readonly Condition IsVVEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsVVNotEnabled"), _ => ModContent.GetInstance<VariousVanitiesConfig>().VariousVanitiesEnabled);
        public static readonly Condition IsVVNotEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsVVEnabled"), _ => !ModContent.GetInstance<VariousVanitiesConfig>().VariousVanitiesEnabled);
        public static readonly Condition AreThreadRecipesEnabled = new Condition(NetworkText.FromKey("RecipeConditions.AreThreadRecipesEnabled"), _ => ModContent.GetInstance<VariousVanitiesConfig>().DoDyedThreads && ModContent.GetInstance<VariousVanitiesConfig>().VariousVanitiesEnabled);
        public static readonly Condition AreDyeRecipesEnabled = new Condition(NetworkText.FromKey("RecipeConditions.AreDyeRecipesEnabled"), _ => ModContent.GetInstance<VariousVanitiesConfig>().DoDyes && ModContent.GetInstance<VariousVanitiesConfig>().VariousVanitiesEnabled);
        public static readonly Condition AreNoColorRecipesEnabled = new Condition(NetworkText.FromKey("RecipeConditions.AreNoColorRecipesEnabled"), _ => ModContent.GetInstance<VariousVanitiesConfig>().DoNone && ModContent.GetInstance<VariousVanitiesConfig>().VariousVanitiesEnabled);

        public static readonly Condition IsQoLEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsQoLEnabled"), _ => ModContent.GetInstance<QoLConfig>().QoLModuleEnabled);
        public static readonly Condition IsQoLNotEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsQoLNotEnabled"), _ => !ModContent.GetInstance<QoLConfig>().QoLModuleEnabled);
        public static readonly Condition IsCrateCraftingEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsCrateCraftingEnabled"), _ => ModContent.GetInstance<QoLConfig>().CrateCrafting);
        public static readonly Condition IsGemCraftingEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsGemCraftingEnabled"), _ => ModContent.GetInstance<QoLConfig>().GemCrafting);

        public static readonly Condition IsBalancingEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsBalancingEnabled"), _ => ModContent.GetInstance<BalancingConfig>().BalancingModuleEnabled);
        public static readonly Condition IsBalancingNotEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsBalancingNotEnabled"), _ => !ModContent.GetInstance<BalancingConfig>().BalancingModuleEnabled);
        public static readonly Condition IsMolotovCocktailRecipeBuffEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsMolotovCocktailRecipeBuffEnabled"), _ => ModContent.GetInstance<BalancingConfig>().MolotovRecipeBuff);
        public static readonly Condition IsMolotovCocktailRecipeBuffNotEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsMolotovCocktailRecipeBuffNotEnabled"), _ => !ModContent.GetInstance<BalancingConfig>().MolotovRecipeBuff);
        public static readonly Condition IsMagiluminescenseRecipeNerfEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsMagiluminescenseRecipeNerfEnabled"), _ => ModContent.GetInstance<BalancingConfig>().MagiluminescenceRecipeNerf);
        public static readonly Condition IsMagiluminescenseRecipeNerfNotEnabled = new Condition(NetworkText.FromKey("RecipeConditions.IsMagiluminescenseRecipeNerfNotEnabled"), _ => !ModContent.GetInstance<BalancingConfig>().MagiluminescenceRecipeNerf);


        #endregion Recipe Conditions

        #region Vanilla Recipe Replacement
        public override void AddRecipes()
        {
            #region VV Thread recipes
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
                Mod.CreateRecipe(vanillaThreads[i, 0], 3)
                .AddCondition(IsVVEnabled)
                .AddIngredient(Mod, "WhiteThread", 3)
                .AddIngredient(vanillaThreads[i, 1], 1)
                .AddTile(TileID.Loom)
                .Register();

                Mod.CreateRecipe(vanillaThreads[i, 0], 6)
                .AddCondition(IsVVEnabled)
                .AddIngredient(Mod, "WhiteThread", 6)
                .AddIngredient(vanillaThreads[i, 1], 1)
                .AddTile(TileID.Loom)
                .Register();
            }
            #endregion VV Thread recipes

            #region QoL recipe changes
            int[] prehmBiomeCrates = {
                ItemID.CorruptFishingCrate,
                ItemID.CrimsonFishingCrate,
                ItemID.FloatingIslandFishingCrate,
                ItemID.JungleFishingCrate,
                ItemID.FrozenCrate,
                ItemID.DungeonFishingCrate,
                ItemID.OasisCrate,
                ItemID.OceanCrate,
                ItemID.LavaCrate,
                ItemID.HallowedFishingCrate
            };
            int[] hmBiomeCrates = {
                ItemID.CorruptFishingCrateHard,
                ItemID.CrimsonFishingCrateHard,
                ItemID.FloatingIslandFishingCrateHard,
                ItemID.JungleFishingCrateHard,
                ItemID.FrozenCrateHard,
                ItemID.DungeonFishingCrateHard,
                ItemID.OasisCrateHard,
                ItemID.OceanCrateHard,
                ItemID.LavaCrateHard,
                ItemID.HallowedFishingCrateHard
            };
            foreach (int crate in prehmBiomeCrates) {
                Mod.CreateRecipe(ItemID.GoldenCrate)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(crate)
                    .AddTile(TileID.TinkerersWorkbench)
                    .Register();
                Mod.CreateRecipe(crate)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.GoldenCrate)
                    .AddTile(TileID.TinkerersWorkbench)
                    .Register();
            }
            foreach (int crate in hmBiomeCrates) {
                Mod.CreateRecipe(ItemID.GoldenCrateHard)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(crate)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
                Mod.CreateRecipe(crate)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.GoldenCrateHard)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
            }
            // upgrades
            Mod.CreateRecipe(ItemID.IronCrate)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.WoodenCrate, 5)
                    .AddTile(TileID.TinkerersWorkbench)
                    .Register();
            Mod.CreateRecipe(ItemID.GoldenCrate)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.IronCrate, 5)
                    .AddTile(TileID.TinkerersWorkbench)
                    .Register();
            Mod.CreateRecipe(ItemID.IronCrateHard)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.WoodenCrateHard, 5)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
            Mod.CreateRecipe(ItemID.GoldenCrateHard)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.IronCrateHard, 5)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
            // downgrades
            Mod.CreateRecipe(ItemID.WoodenCrate, 2)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.IronCrate)
                    .AddTile(TileID.TinkerersWorkbench)
                    .Register();
            Mod.CreateRecipe(ItemID.IronCrate, 2)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.GoldenCrate)
                    .AddTile(TileID.TinkerersWorkbench)
                    .Register();
            Mod.CreateRecipe(ItemID.WoodenCrateHard, 2)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.IronCrateHard)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
            Mod.CreateRecipe(ItemID.IronCrateHard, 2)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.GoldenCrateHard)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
            
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
            #endregion QoL recipe changes

            #region Balancing recipe changes
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

            MagiluminescenceCorruptionRecipe = Main.recipe.Take(Recipe.numRecipes)
                .Where(recipe => recipe.HasIngredient(ItemID.Topaz))
                .Where(recipe => recipe.HasIngredient(ItemID.DemoniteBar))
                .Where(recipe => recipe.HasTile(TileID.Anvils))
                .Where(recipe => recipe.HasResult(ItemID.Magiluminescence))
                .FirstOrDefault();

            if (MagiluminescenceCorruptionRecipe != null)
            {
                if (!MagiluminescenceCorruptionRecipe.HasCondition(IsMagiluminescenseRecipeNerfNotEnabled)) 
                {
                    MagiluminescenceCorruptionRecipe.AddCondition(IsMagiluminescenseRecipeNerfNotEnabled);
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
                if (!MagiluminescenceCrimsonRecipe.HasCondition(IsMagiluminescenseRecipeNerfNotEnabled)) 
                {
                    MagiluminescenceCrimsonRecipe.AddCondition(IsMagiluminescenseRecipeNerfNotEnabled);
                }
            }

            Mod.CreateRecipe(ItemID.MolotovCocktail, 5).AddCondition(IsMolotovCocktailRecipeBuffEnabled).AddIngredient(ItemID.Ale, 5).AddIngredient(ItemID.Gel, 5).AddIngredient(ItemID.Silk, 1).AddIngredient(ItemID.Torch, 1).Register();
            Mod.CreateRecipe(ItemID.Magiluminescence).AddCondition(IsMagiluminescenseRecipeNerfEnabled).AddIngredient(ItemID.Topaz, 5).AddIngredient(ItemID.DemoniteBar, 12).AddIngredient(ItemID.ShadowScale, 4).AddTile(TileID.Anvils).Register();
            Mod.CreateRecipe(ItemID.Magiluminescence).AddCondition(IsMagiluminescenseRecipeNerfEnabled).AddIngredient(ItemID.Topaz, 5).AddIngredient(ItemID.CrimtaneBar, 12).AddIngredient(ItemID.TissueSample, 4).AddTile(TileID.Anvils).Register();
            #endregion Balancing recipe changes
        }
        #endregion Vanilla Recipe Replacement

        public override void Unload() {
            StrangeDyes = null;
            
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