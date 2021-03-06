using Terraria.ID;
using Terraria.ModLoader;

namespace Cyberium.Items
{
	public class Motor : ModItem
	{
		public override void SetStaticDefaults() 
		{
			//DisplayName.SetDefault("Circuits"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Feel the Speeeeeed");
		}

		public override void SetDefaults() 
		{
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 2);
            recipe.AddIngredient(ItemID.CopperBar,1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}