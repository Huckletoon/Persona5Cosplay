using Persona5Cosplay.Items.Armor.Crow.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Crow.T5
{
    [AutoloadEquip(EquipType.Body)]
    class CrowTorsoT5 : ModItem
    {
        public int tier = 5;

        public override string Texture => "Persona5Cosplay/Items/Armor/Crow/CrowTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crow Armor T5");
            Tooltip.SetDefault("The garb of Crow's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 50000;
            item.rare = 5;
            item.defense = 14;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<CrowHeadT5>() && legs.type == ItemType<CrowLegsT5>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+30% Melee Damage\nSet bonus: +25% Attack Speed";
            player.allDamage += 0.30f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.25f;
            player.GetModPlayer<P5Player>().equipmentTier = 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 25);
            recipe.AddIngredient(mod, "CrowTorsoT4");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
