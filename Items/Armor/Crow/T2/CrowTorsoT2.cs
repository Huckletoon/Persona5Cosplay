using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Crow.T2
{
    [AutoloadEquip(EquipType.Body)]
    class CrowTorsoT2 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Crow/CrowTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crow Armor T2");
            Tooltip.SetDefault("The garb of Crow's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 2000;
            item.rare = 1;
            item.defense = 8;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<CrowHeadT2>() && legs.type == ItemType<CrowLegsT2>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+10% Damage";
            player.allDamage += 0.10f;
            player.GetModPlayer<P5Player>().equipmentTier = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:GoldBars", 30);
            recipe.AddIngredient(mod, "CrowTorsoT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
