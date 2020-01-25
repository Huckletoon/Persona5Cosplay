﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Skull.T2
{
    [AutoloadEquip(EquipType.Head)]
    class SkullHeadT2 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Skull/SkullTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skull Mask T2");
            Tooltip.SetDefault("The mask worn by Skull");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 20000;
            item.rare = 2;
            item.defense = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBar, 15);
            recipe.AddIngredient(mod, "SkullHeadT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumBar, 15);
            recipe.AddIngredient(mod, "SkullHeadT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}