using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Skull.T2
{
    [AutoloadEquip(EquipType.Head)]
    class SkullHeadT2 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Skull/SkullHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skull Mask T2");
            Tooltip.SetDefault("The mask worn by Skull");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1200;
            item.rare = 1;
            item.defense = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:GoldBars", 15);
            recipe.AddIngredient(mod, "SkullHeadT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = true;
        }
    }
}
