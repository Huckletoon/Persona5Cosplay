using Persona5Cosplay.Items.Armor.Fox.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Fox.T7
{
    [AutoloadEquip(EquipType.Body)]
    class FoxTorsoT7 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Fox/FoxTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Fox Armor");
            Tooltip.SetDefault("The true garb of Fox");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 90000;
            item.rare = 10;
            item.defense = 28;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<FoxHeadT7>() && legs.type == ItemType<FoxLegsT7>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+80% Melee Damage\nSet Bonus: +50% Attack Speed\nSet bonus: Reflect 100% melee damage";
            player.meleeDamage += 0.80f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.50f;
            player.GetModPlayer<P5Player>().thornPercent += 1.00f;
            player.GetModPlayer<P5Player>().equipmentTier = 7;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 15);
            recipe.AddIngredient(ItemID.FragmentNebula, 20);
            recipe.AddIngredient(ItemID.FragmentSolar, 20);
            recipe.AddIngredient(ItemID.FragmentStardust, 20);
            recipe.AddIngredient(ItemID.FragmentVortex, 20);
            recipe.AddIngredient(mod, "FoxTorsoT6");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
