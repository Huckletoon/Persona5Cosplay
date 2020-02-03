using Persona5Cosplay.Items.Armor.Crow.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Crow.T6
{
    [AutoloadEquip(EquipType.Body)]
    class CrowTorsoT6 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Crow/CrowTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crow Armor T6");
            Tooltip.SetDefault("The garb of Crow's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 60000;
            item.rare = 7;
            item.defense = 16;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<CrowHeadT6>() && legs.type == ItemType<CrowLegsT6>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+40% Damage\nSet bonus: +35% Attack Speed";
            player.allDamage += 0.40f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.35f;
            player.GetModPlayer<P5Player>().equipmentTier = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
            recipe.AddIngredient(mod, "CrowTorsoT5");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
