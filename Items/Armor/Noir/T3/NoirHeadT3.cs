using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Noir.T3
{
    [AutoloadEquip(EquipType.Head)]
    class NoirHeadT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Noir/NoirHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Noir Mask T3");
            Tooltip.SetDefault("The mask worn by Noir");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 6000;
            item.rare = 2;
            item.defense = 7;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 15);
            recipe.AddIngredient(mod, "NoirHeadT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
