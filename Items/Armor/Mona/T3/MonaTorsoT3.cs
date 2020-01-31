﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Mona.T3
{
    [AutoloadEquip(EquipType.Body)]
    class MonaTorsoT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Mona/MonaTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mona Armor T3");
            Tooltip.SetDefault("The garb of Mona's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 12;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<MonaHeadT3>() && legs.type == ItemType<MonaLegsT3>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+20% Melee Damage\nSet bonus: +10% Attack Speed\nSet bonus: Knockback Immunity";
            player.meleeDamage += 0.20f;
            player.noKnockback = true;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.10f;
            player.GetModPlayer<P5Player>().equipmentTier = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 25);
            recipe.AddIngredient(mod, "MonaTorsoT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
