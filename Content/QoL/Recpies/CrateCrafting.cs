using Terraria.ModLoader;
using Terraria.ID;
using static ShardionsMod.Content.QoL.Recipes.QoLConditions;

namespace ShardionsMod.Content.QoL.Recipes
{
    public class CrateCrafting : ModSystem
    {
        public override void AddRecipes() 
        {
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
        }
    }
}
            