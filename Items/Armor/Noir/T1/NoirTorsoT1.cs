using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Persona5Cosplay.Items.Armor.Noir.T1
{
    [AutoloadEquip(EquipType.Body)]
    class NoirTorsoT1 : ModItem
    {
        public override string Texture => "Persona5Cosplay/Items/Armor/Noir/NoirTorso";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Noir Armor T1");
            Tooltip.SetDefault("The garb of Noir's rebellion");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1500;
            item.rare = 0;
            item.defense = 6;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemType<NoirHeadT1>() && legs.type == ItemType<NoirLegsT1>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+10% Melee Damage";
            player.meleeDamage += 0.10f;
            player.GetModPlayer<P5Player>().equipmentTier = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
