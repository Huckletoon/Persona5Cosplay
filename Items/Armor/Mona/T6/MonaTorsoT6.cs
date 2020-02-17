﻿using Persona5Cosplay.Items.Armor.Mona.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Mona.T6
{
    [AutoloadEquip(EquipType.Body)]
    class MonaTorsoT6 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Mona/MonaTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mona Armor T6");
            Tooltip.SetDefault("The garb of Mona's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 60000;
            item.rare = 7;
            item.defense = 17;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<MonaHeadT6>() && legs.type == ItemType<MonaLegsT6>();
        }

        public override void UpdateArmorSet(Player player)
        {
            //TODO
            player.setBonus = "+45% Melee Damage\nSet bonus: +35% Attack Speed\nSet bonus: Knockback Immunity";
            player.meleeDamage += 0.45f;
            player.GetModPlayer<P5Player>().equipmentTier = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
            recipe.AddIngredient(mod, "MonaTorsoT5");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
