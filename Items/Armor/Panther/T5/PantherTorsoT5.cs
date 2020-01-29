using Persona5Cosplay.Items.Armor.Panther.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Panther.T5
{
    [AutoloadEquip(EquipType.Body)]
    class PantherTorsoT5 : ModItem
    {
        public int tier = 5;

        public override string Texture => "Persona5Cosplay/Items/Armor/Panther/PantherTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Panther Armor T5");
            Tooltip.SetDefault("The garb of Panther's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 50000;
            item.rare = 5;
            item.defense = 13;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<PantherHeadT5>() && legs.type == ItemType<PantherLegsT5>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+45% Magic Damage\nSet bonus: -15% Mana Cost\nSet bonus: +100 Max Mana";
            player.magicDamage += 0.45f;
            player.manaCost -= 0.15f;
            player.statManaMax2 += 100;
            player.GetModPlayer<P5Player>().equipmentTier = 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 25);
            recipe.AddIngredient(mod, "PantherTorsoT4");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
