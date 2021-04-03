using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items
{
    public class travisScottMeal : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Travis Scott Meal");
			Tooltip.SetDefault("Travis Scott Burger");
		}

		public override void SetDefaults() 
		{

			item.damage = 200;
			item.ranged = true;
			item.width = 10;
			item.height = 10;
			item.useTime = 50;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.noMelee = false;
			item.knockBack = 6;
			item.value = 100000000;
			item.rare = 11;
			item.UseSound = SoundID.Item2;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("travisScottShot");
			item.shootSpeed = 15f;
			item.useAmmo = ModContent.ItemType<travisScottShot>();

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