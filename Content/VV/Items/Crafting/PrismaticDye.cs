using Terraria.ModLoader;
using Terraria.ID;
using ShardionsMod.Utilities;

namespace ShardionsMod.Content.VV.Items.Crafting
{
    public class PrismaticDye : ShardItem
    {
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 32;
            Item.value = 0;
            Item.rare = 0;
            Item.maxStack = 9999;
        }

        public override void AddRecipes()
        {
            this.CreateRecipe()
                .AddCondition(ShardRecipeHandler.IsVVEnabled)
                .AddRecipeGroup("VariousVanities:StrangeDyes", 3)
                .AddTile(TileID.DyeVat)
                .Register();

            int[] dyes = new int[]
            {
                ItemID.RedDye,
                ItemID.OrangeDye,
                ItemID.YellowDye,
                ItemID.LimeDye,
                ItemID.GreenDye,
                ItemID.TealDye,
                ItemID.CyanDye,
                ItemID.SkyBlueDye,
                ItemID.BlueDye,
                ItemID.PurpleDye,
                ItemID.VioletDye,
                ItemID.PinkDye,
                ItemID.BlackDye,
                ItemID.BrownDye,
                ItemID.SilverDye
            };

            foreach (int dye in dyes)
            {
                Mod.CreateRecipe(dye)
                    .AddCondition(ShardRecipeHandler.IsVVEnabled)
                    .AddIngredient(this, 1)
                    .AddTile(TileID.DyeVat)
                    .Register();
            }
        }
    }
}
