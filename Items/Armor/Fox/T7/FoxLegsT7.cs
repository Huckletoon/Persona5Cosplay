using Persona5Cosplay.Items.Armor.Skull.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Skull.T7
{
    [AutoloadEquip(EquipType.Legs)]
    class SkullLegsT7 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Skull/SkullLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Skull Pants");
            Tooltip.SetDefault("The true garb of Skull");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 82000;
            item.rare = 10;
            item.defense = 27;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddIngredient(ItemID.FragmentNebula, 20);
            recipe.AddIngredient(ItemID.FragmentSolar, 20);
            recipe.AddIngredient(ItemID.FragmentStardust, 20);
            recipe.AddIngredient(ItemID.FragmentVortex, 20);
            recipe.AddIngredient(mod, "SkullLegsT6");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
