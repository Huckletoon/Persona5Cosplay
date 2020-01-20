using Terraria.ID;
using Terraria.ModLoader;

namespace Persona5Cosplay.Items
{
	public class RebelKnife : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("RebelKnife"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A knife with a hint of rebellious spirit");
		}

		public override void SetDefaults() 
		{
			item.damage = 14;
			item.crit = 40;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 5000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}