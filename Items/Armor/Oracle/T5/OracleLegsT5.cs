using Persona5Cosplay.Items.Armor.Oracle.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Oracle.T5
{
    [AutoloadEquip(EquipType.Legs)]
    class OracleLegsT5 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Oracle/OracleLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oracle Pants T5");
            Tooltip.SetDefault("The garb of Oracle's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 40000;
            item.rare = 5;
            item.defense = 11;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddIngredient(mod, "OracleLegsT4");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
