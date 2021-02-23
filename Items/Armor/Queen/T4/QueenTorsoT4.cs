using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Queen.T4
{
    [AutoloadEquip(EquipType.Body)]
    class QueenTorsoT4 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Queen/QueenTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Armor T4");
            Tooltip.SetDefault("The garb of Queen's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 15000;
            item.rare = 4;
            item.defense = 11;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<QueenHeadT4>() && legs.type == ItemType<QueenLegsT4>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+20% Damage\nSet bonus: 10% Move Speed\nSet bonus: Gain increased defense after being hit";
            player.allDamage += 0.20f;
            player.moveSpeed += 0.10f;
            player.GetModPlayer<P5Player>().equipmentTier = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:CobaltBars", 30);
            recipe.AddIngredient(mod, "QueenTorsoT3");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe(); 
        }
    }
}
