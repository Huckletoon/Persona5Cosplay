using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Oracle.T4
{
    [AutoloadEquip(EquipType.Head)]
    class OracleHeadT4 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Oracle/OracleHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oracle Mask T4");
            Tooltip.SetDefault("The mask worn by Oracle");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 9000;
            item.rare = 4;
            item.defense = 8;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:CobaltBars", 10);
            recipe.AddIngredient(mod, "OracleHeadT3");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = true;
        }
    }
}
