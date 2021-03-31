using Terraria.ModLoader;
using Terraria.ID;

namespace Persona5Cosplay.Items.Weapons.Agi
{
    public class Maragion : ModItem
    {

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Medium Fire damage to multiple foes. Chance to burn.");
		}

		public override void SetDefaults()
		{
			item.damage = 31;
			item.knockBack = 3;
			item.crit = 12;
			item.useTime = 12;
			item.useAnimation = 12;
			item.mana = 4;
			item.rare = 5;

			item.magic = true;
			item.value = 20000;
			item.autoReuse = true;
			item.noMelee = true;
			item.width = 5;
			item.height = 5;
			item.useStyle = 1;
			item.noUseGraphic = true;

			item.shoot = ModContent.ProjectileType<Projectiles.Maragion>();
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
