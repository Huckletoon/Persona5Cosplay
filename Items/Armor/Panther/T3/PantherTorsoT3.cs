using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Panther.T3
{
    [AutoloadEquip(EquipType.Body)]
    class PantherTorsoT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Panther/PantherTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Panther Armor T3");
            Tooltip.SetDefault("The garb of Panther's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 7;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<PantherHeadT3>() && legs.type == ItemType<PantherLegsT3>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+25% Magic Damage\nSet bonus: -5% Mana Cost";
            player.magicDamage += 0.25f;
            player.manaCost -= 0.05f;
            player.GetModPlayer<P5Player>().equipmentTier = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 25);
            recipe.AddIngredient(mod, "PantherTorsoT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
