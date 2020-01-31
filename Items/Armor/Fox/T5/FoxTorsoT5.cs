using Persona5Cosplay.Items.Armor.Fox.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Fox.T5
{
    [AutoloadEquip(EquipType.Body)]
    class FoxTorsoT5 : ModItem
    {
        public int tier = 5;

        public override string Texture => "Persona5Cosplay/Items/Armor/Fox/FoxTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fox Armor T5");
            Tooltip.SetDefault("The garb of Fox's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 50000;
            item.rare = 5;
            item.defense = 12;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<FoxHeadT5>() && legs.type == ItemType<FoxLegsT5>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+40% Melee Damage\nSet bonus: +30% Attack Speed\nSet bonus: Reflect 25% melee damage";
            player.meleeDamage += 0.40f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.30f;
            player.GetModPlayer<P5Player>().thornPercent += 0.25f;
            player.GetModPlayer<P5Player>().equipmentTier = 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 25);
            recipe.AddIngredient(mod, "FoxTorsoT4");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
