using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Panther.T2
{
    [AutoloadEquip(EquipType.Body)]
    class PantherTorsoT2 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Panther/PantherTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Panther Armor T2");
            Tooltip.SetDefault("The garb of Panther's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 2000;
            item.rare = 1;
            item.defense = 6;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<PantherHeadT2>() && legs.type == ItemType<PantherLegsT2>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+20% Magic Damage";
            player.magicDamage += 0.20f;
            player.GetModPlayer<P5Player>().equipmentTier = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:GoldBars", 30);
            recipe.AddIngredient(mod, "PantherTorsoT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
