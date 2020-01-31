using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Oracle.T4
{
    [AutoloadEquip(EquipType.Body)]
    class OracleTorsoT4 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Oracle/OracleTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oracle Armor T4");
            Tooltip.SetDefault("The garb of Oracle's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 15000;
            item.rare = 4;
            item.defense = 13;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<OracleHeadT4>() && legs.type == ItemType<OracleLegsT4>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+25% Melee Damage\nSet bonus: +15% Attack Speed\nSet bonus: Knockback Immunity";
            player.meleeDamage += 0.25f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.15f;
            player.noKnockback = true;
            player.GetModPlayer<P5Player>().equipmentTier = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:CobaltBars", 30);
            recipe.AddIngredient(mod, "OracleTorsoT3");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe(); 
        }
    }
}
