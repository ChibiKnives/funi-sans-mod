using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items
{
    public class travisScottShot : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Travis Scott Shot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Travis Scott is too powerful for tml confirmed !!!");
		}

		public override void SetDefaults() 
		{

			item.damage = 10;
			item.ranged = true;
			item.width = 14;
			item.height = 14;
			item.knockBack = 6;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 100000;
			item.rare = ItemRarityID.Yellow;
			item.shoot = mod.ProjectileType("travisScottShot");
			item.ammo = item.type;

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