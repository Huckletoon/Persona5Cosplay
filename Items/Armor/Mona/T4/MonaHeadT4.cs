﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Mona.T4
{
    [AutoloadEquip(EquipType.Head)]
    class MonaHeadT4 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Mona/MonaHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mona Mask T4");
            Tooltip.SetDefault("The mask worn by Mona");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 9000;
            item.rare = 4;
            item.defense = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:CobaltBars", 10);
            recipe.AddIngredient(mod, "MonaHeadT3");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
             
        }
    }
}
