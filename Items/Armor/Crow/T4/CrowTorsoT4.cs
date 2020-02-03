using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Crow.T4
{
    [AutoloadEquip(EquipType.Body)]
    class CrowTorsoT4 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Crow/CrowTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crow Armor T4");
            Tooltip.SetDefault("The garb of Crow's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 15000;
            item.rare = 4;
            item.defense = 11;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<CrowHeadT4>() && legs.type == ItemType<CrowLegsT4>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+20% Damage\nSet bonus: +15% Attack Speed";
            player.allDamage += 0.20f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.15f;
            player.GetModPlayer<P5Player>().equipmentTier = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:CobaltBars", 30);
            recipe.AddIngredient(mod, "CrowTorsoT3");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe(); 
        }
    }
}
