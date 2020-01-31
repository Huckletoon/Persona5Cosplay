﻿using Persona5Cosplay.Items.Armor.Queen.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Queen.T5
{
    [AutoloadEquip(EquipType.Legs)]
    class QueenLegsT5 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Queen/QueenLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Pants T5");
            Tooltip.SetDefault("The garb of Queen's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 40000;
            item.rare = 5;
            item.defense = 15;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddIngredient(mod, "QueenLegsT4");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
