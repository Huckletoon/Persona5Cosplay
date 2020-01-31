using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Fox.T3
{
    [AutoloadEquip(EquipType.Body)]
    class FoxTorsoT3 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Fox/FoxTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fox Armor T3");
            Tooltip.SetDefault("The garb of Fox's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 10;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<FoxHeadT3>() && legs.type == ItemType<FoxLegsT3>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+25% Melee Damage\nSet bonus: +10% Attack Speed";
            player.meleeDamage += 0.25f;
            player.GetModPlayer<P5Player>().attackSpeedMod = 0.10f;
            player.GetModPlayer<P5Player>().equipmentTier = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Persona5Cosplay:EvilBars", 25);
            recipe.AddIngredient(mod, "FoxTorsoT2");
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
