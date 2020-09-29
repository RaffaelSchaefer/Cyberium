using Terraria.ID;
using Terraria.ModLoader;

namespace Cyberium.Items
{
	public class Laser_Gun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Laser Gun"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Its Power Level are over 9000");
		}

		public override void SetDefaults() 
		{
            item.damage = 50;  
            item.noMelee = true;  
            item.noUseGraphic = false;
            item.magic = true;    //This defines if it does magic damage and if its effected by magic increasing Armor/Accessories.
            item.channel = true;                            //Channel so that you can held the weapon
            item.mana = 1; //How mutch mana this weapon use
            item.rare = 5;   //The color the title of your Weapon when hovering over it ingame
            item.width = 28;   //The size of the width of the hitbox in pixels.
            item.height = 30;    //The size of the height of the hitbox in pixels.
            item.useTime = 1;   //How fast the Weapon is used.
            item.UseSound = SoundID.Item13;  //The sound played when using your Weapon
            item.useStyle = 5;   //The way your Weapon will be used, 5 is the Holding Out Used for: Guns, Spellbooks, Drills, Chainsaws, Flails, Spears for example
            item.shootSpeed = 1f;       //This defines the projectile speed when shoot
            item.useAnimation = 7;                         //Speed is not important here
            item.shoot = mod.ProjectileType("Laser_beam");  //This defines what type of projectile this weapon will shoot   
            item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("Circuit"),8);
            recipe.AddIngredient(mod.GetItem("CPU"),1);
            recipe.AddIngredient(mod.GetItem("Cable"),8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}