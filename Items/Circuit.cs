using Terraria.ID;
using Terraria.ModLoader;

namespace Cyberium.Items
{
	public class Circuit : ModItem
	{
		public override void SetStaticDefaults() 
		{
			//DisplayName.SetDefault("Circuits"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The Brain of all");
		}

		public override void SetDefaults() 
		{
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddIngredient(ItemID.Lens, 1);
			recipe.AddIngredient(ItemID.GoldBar,1);
            recipe.AddIngredient(ItemID.CopperBar,5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}