﻿using Persona5Cosplay.Items.Armor.Skull.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Skull.T6
{
    [AutoloadEquip(EquipType.Legs)]
    class SkullLegsT6 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Skull/SkullLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skull Pants T6");
            Tooltip.SetDefault("The garb of Skull's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 48000;
            item.rare = 7;
            item.defense = 18;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
            recipe.AddIngredient(mod, "SkullLegsT5");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
