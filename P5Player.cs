using Terraria;
using Terraria.ModLoader;

namespace Persona5Cosplay
{
    public class P5Player : ModPlayer
    {
        public float attackSpeedMod = 0;

        public override void PreUpdate()
        {
            attackSpeedMod = 0;
        }

        public override float UseTimeMultiplier(Item item)
        {
            return 1 + attackSpeedMod;
        }
    }
}
