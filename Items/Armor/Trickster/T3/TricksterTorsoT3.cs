﻿using Persona5Cosplay.Items.Armor.Trickster.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Trickster.T3
{
    [AutoloadEquip(EquipType.Body)]
    class TricksterTorsoT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Trickster/TricksterTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trickster Armor T3");
            Tooltip.SetDefault("The cognitive garb of the Trickster");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 9;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<TricksterHeadT3>() && legs.type == ItemType<TricksterLegsT3>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+15% Damage\nSet bonus: +10% Attack Speed";
            player.allDamage += 0.15f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.10f;
            player.GetModPlayer<P5Player>().equipmentTier = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 25);
            recipe.AddIngredient(mod, "TricksterTorsoT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
