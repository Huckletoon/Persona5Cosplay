using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Fox.T2
{
    [AutoloadEquip(EquipType.Legs)]
    class FoxLegsT2 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Fox/FoxLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fox Pants T2");
            Tooltip.SetDefault("The garb of Fox's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1600;
            item.rare = 1;
            item.defense = 8;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:GoldBars", 25);
            recipe.AddIngredient(mod, "FoxLegsT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
