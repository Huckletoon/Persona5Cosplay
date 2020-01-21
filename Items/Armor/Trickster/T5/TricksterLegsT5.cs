using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Trickster.T5
{
    [AutoloadEquip(EquipType.Legs)]
    class TricksterLegsT5 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Trickster/TricksterLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trickster Pants T5");
            Tooltip.SetDefault("The cognitive garb of the Trickster");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 85000;
            item.rare = 5;
            item.defense = 14;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddIngredient(mod, "TricksterLegsT4");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
