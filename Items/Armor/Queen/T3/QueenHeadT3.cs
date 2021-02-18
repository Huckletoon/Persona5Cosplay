using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Queen.T3
{
    [AutoloadEquip(EquipType.Head)]
    class QueenHeadT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Queen/QueenHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Mask T3");
            Tooltip.SetDefault("The mask worn by Queen");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 6000;
            item.rare = 2;
            item.defense = 7;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 15);
            recipe.AddIngredient(mod, "QueenHeadT2");
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
