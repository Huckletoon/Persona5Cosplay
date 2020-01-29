using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Skull.T3
{
    [AutoloadEquip(EquipType.Head)]
    class SkullHeadT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Skull/SkullHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skull Mask T3");
            Tooltip.SetDefault("The mask worn by Skull");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 6000;
            item.rare = 2;
            item.defense = 8;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 15);
            recipe.AddIngredient(mod, "SkullHeadT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
