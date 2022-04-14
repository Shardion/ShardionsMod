using Terraria.ModLoader;

namespace ShardionsMod.Utilities
{
    public abstract class ShardProj : ModProjectile
    {
        public override string Texture => UsePlaceholderSprite ? "ShardionsMod/Assets/ShardPlaceholder" : this.GetType().ToString().Replace(".", "/").Replace("Content", "Assets");
        public bool UsePlaceholderSprite = false;
    }
}