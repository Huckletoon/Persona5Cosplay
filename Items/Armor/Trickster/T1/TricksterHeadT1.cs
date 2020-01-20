﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Persona5Cosplay.Items.Armor.Trickster.T1
{
    [AutoloadEquip(EquipType.Head)]
    class TricksterHeadT1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trickster Mask T1");
            Tooltip.SetDefault("The mask worn by the Trickster");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 7000;
            item.rare = 1;
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
