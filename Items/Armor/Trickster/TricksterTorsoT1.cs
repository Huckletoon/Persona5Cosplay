using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Persona5Cosplay.Items.Armor.Trickster
{
    class TricksterTorsoT1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trickster Armor T1");
            Tooltip.SetDefault("The cognitive garb of the Trickster");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 4;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return base.IsArmorSet(head, body, legs);
        }

        public override void UpdateArmorSet(Player player)
        {
            
        }
    }
}
