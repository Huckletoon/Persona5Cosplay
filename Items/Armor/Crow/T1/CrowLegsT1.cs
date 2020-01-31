using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Crow.T1
{
    [AutoloadEquip(EquipType.Legs)]
    class CrowLegsT1 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Crow/CrowLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crow Pants T1");
            Tooltip.SetDefault("The garb of Crow's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1200;
            item.rare = 0;
            item.defense = 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
