using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Crow.T5
{
    [AutoloadEquip(EquipType.Head)]
    class CrowHeadT5 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Crow/CrowHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crow Mask T5");
            Tooltip.SetDefault("The mask worn by Crow");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 30000;
            item.rare = 5;
            item.defense = 14;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(mod, "CrowHeadT4");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
