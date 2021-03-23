using Terraria.ModLoader;
using Terraria.ID;

namespace Persona5Cosplay.Items.Weapons.Agi
{
    public class Agi : ModItem
    {

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Light Fire damage to 1 foe. Chance to burn.");
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.knockBack = 3;
			item.crit = 14;
			item.useTime = 26;
			item.useAnimation = 26;
			item.mana = 2;
			item.rare = 1;

			item.magic = true;
			item.value = 5000;
			item.autoReuse = true;
			item.noMelee = true;
			item.width = 5;
			item.height = 5;
			item.useStyle = 1;
			item.noUseGraphic = true;

			item.shoot = ModContent.ProjectileType<Projectiles.Agi>();
			item.shootSpeed = 8f;

			//TODO
			item.UseSound = SoundID.Item1;
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
