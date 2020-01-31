using Persona5Cosplay.Items.Armor.Fox.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Fox.T7
{
    [AutoloadEquip(EquipType.Head)]
    class FoxHeadT7 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Fox/FoxHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Fox Mask");
            Tooltip.SetDefault("Fox's true face");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 74000;
            item.rare = 10;
            item.defense = 23;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddIngredient(ItemID.FragmentNebula, 20);
            recipe.AddIngredient(ItemID.FragmentSolar, 20);
            recipe.AddIngredient(ItemID.FragmentStardust, 20);
            recipe.AddIngredient(ItemID.FragmentVortex, 20);
            recipe.AddIngredient(mod, "FoxHeadT6");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
