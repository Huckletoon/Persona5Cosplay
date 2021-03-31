using Terraria.ModLoader;
using Terraria.ID;

namespace Persona5Cosplay.Items.Weapons.Agi
{
    public class Inferno : ModItem
    {

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Medium Fire damage to 1 foe. Chance to burn.");
		}

		public override void SetDefaults()
		{
			item.damage = 95;
			item.knockBack = 6;
			item.crit = 18;
			item.useTime = 18;
			item.useAnimation = 18;
			item.mana = 8;
			item.rare = 8;

			item.magic = true;
			item.value = 35000;
			item.autoReuse = true;
			item.noMelee = true;
			item.width = 35;
			item.height = 35;
			item.useStyle = 1;
			item.noUseGraphic = true;

			item.shoot = ModContent.ProjectileType<Projectiles.Inferno>();
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
