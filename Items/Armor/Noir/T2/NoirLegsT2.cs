using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Noir.T2
{
    [AutoloadEquip(EquipType.Legs)]
    class NoirLegsT2 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Noir/NoirLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Noir Pants T2");
            Tooltip.SetDefault("The garb of Noir's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1600;
            item.rare = 1;
            item.defense = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:GoldBars", 25);
            recipe.AddIngredient(mod, "NoirLegsT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
