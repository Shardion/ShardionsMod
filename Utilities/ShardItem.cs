using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.ID;

namespace ShardionsMod.Utilities
{
    public abstract class ShardItem : ModItem
    {
        public enum DevIndex
        {
            Shardion
        }

        // We have a separate assets folder to keep the code clean and separated from the assets
        // As a side effect, this also enforces that items are always content
        public override string Texture => this.GetType().ToString().Replace(".", "/").Replace("Content", "Assets");

        public static readonly string[,] Developers = new string[,] { { "shardion", "00FFEE" } };

        public string FemaleLegsTexture;

        public int Developer = -1;

        public string Variant;

        public virtual void VVModifyTooltips(List<TooltipLine> tooltips) { }

        public sealed override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            VVModifyTooltips(tooltips);
            if (Developer != -1)
                tooltips.Add(new TooltipLine(Mod, "Developer Item Of", "[c/" + Developers[(int)Developer, 1] + ":Developer item: " + Developers[(int)Developer, 0] + "]"));
            if (Variant != null)
            {
                tooltips.Add(new TooltipLine(Mod, "Item Variant", "Variant: " + Variant));
            }
        }

        public virtual void VVSetMatch(bool male, ref int equipSlot, ref bool robes) { }

        // Commented until Iban's AddEquipTexture fix is in 1.4-preview
        /*public sealed override void SetMatch(bool male, ref int equipSlot, ref bool robes)
        {
            VVSetMatch(male, ref equipSlot, ref robes);
            if (!male && FemaleLegsTexture != null)
            {
                equipSlot = Mod.GetEquipSlot(FemaleLegsTexture, EquipType.Legs);
            }
        }*/

        public void AddVariantRecipe(ModItem from, ModItem variant)
        {
            variant.CreateRecipe()
                .AddIngredient(from)
                .AddTile(TileID.Loom)
                .Register();
            from.CreateRecipe()
                .AddIngredient(variant)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
