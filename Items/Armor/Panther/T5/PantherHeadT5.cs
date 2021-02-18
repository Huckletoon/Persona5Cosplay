using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Panther.T5
{
    [AutoloadEquip(EquipType.Head)]
    class PantherHeadT5 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Panther/PantherHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Panther Mask T5");
            Tooltip.SetDefault("The mask worn by Panther");
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
            recipe.AddIngredient(mod, "PantherHeadT4");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = true;
        }
    }
}
