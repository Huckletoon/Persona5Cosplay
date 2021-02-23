using System;
using Persona5Cosplay.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Oracle.T3
{
    [AutoloadEquip(EquipType.Body)]
    class OracleTorsoT3 : ModItem
    {
        private const int MAX_TIME = 60 * 25;
        private int timer = 0;
        private Random rng = new Random();

        public override string Texture => "Persona5Cosplay/Items/Armor/Oracle/OracleTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oracle Armor T3");
            Tooltip.SetDefault("The garb of Oracle's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 7;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<OracleHeadT3>() && legs.type == ItemType<OracleLegsT3>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Randomly buff Attack, Defense, or Speed every 25 seconds\nSet bonus: Highlight danger around you";
            timer++;
            if (timer >= MAX_TIME)
            {
                switch (rng.Next() % 3)
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
            player.GetModPlayer<P5Player>().equipmentTier = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 25);
            recipe.AddIngredient(mod, "OracleTorsoT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
