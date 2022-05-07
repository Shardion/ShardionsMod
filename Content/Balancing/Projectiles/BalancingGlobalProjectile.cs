using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ShardionsMod.Content.Balancing.Projectiles
{
	public class BalancingGlobalProjectile : GlobalProjectile
	{
        
        public override Color? GetAlpha(Projectile projectile, Color lightColor)
        {   
            if (projectile.type == ProjectileID.PinkLaser && ModContent.GetInstance<Utilities.BalancingConfig>().ProbeLaserGlow)
                return Color.White * projectile.Opacity;
            return base.GetAlpha(projectile, lightColor);
        }
    }
}