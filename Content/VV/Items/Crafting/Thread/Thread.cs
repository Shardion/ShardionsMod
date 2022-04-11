using Terraria.ID;
using Terraria.ModLoader;
using ShardionsMod.Utilities;

namespace ShardionsMod.Content.VV.Items.Crafting.Thread
{
    public class WhiteThread : ShardItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 20;
            Item.value = 0;
            Item.rare = 0;
            Item.maxStack = 9999;
        }

        public override void AddRecipes()
        {
            this.CreateRecipe(2)
                .AddCondition(Content.VV.Recipes.VVConditions.IsVVEnabled)
                .AddRecipeGroup("Wood", 1)
                .AddIngredient(ItemID.Cobweb, 4)
                .AddTile(TileID.Loom)
                .Register();
        }

        public void AddThreadRecipes(int dye, ModItem thread)
        {
            this.CreateRecipe(3)
                .AddIngredient(dye, 1)
                .AddIngredient(Mod, "WhiteThread", 3)
                .AddTile(TileID.Loom)
                .Register();
            
            this.CreateRecipe(6)
                .AddIngredient(dye, 1)
                .AddIngredient(Mod, "WhiteThread", 6)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
    public class RedThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.RedDye, this); } }
    public class OrangeThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.OrangeDye, this); } }
    public class YellowThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.YellowDye, this); } }
    public class LimeThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.LimeDye, this); } }
    // has vanilla thread //public class GreenThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.GreenDye, this); } }
    public class TealThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.TealDye, this); } }
    public class CyanThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.CyanDye, this); } }
    public class SkyBlueThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.SkyBlueDye, this); } }
    public class BlueThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.BlueDye, this); } }
    public class PurpleThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.PurpleDye, this); } }
    public class VioletThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.VioletDye, this); } }
    // has vanilla thread //public class PinkThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.PinkDye, this); } }
    // has vanilla thread //public class BlackThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.BlackDye, this); } }
    public class BrownThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.BrownDye, this); } }
    public class SilverThread : WhiteThread { public override void AddRecipes() { AddThreadRecipes(ItemID.SilverDye, this); } }
}
