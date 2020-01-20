using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Persona5Cosplay.Items.Armor.Trickster.T1
{
    [AutoloadEquip(EquipType.Legs)]
    class TricksterLegsT1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trickster Pants T1");
            Tooltip.SetDefault("The cognitive garb of the Trickster");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 8000;
            item.rare = 1;
            item.defense = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
