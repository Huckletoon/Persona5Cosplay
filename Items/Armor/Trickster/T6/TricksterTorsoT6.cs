using Persona5Cosplay.Items.Armor.Trickster.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Trickster.T6
{
    [AutoloadEquip(EquipType.Body)]
    class TricksterTorsoT6 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Trickster/TricksterTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trickster Armor T6");
            Tooltip.SetDefault("The cognitive garb of the Trickster");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 60000;
            item.rare = 7;
            item.defense = 16;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<TricksterHeadT6>() && legs.type == ItemType<TricksterLegsT6>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+40% Damage\nSet bonus: +35% Attack Speed";
            player.allDamage += 0.40f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.35f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
            recipe.AddIngredient(mod, "TricksterTorsoT5");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
