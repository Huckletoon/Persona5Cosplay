using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Panther.T1
{
    [AutoloadEquip(EquipType.Body)]
    class PantherTorsoT1 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Panther/PantherTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Panther Armor T1");
            Tooltip.SetDefault("The garb of Panther's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1500;
            item.rare = 0;
            item.defense = 2;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<PantherHeadT1>() && legs.type == ItemType<PantherLegsT1>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+10% Magic Damage";
            player.magicDamage += 0.10f;
            player.GetModPlayer<P5Player>().equipmentTier = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
