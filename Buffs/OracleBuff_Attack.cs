using Terraria;
using Terraria.ModLoader;

namespace Persona5Cosplay.Buffs
{
    class OracleBuff_Attack : ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Moral Support - Tarukaja");
            Description.SetDefault("Increased Attack");
            Main.debuff[Type] = false;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.allDamage += 0.25f;

        }
    }
}
