using Terraria;
using Terraria.ModLoader;

namespace Persona5Cosplay.Buffs
{
    class QueenBuff : ModBuff
    {

        private int defBoost = 0;

        public override void SetDefaults()
        {
            //TODO: Rename
            DisplayName.SetDefault("Rakukaja");
            Description.SetDefault("A recent attack has triggered your guard");
            Main.debuff[Type] = false;
            canBeCleared = false;
        }

        public override bool ReApply(Player player, int time, int buffIndex)
        {
            return true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            switch (player.GetModPlayer<P5Player>().equipmentTier)
            {
                case 3:
                    defBoost = 10;
                    break;
                case 4:
                    defBoost = 20;
                    break;
                case 5:
                    defBoost = 30;
                    break;
                case 6:
                    defBoost = 40;
                    break;
                case 7:
                    defBoost = 60;
                    break;
            }
            player.statDefense += defBoost;
        }
    }
}
