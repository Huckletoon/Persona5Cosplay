using Persona5Cosplay.Items.Armor.Mona.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Mona.T7
{
    [AutoloadEquip(EquipType.Body)]
    class MonaTorsoT7 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Mona/MonaTorso";
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Ultimate Mona Armor");
            Tooltip.SetDefault("The true garb of Mona");
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
            return head.type == ItemType<MonaHeadT7>() && legs.type == ItemType<MonaLegsT7>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+45% Magic Damage\nSet bonus: Knockback Immunity\nSet bonus: Heal 30% of max health after taking damage";
            player.magicDamage += 0.45f;
            player.noKnockback = true;
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
            recipe.AddIngredient(mod, "MonaTorsoT6");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
