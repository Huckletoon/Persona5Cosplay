using System;
using Persona5Cosplay.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Oracle.T2
{
    [AutoloadEquip(EquipType.Body)]
    class OracleTorsoT2 : ModItem
    {
        private const int MAX_TIME = 60 * 35;
        private int timer = 0;
        private Random rng = new Random();

        public override string Texture => "Persona5Cosplay/Items/Armor/Oracle/OracleTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oracle Armor T2");
            Tooltip.SetDefault("The garb of Oracle's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 2000;
            item.rare = 1;
            item.defense = 6;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<OracleHeadT2>() && legs.type == ItemType<OracleLegsT2>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Randomly buff Attack, Defense, or Speed every 35 seconds";
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
            player.GetModPlayer<P5Player>().equipmentTier = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:GoldBars", 30);
            recipe.AddIngredient(mod, "OracleTorsoT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
