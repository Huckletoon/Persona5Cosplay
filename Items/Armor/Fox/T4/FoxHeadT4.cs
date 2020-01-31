using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Fox.T4
{
    [AutoloadEquip(EquipType.Head)]
    class FoxHeadT4 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Fox/FoxHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fox Mask T4");
            Tooltip.SetDefault("The mask worn by Fox");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 9000;
            item.rare = 4;
            item.defense = 9;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:CobaltBars", 10);
            recipe.AddIngredient(mod, "FoxHeadT3");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
             
        }
    }
}
