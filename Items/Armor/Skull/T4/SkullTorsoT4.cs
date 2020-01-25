using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Skull.T4
{
    [AutoloadEquip(EquipType.Body)]
    class SkullTorsoT4 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Skull/SkullTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skull Armor T4");
            Tooltip.SetDefault("The garb of Skull's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 4;
            item.defense = 13;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<SkullHeadT4>() && legs.type == ItemType<SkullLegsT4>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+25% Melee Damage\nSet bonus: +15% Attack Speed\nSet bonus: Knockback Immunity";
            player.meleeDamage += 0.25f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.15f;
            player.noKnockback = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CobaltBar, 30);
            recipe.AddIngredient(mod, "SkullTorsoT3");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PalladiumBar, 30);
            recipe.AddIngredient(mod, "SkullTorsoT3");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
