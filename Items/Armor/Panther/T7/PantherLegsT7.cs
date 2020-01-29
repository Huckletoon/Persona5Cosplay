using Persona5Cosplay.Items.Armor.Panther.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Panther.T7
{
    [AutoloadEquip(EquipType.Legs)]
    class PantherLegsT7 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Panther/PantherLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Panther Pants");
            Tooltip.SetDefault("The true garb of Panther");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 82000;
            item.rare = 10;
            item.defense = 20;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddIngredient(ItemID.FragmentNebula, 20);
            recipe.AddIngredient(ItemID.FragmentSolar, 20);
            recipe.AddIngredient(ItemID.FragmentStardust, 20);
            recipe.AddIngredient(ItemID.FragmentVortex, 20);
            recipe.AddIngredient(mod, "PantherLegsT6");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
