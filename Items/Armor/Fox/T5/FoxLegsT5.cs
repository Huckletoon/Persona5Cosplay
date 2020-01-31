using Persona5Cosplay.Items.Armor.Fox.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Fox.T5
{
    [AutoloadEquip(EquipType.Legs)]
    class FoxLegsT5 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Fox/FoxLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fox Pants T5");
            Tooltip.SetDefault("The garb of Fox's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 40000;
            item.rare = 5;
            item.defense = 14;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddIngredient(mod, "FoxLegsT4");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
