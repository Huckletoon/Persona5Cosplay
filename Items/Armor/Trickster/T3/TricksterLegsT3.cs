﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Trickster.T3
{
    [AutoloadEquip(EquipType.Legs)]
    class TricksterLegsT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Trickster/TricksterLegs";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trickster Pants T3");
            Tooltip.SetDefault("The cognitive garb of the Trickster");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 55000;
            item.rare = 2;
            item.defense = 9;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 20);
            recipe.AddIngredient(mod, "TricksterLegsT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 20);
            recipe.AddIngredient(mod, "TricksterLegsT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
