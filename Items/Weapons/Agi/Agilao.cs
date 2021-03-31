using Terraria.ModLoader;
using Terraria.ID;

namespace Persona5Cosplay.Items.Weapons.Agi
{
    public class Agilao : ModItem
    {

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Medium Fire damage to 1 foe. Chance to burn.");
		}

		public override void SetDefaults()
		{
			item.damage = 40;
			item.knockBack = 4;
			item.crit = 16;
			item.useTime = 20;
			item.useAnimation = 20;
			item.mana = 3;
			item.rare = 3;

			item.magic = true;
			item.value = 15000;
			item.autoReuse = true;
			item.noMelee = true;
			item.width = 5;
			item.height = 5;
			item.useStyle = 1;
			item.noUseGraphic = true;

			item.shoot = ModContent.ProjectileType<Projectiles.Agilao>();
			item.shootSpeed = 8f;

			//TODO
			item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 15);
			recipe.AddRecipeGroup("Persona5Cosplay:EvilChunks", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
