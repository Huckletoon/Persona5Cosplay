﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Oracle.T1
{
    [AutoloadEquip(EquipType.Body)]
    class OracleTorsoT1 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Oracle/OracleTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oracle Armor T1");
            Tooltip.SetDefault("The garb of Oracle's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1500;
            item.rare = 0;
            item.defense = 3;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<OracleHeadT1>() && legs.type == ItemType<OracleLegsT1>();
        }

        public override void UpdateArmorSet(Player player)
        {
            //TODO
            player.setBonus = "+10% Melee Damage";
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
