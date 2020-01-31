using Persona5Cosplay.Items.Armor.Noir.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Noir.T7
{
    [AutoloadEquip(EquipType.Body)]
    class NoirTorsoT7 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Noir/NoirTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Noir Armor");
            Tooltip.SetDefault("The true garb of Noir");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 90000;
            item.rare = 10;
            item.defense = 29;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<NoirHeadT7>() && legs.type == ItemType<NoirLegsT7>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+60% Melee Damage\nSet Bonus: +50% Attack Speed\nSet bonus: Knockback Immunity";
            player.meleeDamage += 0.60f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.50f;
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
            recipe.AddIngredient(mod, "NoirTorsoT6");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
