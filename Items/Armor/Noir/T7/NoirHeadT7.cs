using Persona5Cosplay.Items.Armor.Noir.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Noir.T7
{
    [AutoloadEquip(EquipType.Head)]
    class NoirHeadT7 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Noir/NoirHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Noir Mask");
            Tooltip.SetDefault("Noir's true face");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 74000;
            item.rare = 10;
            item.defense = 20;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddIngredient(ItemID.FragmentNebula, 20);
            recipe.AddIngredient(ItemID.FragmentSolar, 20);
            recipe.AddIngredient(ItemID.FragmentStardust, 20);
            recipe.AddIngredient(ItemID.FragmentVortex, 20);
            recipe.AddIngredient(mod, "NoirHeadT6");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
