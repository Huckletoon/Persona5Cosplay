using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Fox.T4
{
    [AutoloadEquip(EquipType.Legs)]
    class FoxLegsT4 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Fox/FoxLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fox Pants T4");
            Tooltip.SetDefault("The garb of Fox's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 12000;
            item.rare = 4;
            item.defense = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:CobaltBars", 20);
            recipe.AddIngredient(mod, "FoxLegsT3");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe(); 
        }
    }
}
