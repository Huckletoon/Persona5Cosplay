using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Skull.T1
{
    [AutoloadEquip(EquipType.Head)]
    class SkullHeadT1 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Skull/SkullHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skull Mask T1");
            Tooltip.SetDefault("The mask worn by Skull");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 900;
            item.rare = 0;
            item.defense = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
