using Terraria.ID;
using Terraria.ModLoader;
using ShardionsMod.Utilities;

namespace ShardionsMod.Content.VV.Items.Vanity.Sophisticated
{
    [AutoloadEquip(EquipType.Legs)]
    public class SophisticatedStockings : ShardItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sophisticated Stockings");
            //Tooltip.SetDefault("'Not the best idea in this world'");
        }

        // this is a separate function so we don't have to redefine the entire setdefaults function each time
        //public virtual void SetVariantDefaults() { Variant = "White Banded"; FemaleLegsTexture = "SophisticatedStockings_FemaleLegs"; }

        public override void SetDefaults()
        {
            FemaleLegsTexture = "SophisticatedStockings_FemaleLegs";
            Developer = (int)DevIndex.Shardion;
            Item.width = 22;
            Item.height = 32;
            Item.value = 0;
            Item.rare = 0;
            Item.vanity = true;
            Item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            this.CreateRecipe()
                .AddCondition(Content.VV.Recipes.VVConditions.AreThreadRecipesEnabled)
                .AddIngredient(Mod, "Fabric", 3)
                .AddIngredient(Mod, "CyanThread", 1)
                .AddIngredient(Mod, "WhiteThread", 1)
                .AddTile(TileID.Loom)
                .Register();
            
            this.CreateRecipe()
                .AddCondition(Content.VV.Recipes.VVConditions.AreDyeRecipesEnabled)
                .AddIngredient(Mod, "Fabric", 3)
                .AddIngredient(ItemID.BrightSilverDye, 1)
                .AddIngredient(ItemID.CyanDye, 1)
                .AddTile(TileID.Loom)
                .Register();
            
            this.CreateRecipe()
                .AddCondition(Content.VV.Recipes.VVConditions.AreNoColorRecipesEnabled)
                .AddIngredient(Mod, "Fabric", 3)
                .AddTile(TileID.Loom)
                .Register();
        }
    }/* // nooooooooo mooooooooooore variants! i actually kinda liked the variety but whatever it got too difficult to maintain
    [AutoloadEquip(EquipType.Legs)]
    public class SophisticatedStockingsNoBand : SophisticatedStockings
    {
        public override void SetVariantDefaults() { Variant = "White"; FemaleLegsTexture = "SophisticatedStockingsNoBand_FemaleLegs"; }
        public override void AddRecipes() { AddVariantRecipe(ModContent.GetInstance<SophisticatedStockings>(), this); }
    }
    [AutoloadEquip(EquipType.Legs)]
    public class SophisticatedStockingsNoSuspenders : SophisticatedStockings
    {
        public override void SetVariantDefaults() { Variant = "White Banded (No Suspenders)"; FemaleLegsTexture = "SophisticatedStockingsNoSuspenders_FemaleLegs"; }
        public override void AddRecipes() { AddVariantRecipe(ModContent.GetInstance<SophisticatedStockings>(), this); }
    }
    [AutoloadEquip(EquipType.Legs)]
    public class SophisticatedStockingsNoBandNoSuspenders : SophisticatedStockings
    {
        public override void SetVariantDefaults() { Variant = "White (No Suspenders)"; FemaleLegsTexture = "SophisticatedStockingsNoBandNoSuspenders_FemaleLegs"; }
        public override void AddRecipes() { AddVariantRecipe(ModContent.GetInstance<SophisticatedStockingsNoBand>(), this); }
    }
    [AutoloadEquip(EquipType.Legs)]
    public class SophisticatedStockingsBlack : SophisticatedStockings
    {
        public override void SetVariantDefaults() { Variant = "Black"; FemaleLegsTexture = "SophisticatedStockingsBlack_FemaleLegs"; }
        public override void AddRecipes() { AddVariantRecipe(ModContent.GetInstance<SophisticatedStockings>(), this); }
    }
    [AutoloadEquip(EquipType.Legs)]
    public class SophisticatedStockingsBlackNoSuspenders : SophisticatedStockings
    {
        public override void SetVariantDefaults() { Variant = "Black (No Suspenders)"; FemaleLegsTexture = "SophisticatedStockingsBlackNoSuspenders_FemaleLegs"; }
        public override void AddRecipes() { AddVariantRecipe(ModContent.GetInstance<SophisticatedStockingsBlack>(), this); }
    }*/
}
