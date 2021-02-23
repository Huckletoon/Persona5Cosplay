using Terraria;
using Terraria.ModLoader;
using Persona5Cosplay.Buffs;
using System;
using Terraria.DataStructures;

namespace Persona5Cosplay
{
    public class P5Player : ModPlayer
    {
        public float attackSpeedMod = 0;
        public int equipmentTier = 0;
        public float thornPercent = 0f;
        public float dodgeChance = 0f;

        private Random rng = new Random();

        public override void PreUpdate()
        {
            attackSpeedMod = 0;
            thornPercent = 0f;
            base.PreUpdate();
        }

        public override void OnHitByNPC(NPC npc, int damage, bool crit)
        {
            if (thornPercent != 0f)
            {
                npc.StrikeNPC(Convert.ToInt32(damage * thornPercent), 0.5f, 1);
            }
        }

        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            //Dodge chance
            bool dodged = rng.NextDouble() <= dodgeChance;

            if (dodged) {
                player.NinjaDodge();
                damage = 0;
            }
            return !dodged;
        }

        public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
        {
            try
            {
                Item head = player.armor[0];
                Item torso = player.armor[1];
                Item legs = player.armor[2];

                if (!(head == null || torso == null || legs == null))
                {

                    //Mona Buff
                    if (torso.modItem.IsArmorSet(head, torso, legs) && (torso.Name.StartsWith("Mona") || torso.Name.StartsWith("Ultimate Mona")) && equipmentTier >= 3)
                    {
                        player.AddBuff(ModContent.BuffType<MonaBuff>(), 60 * 4 - 10);
                    }

                    //Queen Buff
                    if (torso.modItem.IsArmorSet(head, torso, legs) && (torso.Name.StartsWith("Queen") || torso.Name.StartsWith("Ultimate Queen")) && equipmentTier >= 3)
                    {
                        player.AddBuff(ModContent.BuffType<QueenBuff>(), 60 * 5);
                    }
                }
            } catch (Exception e) { }
            base.PostHurt(pvp, quiet, damage, hitDirection, crit);
        }

        public override float UseTimeMultiplier(Item item)
        {
            return 1 + attackSpeedMod;
        }
    }
}
