using Terraria.ModLoader;
using Terraria.ID;

namespace Persona5Cosplay.Items.Weapons.Agi
{
    public class Maragidyne : ModItem
    {

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Light Fire damage to multiple foes. Chance to burn.");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.knockBack = 3;
			item.crit = 12;
			item.useTime = 10;
			item.useAnimation = 10;
			item.mana = 6;
			item.rare = 7;

			item.magic = true;
			item.value = 30000;
			item.autoReuse = true;
			item.noMelee = true;
			item.width = 30;
			item.height = 30;
			item.useStyle = 1;
			item.noUseGraphic = true;

			item.shoot = ModContent.ProjectileType<Projectiles.Maragidyne>();
			item.shootSpeed = 8f;

			//TODO
			item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()
		{
			//TODO
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
