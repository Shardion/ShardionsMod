using Terraria.ModLoader;

namespace ShardionsMod.Utilities
{
    public abstract class ShardProj : ModProjectile
    {
        // this class exclusively exists to enforce custom assets folder for projectiles
        public override string Texture => this.GetType().ToString().Replace(".", "/").Replace("Content", "Assets");
    }
}