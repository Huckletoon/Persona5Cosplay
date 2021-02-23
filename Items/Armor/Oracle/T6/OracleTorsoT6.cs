using Persona5Cosplay.Items.Armor.Oracle.T1;
using Persona5Cosplay.Buffs;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Oracle.T6
{
    [AutoloadEquip(EquipType.Body)]
    class OracleTorsoT6 : ModItem
    {
        private const int MAX_TIME = 60 * 10;
        private int timer = 0;
        private Random rng = new Random();

        public override string Texture => "Persona5Cosplay/Items/Armor/Oracle/OracleTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oracle Armor T6");
            Tooltip.SetDefault("The garb of Oracle's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 60000;
            item.rare = 7;
            item.defense = 15;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<OracleHeadT6>() && legs.type == ItemType<OracleLegsT6>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Randomly buff Attack, Defense, or Speed every 10 seconds\nSet bonus: Highlight danger around you";
            timer++;
            if (timer >= MAX_TIME)
            {
                switch (rng.Next() % 3) {
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
            player.GetModPlayer<P5Player>().equipmentTier = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
            recipe.AddIngredient(mod, "OracleTorsoT5");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
