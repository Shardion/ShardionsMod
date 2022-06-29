using Terraria;
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
                
                Recipe.Create(ItemID.GoldenCrate)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(crate)
                    .AddTile(TileID.TinkerersWorkbench)
                    .Register();
                Recipe.Create(crate)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.GoldenCrate)
                    .AddTile(TileID.TinkerersWorkbench)
                    .Register();
            }
            foreach (int crate in hmBiomeCrates) {
                Recipe.Create(ItemID.GoldenCrateHard)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(crate)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
                Recipe.Create(crate)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.GoldenCrateHard)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
            }
            // upgrades
            Recipe.Create(ItemID.IronCrate)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.WoodenCrate, 5)
                    .AddTile(TileID.TinkerersWorkbench)
                    .Register();
            Recipe.Create(ItemID.GoldenCrate)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.IronCrate, 5)
                    .AddTile(TileID.TinkerersWorkbench)
                    .Register();
            Recipe.Create(ItemID.IronCrateHard)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.WoodenCrateHard, 5)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
            Recipe.Create(ItemID.GoldenCrateHard)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.IronCrateHard, 5)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
            // downgrades
            Recipe.Create(ItemID.WoodenCrate, 2)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.IronCrate)
                    .AddTile(TileID.TinkerersWorkbench)
                    .Register();
            Recipe.Create(ItemID.IronCrate, 2)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.GoldenCrate)
                    .AddTile(TileID.TinkerersWorkbench)
                    .Register();
            Recipe.Create(ItemID.WoodenCrateHard, 2)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.IronCrateHard)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
            Recipe.Create(ItemID.IronCrateHard, 2)
                    .AddCondition(IsCrateCraftingEnabled)
                    .AddIngredient(ItemID.GoldenCrateHard)
                    .AddTile(TileID.MythrilAnvil)
                    .Register();
        }
    }
}
            