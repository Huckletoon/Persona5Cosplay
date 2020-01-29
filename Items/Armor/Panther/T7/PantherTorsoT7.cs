using Persona5Cosplay.Items.Armor.Panther.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Panther.T7
{
    [AutoloadEquip(EquipType.Body)]
    class PantherTorsoT7 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Panther/PantherTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Panther Armor");
            Tooltip.SetDefault("The true garb of Panther");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 90000;
            item.rare = 10;
            item.defense = 22;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<PantherHeadT7>() && legs.type == ItemType<PantherLegsT7>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+80% Magic Damage\nSet bonus: -30% Mana Cost\nSet bonus: +250 Max Mana";
            player.magicDamage += 0.80f;
            player.manaCost -= 0.30f;
            player.statManaMax2 += 250;
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
            recipe.AddIngredient(mod, "PantherTorsoT6");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
