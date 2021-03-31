using Terraria.ModLoader;
using Terraria.ID;

namespace Persona5Cosplay.Items.Weapons.Agi
{
    public class Maragi : ModItem
    {

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Light Fire damage to multiple foes. Chance to burn.");
		}

		public override void SetDefaults()
		{
			item.damage = 18;
			item.knockBack = 2;
			item.crit = 10;
			item.useTime = 16;
			item.useAnimation = 16;
			item.mana = 2;
			item.rare = 2;

			item.magic = true;
			item.value = 10000;
			item.autoReuse = true;
			item.noMelee = true;
			item.width = 5;
			item.height = 5;
			item.useStyle = 1;
			item.noUseGraphic = true;

			item.shoot = ModContent.ProjectileType<Projectiles.Maragi>();
			item.shootSpeed = 8f;

			//TODO
			item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
