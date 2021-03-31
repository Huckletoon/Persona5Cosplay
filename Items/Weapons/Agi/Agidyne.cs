using Terraria.ModLoader;
using Terraria.ID;

namespace Persona5Cosplay.Items.Weapons.Agi
{
    public class Agidyne : ModItem
    {

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Heavy Fire damage to 1 foe. Chance to burn.");
		}

		public override void SetDefaults()
		{
			item.damage = 60;
			item.knockBack = 6;
			item.crit = 16;
			item.useTime = 20;
			item.useAnimation = 20;
			item.mana = 6;
			item.rare = 6;

			item.magic = true;
			item.value = 25000;
			item.autoReuse = true;
			item.noMelee = true;
			item.width = 30;
			item.height = 30;
			item.useStyle = 1;
			item.noUseGraphic = true;

			item.shoot = ModContent.ProjectileType<Projectiles.Agidyne>();
			item.shootSpeed = 8f;

			//TODO
			item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()
		{
			//TODO
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
