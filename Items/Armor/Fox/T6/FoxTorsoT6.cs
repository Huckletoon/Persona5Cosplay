using Persona5Cosplay.Items.Armor.Fox.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Fox.T6
{
    [AutoloadEquip(EquipType.Body)]
    class FoxTorsoT6 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Fox/FoxTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fox Armor T6");
            Tooltip.SetDefault("The garb of Fox's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 60000;
            item.rare = 7;
            item.defense = 18;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<FoxHeadT6>() && legs.type == ItemType<FoxLegsT6>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+50% Melee Damage\nSet bonus: +40% Attack Speed\nSet bonus: Reflect 50% melee damage";
            player.meleeDamage += 0.50f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.40f;
            player.GetModPlayer<P5Player>().thornPercent += 0.50f;
            player.GetModPlayer<P5Player>().equipmentTier = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
            recipe.AddIngredient(mod, "FoxTorsoT5");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
