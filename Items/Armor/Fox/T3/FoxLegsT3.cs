using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Fox.T3
{
    [AutoloadEquip(EquipType.Legs)]
    class FoxLegsT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Fox/FoxLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fox Pants T3");
            Tooltip.SetDefault("The garb of Fox's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 8000;
            item.rare = 2;
            item.defense = 9;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 20);
            recipe.AddIngredient(mod, "FoxLegsT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
