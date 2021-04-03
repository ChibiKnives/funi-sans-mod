using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items
{
    public class CrazyHamburger : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Crazy Hamburger");
			Tooltip.SetDefault("CCCCCCCCCCRAZZY HAMBURGER, CCCCCCCCCCCCCCCCCCCCCCCRAZY HAMMMMMMBURGERRRRRRRRRRRRRR!!!!!! MY GOD, THIS IS HORRIBLE!!!!!! AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
		}

		public override void SetDefaults() 
		{

			item.damage = 100;
			item.ranged = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 50;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.noMelee = false;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item2;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("crazyDiamond");
			item.shootSpeed = 12f;
			item.useAmmo = ModContent.ItemType<CrazyAmmo>();

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}