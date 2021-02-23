using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Queen.T2
{
    [AutoloadEquip(EquipType.Body)]
    class QueenTorsoT2 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Queen/QueenTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Armor T2");
            Tooltip.SetDefault("The garb of Queen's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 2000;
            item.rare = 1;
            item.defense = 8;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<QueenHeadT2>() && legs.type == ItemType<QueenLegsT2>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+10% Damage";
            player.allDamage += 0.10f;
            player.GetModPlayer<P5Player>().equipmentTier = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:GoldBars", 30);
            recipe.AddIngredient(mod, "QueenTorsoT1");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
