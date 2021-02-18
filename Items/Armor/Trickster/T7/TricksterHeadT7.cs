using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Trickster.T7
{
    [AutoloadEquip(EquipType.Head)]
    class TricksterHeadT7 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Trickster/TricksterHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Trickster Mask");
            Tooltip.SetDefault("The mask of the Trickster's true soul");
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
            recipe.AddIngredient(mod, "TricksterHeadT6");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = true;
        }
    }
}
