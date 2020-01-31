using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Queen.T2
{
    [AutoloadEquip(EquipType.Legs)]
    class QueenLegsT2 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Queen/QueenLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Pants T2");
            Tooltip.SetDefault("The garb of Queen's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1600;
            item.rare = 1;
            item.defense = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:GoldBars", 25);
            recipe.AddIngredient(mod, "QueenLegsT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
