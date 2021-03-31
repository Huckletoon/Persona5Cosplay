using Terraria.ModLoader;
using Terraria.ID;

namespace Persona5Cosplay.Items.Weapons.Agi
{
    public class BlazingHell : ModItem
    {

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Medium Fire damage to multiple foes. Chance to burn.");
		}

		public override void SetDefaults()
		{
			item.damage = 85;
			item.knockBack = 5;
			item.crit = 18;
			item.useTime = 10;
			item.useAnimation = 10;
			item.mana = 8;
			item.rare = 10;

			item.magic = true;
			item.value = 40000;
			item.autoReuse = true;
			item.noMelee = true;
			item.width = 35;
			item.height = 35;
			item.useStyle = 1;
			item.noUseGraphic = true;

			item.shoot = ModContent.ProjectileType<Projectiles.BlazingHell>();
			item.shootSpeed = 8f;

			//TODO
			item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Persona5Cosplay:CobaltBars", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
