using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod
{
	public class crazyDiamond : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("English Display Name Here");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			aiType = ProjectileID.CultistBossFireBall;
		}

		// Additional hooks/methods here.
	}
}