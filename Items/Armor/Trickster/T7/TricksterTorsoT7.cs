﻿using Persona5Cosplay.Items.Armor.Trickster.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Trickster.T7
{
    [AutoloadEquip(EquipType.Body)]
    class TricksterTorsoT7 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Trickster/TricksterTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Trickster Armor");
            Tooltip.SetDefault("The true garb of the Trickster");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 90000;
            item.rare = 10;
            item.defense = 26;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<TricksterHeadT7>() && legs.type == ItemType<TricksterLegsT7>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+50% Damage\nSet bonus: +50% Attack Speed";
            player.allDamage += 0.50f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.50f;
            player.GetModPlayer<P5Player>().equipmentTier = 7;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 15);
            recipe.AddIngredient(ItemID.FragmentNebula, 20);
            recipe.AddIngredient(ItemID.FragmentSolar, 20);
            recipe.AddIngredient(ItemID.FragmentStardust, 20);
            recipe.AddIngredient(ItemID.FragmentVortex, 20);
            recipe.AddIngredient(mod, "TricksterTorsoT6");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
