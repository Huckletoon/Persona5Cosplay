using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Panther.T4
{
    [AutoloadEquip(EquipType.Body)]
    class PantherTorsoT4 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Panther/PantherTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Panther Armor T4");
            Tooltip.SetDefault("The garb of Panther's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 15000;
            item.rare = 4;
            item.defense = 9;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<PantherHeadT4>() && legs.type == ItemType<PantherLegsT4>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+35% Magic Damage\nSet bonus: -10% Mana Cost\nSet bonus: +50 Max Mana";
            player.magicDamage += 0.35f;
            player.manaCost -= 0.10f;
            player.statManaMax2 += 50;
            player.GetModPlayer<P5Player>().equipmentTier = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:CobaltBars", 30);
            recipe.AddIngredient(mod, "PantherTorsoT3");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe(); 
        }
    }
}
