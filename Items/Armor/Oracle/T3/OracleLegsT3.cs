using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Oracle.T3
{
    [AutoloadEquip(EquipType.Legs)]
    class OracleLegsT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Oracle/OracleLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oracle Pants T3");
            Tooltip.SetDefault("The garb of Oracle's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 8000;
            item.rare = 2;
            item.defense = 11;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 20);
            recipe.AddIngredient(mod, "OracleLegsT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
