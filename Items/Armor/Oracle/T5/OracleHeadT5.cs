using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Oracle.T5
{
    [AutoloadEquip(EquipType.Head)]
    class OracleHeadT5 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Oracle/OracleHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oracle Mask T5");
            Tooltip.SetDefault("The mask worn by Oracle");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 30000;
            item.rare = 5;
            item.defense = 11;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(mod, "OracleHeadT4");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
