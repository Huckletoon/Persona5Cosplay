using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Persona5Cosplay.Buffs;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Mona.T3
{
    [AutoloadEquip(EquipType.Body)]
    class MonaTorsoT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Mona/MonaTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mona Armor T3");
            Tooltip.SetDefault("The garb of Mona's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 9;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<MonaHeadT3>() && legs.type == ItemType<MonaLegsT3>();
        }

        public override void UpdateArmorSet(Player player)
        {
            //TODO
            player.setBonus = "+15% Magic Damage\nSet bonus: Knockback Immunity\nSet bonus: Heal 5% of max health after taking damage";
            player.magicDamage += 0.15f;
            player.noKnockback = true;
            player.GetModPlayer<P5Player>().equipmentTier = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 25);
            recipe.AddIngredient(mod, "MonaTorsoT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
