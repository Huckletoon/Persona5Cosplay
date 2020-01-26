using Persona5Cosplay.Items.Armor.Trickster.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Trickster.T5
{
    [AutoloadEquip(EquipType.Body)]
    class TricksterTorsoT5 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Trickster/TricksterTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trickster Armor T5");
            Tooltip.SetDefault("The cognitive garb of the Trickster");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 50000;
            item.rare = 5;
            item.defense = 14;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<TricksterHeadT5>() && legs.type == ItemType<TricksterLegsT5>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+30% Damage\nSet bonus: +25% Attack Speed";
            player.allDamage += 0.30f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.25f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 25);
            recipe.AddIngredient(mod, "TricksterTorsoT4");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
