using Terraria;
using Terraria.ModLoader;
using Persona5Cosplay.Buffs;
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

        public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
        {
            Item head = player.armor[0];
            Item torso = player.armor[1];
            Item legs = player.armor[2];
            if (torso.modItem.IsArmorSet(head, torso, legs) && torso.Name.StartsWith("Mona") && equipmentTier >= 3){
                player.AddBuff(ModContent.BuffType<MonaBuff>(), 60 * 4 - 10);
            }
            base.PostHurt(pvp, quiet, damage, hitDirection, crit);
        }

        public override float UseTimeMultiplier(Item item)
        {
            return 1 + attackSpeedMod;
        }
    }
}
