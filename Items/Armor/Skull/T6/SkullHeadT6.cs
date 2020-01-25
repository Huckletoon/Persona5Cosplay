﻿using Persona5Cosplay.Items.Armor.Skull.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Skull.T6
{
    [AutoloadEquip(EquipType.Head)]
    class SkullHeadT6 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Skull/SkullHead";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skull Mask T6");
            Tooltip.SetDefault("The mask worn by Skull");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 6;
            item.defense = 18;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
            recipe.AddIngredient(mod, "SkullHeadT5");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
