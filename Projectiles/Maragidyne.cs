using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using System;
using Microsoft.Xna.Framework;

namespace Persona5Cosplay.Projectiles
{
    public class Maragidyne : ModProjectile
    {
        private float maxSpeed = 8f;
        private float homingRange = 175f;
        private float homingStrength = 0.6f;
        private int debuffChance = 4;
        private Random rng = new Random();

        public override void SetDefaults()
        {
            projectile.aiStyle = 0;
            projectile.magic = true;  
            projectile.friendly = true;

            projectile.penetrate = 2;

            //TODO
            projectile.width = 30;
            projectile.height = 30;
        }

        public override void AI()
        {
            //TODO

            //Rotate
            projectile.rotation += 0.5f * (float)projectile.direction;

            //Light
            Lighting.AddLight(projectile.Center, 0.6f, 0.1f, 0.1f);

            //Homing
            NPC closest = null;
            float distance = 5000f;
            foreach (NPC npc in Main.npc)
            {
                if (npc.friendly) continue;
                float tempDist = npc.Distance(projectile.position);
                if (tempDist < distance && tempDist <= homingRange)
                {
                    distance = tempDist;
                    closest = npc;
                }
            }
            if (closest != null)
            {
                if (!closest.active)
                {
                    closest = null;
                }
                else
                {
                    Vector2 homingDirection = closest.position - projectile.position;
                    homingDirection.Normalize();
                    projectile.velocity += homingDirection * homingStrength;
                    float tempSpeed = projectile.velocity.Length();
                    if (tempSpeed > maxSpeed)
                    {
                        projectile.velocity *= maxSpeed / tempSpeed;
                    }
                }
            }

            //Dust
            if (rng.Next() % 5 == 0) Dust.NewDust(projectile.position, projectile.width, projectile.height, 127, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 1.2f);
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            base.OnHitNPC(target, damage, knockback, crit);
            if (rng.Next() % debuffChance == 0) target.AddBuff(BuffID.OnFire, 60 * 5);
        }

    }
}
