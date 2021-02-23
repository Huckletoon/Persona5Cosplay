﻿using Terraria;
using Terraria.ModLoader;

namespace Persona5Cosplay.Buffs
{
    class OracleBuff_Speed: ModBuff
    {

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Moral Support - Sukukaja");
            Description.SetDefault("Increased Speed");
            Main.debuff[Type] = false;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 0.25f;

        }
    }
}
