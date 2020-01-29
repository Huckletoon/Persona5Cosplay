using Persona5Cosplay.Items.Armor.Panther.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Panther.T6
{
    [AutoloadEquip(EquipType.Body)]
    class PantherTorsoT6 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Panther/PantherTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Panther Armor T6");
            Tooltip.SetDefault("The garb of Panther's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 60000;
            item.rare = 7;
            item.defense = 15;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<PantherHeadT6>() && legs.type == ItemType<PantherLegsT6>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+55% Magic Damage\nSet bonus: -20% Mana Cost\nSet bonus: +150 Max Mana";
            player.magicDamage += 0.55f;
            player.manaCost -= 0.20f;
            player.statManaMax2 += 150;
            player.GetModPlayer<P5Player>().equipmentTier = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
            recipe.AddIngredient(mod, "PantherTorsoT5");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
