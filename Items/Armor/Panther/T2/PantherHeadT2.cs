using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Panther.T2
{
    [AutoloadEquip(EquipType.Head)]
    class PantherHeadT2 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Panther/PantherHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Panther Mask T2");
            Tooltip.SetDefault("The mask worn by Panther");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1200;
            item.rare = 1;
            item.defense = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:GoldBars", 15);
            recipe.AddIngredient(mod, "PantherHeadT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
