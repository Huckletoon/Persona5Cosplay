﻿using Persona5Cosplay.Items.Armor.Noir.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Noir.T6
{
    [AutoloadEquip(EquipType.Legs)]
    class NoirLegsT6 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Noir/NoirLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Noir Pants T6");
            Tooltip.SetDefault("The garb of Noir's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 48000;
            item.rare = 7;
            item.defense = 14;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
            recipe.AddIngredient(mod, "NoirLegsT5");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
