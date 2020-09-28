using Terraria.ID;
using Terraria.ModLoader;

namespace Cyberium.Items
{
	public class CPU : ModItem
	{
		public override void SetStaticDefaults() 
		{
			//DisplayName.SetDefault("Circuits"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The Bigger Brain");
		}

		public override void SetDefaults() 
		{
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("Circuit"),10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}