using Persona5Cosplay.Items.Armor.Queen.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Queen.T7
{
    [AutoloadEquip(EquipType.Body)]
    class QueenTorsoT7 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Queen/QueenTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Queen Armor");
            Tooltip.SetDefault("The true garb of Queen");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 90000;
            item.rare = 10;
            item.defense = 27;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<QueenHeadT7>() && legs.type == ItemType<QueenLegsT7>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+35% Damage\nSet bonus: +30% Move Speed\nSet bonus: Gain increased defense after being hit";
            player.allDamage += 0.35f;
            player.moveSpeed += 0.30f;
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
            recipe.AddIngredient(mod, "QueenTorsoT6");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
