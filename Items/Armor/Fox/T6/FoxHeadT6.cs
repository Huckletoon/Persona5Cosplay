using Persona5Cosplay.Items.Armor.Fox.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Fox.T6
{
    [AutoloadEquip(EquipType.Head)]
    class FoxHeadT6 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Fox/FoxHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fox Mask T6");
            Tooltip.SetDefault("The mask worn by Fox");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 36000;
            item.rare = 7;
            item.defense = 17;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
            recipe.AddIngredient(mod, "FoxHeadT5");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
