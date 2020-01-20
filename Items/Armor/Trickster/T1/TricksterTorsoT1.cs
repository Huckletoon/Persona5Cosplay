using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Trickster.T1
{
    [AutoloadEquip(EquipType.Body)]
    class TricksterTorsoT1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trickster Armor T1");
            Tooltip.SetDefault("The cognitive garb of the Trickster");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 1;
            item.defense = 4;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<TricksterHeadT1>() && legs.type == ItemType<TricksterLegsT1>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+5% Damage";
            player.allDamage += 0.05f;
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
