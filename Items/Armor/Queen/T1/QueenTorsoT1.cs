﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Queen.T1
{
    [AutoloadEquip(EquipType.Body)]
    class QueenTorsoT1 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Queen/QueenTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Armor T1");
            Tooltip.SetDefault("The garb of Queen's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1500;
            item.rare = 0;
            item.defense = 4;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<QueenHeadT1>() && legs.type == ItemType<QueenLegsT1>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+5% Damage";
            player.allDamage += 0.05f;
            player.GetModPlayer<P5Player>().equipmentTier = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
