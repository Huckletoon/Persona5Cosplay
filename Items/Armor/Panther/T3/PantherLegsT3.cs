﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Panther.T3
{
    [AutoloadEquip(EquipType.Legs)]
    class PantherLegsT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Panther/PantherLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Panther Pants T3");
            Tooltip.SetDefault("The garb of Panther's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 8000;
            item.rare = 2;
            item.defense = 7;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 20);
            recipe.AddIngredient(mod, "PantherLegsT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
