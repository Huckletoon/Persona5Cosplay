using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Oracle.T2
{
    [AutoloadEquip(EquipType.Body)]
    class OracleTorsoT2 : ModItem
    {
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
            //TODO
            player.setBonus = "+15% Melee Damage\nSet bonus: Knockback Immunity";
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
