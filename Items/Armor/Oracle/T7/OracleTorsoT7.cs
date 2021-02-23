using System;
using Persona5Cosplay.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Oracle.T7
{
    [AutoloadEquip(EquipType.Body)]
    class OracleTorsoT7 : ModItem
    {
        private const int MAX_TIME = 60 * 5;
        private int timer = 0;
        private Random rng = new Random();

        public override string Texture => "Persona5Cosplay/Items/Armor/Oracle/OracleTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Oracle Armor");
            Tooltip.SetDefault("The true garb of Oracle");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 90000;
            item.rare = 10;
            item.defense = 22;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<OracleHeadT7>() && legs.type == ItemType<OracleLegsT7>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Randomly buff Attack, Defense, or Speed every 5 seconds\nSet bonus: Highlight danger around you\nSet bonus: 30% chance to evade attacks";
            timer++;
            if (timer >= MAX_TIME)
            {
                bool hasBuff = false;
                int buffType = -1;
                do
                {
                    buffType = rng.Next() % 3;
                    switch (buffType)
                    {
                        case 0:
                            hasBuff = player.HasBuff(ModContent.BuffType<OracleBuff_Attack>());
                            break;
                        case 1:
                            hasBuff = player.HasBuff(ModContent.BuffType<OracleBuff_Defense>());
                            break;
                        case 2:
                            hasBuff = player.HasBuff(ModContent.BuffType<OracleBuff_Speed>());
                            break;
                    }
                } while (hasBuff);
                switch (buffType)
                {
                    case 0:
                        player.AddBuff(ModContent.BuffType<OracleBuff_Attack>(), 60 * 10);
                        break;
                    case 1:
                        player.AddBuff(ModContent.BuffType<OracleBuff_Defense>(), 60 * 10);
                        break;
                    case 2:
                        player.AddBuff(ModContent.BuffType<OracleBuff_Speed>(), 60 * 10);
                        break;
                }
                timer = 0;
            }
            player.AddBuff(BuffID.Dangersense, 5);
            player.GetModPlayer<P5Player>().dodgeChance = 0.30f;
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
            recipe.AddIngredient(mod, "OracleTorsoT6");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
