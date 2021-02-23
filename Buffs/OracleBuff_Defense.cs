using Terraria;
using Terraria.ModLoader;
using Persona5Cosplay;

namespace Persona5Cosplay.Buffs
{
    class OracleBuff_Defense : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Moral Support - Rakukaja");
            Description.SetDefault("Increased Defense");
            Main.debuff[Type] = false;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 10 * player.GetModPlayer<P5Player>().equipmentTier;

        }
    }
}
