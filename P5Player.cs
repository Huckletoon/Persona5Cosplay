using Terraria;
using Terraria.ModLoader;
using System;

namespace Persona5Cosplay
{
    public class P5Player : ModPlayer
    {
        public float attackSpeedMod = 0;
        public int equipmentTier = 0;
        public float thornPercent = 0f;

        public override void PreUpdate()
        {
            attackSpeedMod = 0;
            thornPercent = 0f;
            //equipmentTier = 0;
        }

        public override void OnHitByNPC(NPC npc, int damage, bool crit)
        {
            if (thornPercent != 0f)
            {
                npc.StrikeNPC(Convert.ToInt32(damage * thornPercent), 0.5f, 1);
            }
        }

        public override float UseTimeMultiplier(Item item)
        {
            return 1 + attackSpeedMod;
        }
    }
}
