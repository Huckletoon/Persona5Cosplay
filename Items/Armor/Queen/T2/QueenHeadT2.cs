using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Queen.T2
{
    [AutoloadEquip(EquipType.Head)]
    class QueenHeadT2 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Queen/QueenHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Mask T2");
            Tooltip.SetDefault("The mask worn by Queen");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1200;
            item.rare = 1;
            item.defense = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:GoldBars", 15);
            recipe.AddIngredient(mod, "QueenHeadT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
