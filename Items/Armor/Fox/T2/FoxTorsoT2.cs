﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Fox.T2
{
    [AutoloadEquip(EquipType.Body)]
    class FoxTorsoT2 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Fox/FoxTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fox Armor T2");
            Tooltip.SetDefault("The garb of Fox's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 2000;
            item.rare = 1;
            item.defense = 9;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<FoxHeadT2>() && legs.type == ItemType<FoxLegsT2>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+20% Melee Damage";
            player.meleeDamage += 0.20f;
            player.GetModPlayer<P5Player>().equipmentTier = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:GoldBars", 30);
            recipe.AddIngredient(mod, "FoxTorsoT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
