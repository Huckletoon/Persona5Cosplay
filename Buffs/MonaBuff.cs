using Terraria;
using Terraria.ModLoader;

namespace Persona5Cosplay.Buffs
{
    class MonaBuff : ModBuff
    {

        private const int MAX_TIME = 60 * 3;
        private int timer = 0;
        private int healRate = 0;

        public override void SetDefaults()
        {
            //TODO: Rename
            DisplayName.SetDefault("Mona buff");
            Description.SetDefault("Heal recent wounds");
            Main.debuff[Type] = false;
            canBeCleared = false;
        }

        public override bool ReApply(Player player, int time, int buffIndex)
        {
            timer = 0;
            return false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (timer >= 0) timer++;
            if (timer >= MAX_TIME)
            {
                switch(player.GetModPlayer<P5Player>().equipmentTier)
                {
                    case 3:
                        healRate = (int) (player.statLifeMax2 * 0.05);
                        break;
                    case 4:
                        healRate = (int)(player.statLifeMax2 * 0.10);
                        break;
                    case 5:
                        healRate = (int)(player.statLifeMax2 * 0.15);
                        break;
                    case 6:
                        healRate = (int)(player.statLifeMax2 * 0.20);
                        break;
                    case 7:
                        healRate = (int)(player.statLifeMax2 * 0.30);
                        break;
                }
                player.statLife += healRate;
                timer = 0;
                player.DelBuff(buffIndex);
            }
            
        }
    }
}
