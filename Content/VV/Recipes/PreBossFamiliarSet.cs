using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static ShardionsMod.Content.VV.Recipes.VVConditions;

namespace ShardionsMod.Content.VV.Recipes {
    public class PreBossFamiliarSet : ModSystem {
        public override void AddRecipes()
        {
            Recipe.Create(ItemID.FamiliarWig)
                .AddCondition(IsPreBossFamiliarSetEnabled)
                .AddIngredient(Mod, "Fabric", 2)
                .AddIngredient(ItemID.ManaCrystal)
                .AddTile(TileID.Loom)
                .Register();
            
            Recipe.Create(ItemID.FamiliarShirt)
                .AddCondition(IsPreBossFamiliarSetEnabled)
                .AddIngredient(Mod, "Fabric", 4)
                .AddIngredient(ItemID.ManaCrystal)
                .AddTile(TileID.Loom)
                .Register();
            
            Recipe.Create(ItemID.FamiliarPants)
                .AddCondition(IsPreBossFamiliarSetEnabled)
                .AddIngredient(Mod, "Fabric", 3)
                .AddIngredient(ItemID.ManaCrystal)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}