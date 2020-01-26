using Persona5Cosplay.Items.Armor.Skull.T1;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Skull.T5
{
    [AutoloadEquip(EquipType.Body)]
    class SkullTorsoT5 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Skull/SkullTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skull Armor");
            Tooltip.SetDefault("The garb of Skull's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 50000;
            item.rare = 5;
            item.defense = 17;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<SkullHeadT5>() && legs.type == ItemType<SkullLegsT5>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+35% Melee Damage\nSet bonus: +25% Attack Speed\nSet bonus: Knockback Immunity";
            player.meleeDamage += 0.35f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.25f;
            player.noKnockback = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 25);
            recipe.AddIngredient(mod, "SkullTorsoT4");
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
