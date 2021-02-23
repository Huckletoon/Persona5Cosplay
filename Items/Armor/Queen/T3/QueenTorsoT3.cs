using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Queen.T3
{
    [AutoloadEquip(EquipType.Body)]
    class QueenTorsoT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Queen/QueenTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Armor T3");
            Tooltip.SetDefault("The garb of Queen's rebellion");
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
            return head.type == ItemType<QueenHeadT3>() && legs.type == ItemType<QueenLegsT3>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+15% Damage\nSet bonus: +5% Move Speed\nSet bonus: Gain increased defense after being hit";
            player.allDamage += 0.15f;
            player.moveSpeed += 0.05f;
            player.GetModPlayer<P5Player>().equipmentTier = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 25);
            recipe.AddIngredient(mod, "QueenTorsoT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
