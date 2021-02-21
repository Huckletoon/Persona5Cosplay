using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Persona5Cosplay.Items
{
	//[AutoloadEquip(EquipType.Back)]
	public class RebelliousSpirit: ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The spark of rebellion in one's soul\nIncreases critical chance, defense, health, and mana\nEffect increases based on equipped Phantom Thief armor");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 32;
			item.accessory = true;
			item.value = 0;
			item.rare = ItemRarityID.Expert;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 20);
			recipe.AddRecipeGroup("Persona5Cosplay:GoldBars", 20);
			recipe.AddIngredient(ItemID.Diamond, 10);
			recipe.AddIngredient(ItemID.Sapphire, 10);
			recipe.AddIngredient(ItemID.Emerald, 10);
			recipe.AddIngredient(ItemID.Ruby, 30);
			recipe.AddIngredient(ItemID.Torch, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			int tier = -1;
			try
			{
				Item head = player.armor[0];
				Item torso = player.armor[1];
				Item legs = player.armor[2];
				if ((head != null && torso != null && legs != null) && (torso.Name != "" && head.Name != "" && legs.Name != "")) {
					if (torso.modItem.IsArmorSet(head, torso, legs))
					{
						string armorName = torso.Name;
						string tierIndic = armorName.Substring(armorName.Length - 2);
						if (tierIndic.StartsWith("T"))
						{
							tier = Int32.Parse(tierIndic.Substring(1));
						} else if (armorName.StartsWith("Ultimate"))
						{
							tier = 7;
						}
					}
				}
			} catch (Exception e) {
				mod.Logger.Error(e);
			}
			player.statDefense += 3 + (tier * 2);
			switch(tier)
			{
				case 0:
					player.magicCrit += 5;
					player.meleeCrit += 5;
					player.rangedCrit += 5;
					player.thrownCrit += 5;
					player.statManaMax2 += 10;
					player.statLifeMax2 += 10;
					break;
				case 1:
					player.magicCrit += 8;
					player.meleeCrit += 8;
					player.rangedCrit += 8;
					player.thrownCrit += 8;
					player.statManaMax2 += 20;
					player.statLifeMax2 += 20;
					break;
				case 2:
					player.magicCrit += 11;
					player.meleeCrit += 11;
					player.rangedCrit += 11;
					player.thrownCrit += 11;
					player.statManaMax2 += 20;
					player.statLifeMax2 += 20;
					break;
				case 3:
					player.magicCrit += 14;
					player.meleeCrit += 14;
					player.rangedCrit += 14;
					player.thrownCrit += 14;
					player.statManaMax2 += 30;
					player.statLifeMax2 += 30;
					break;
				case 4:
					player.magicCrit += 20;
					player.meleeCrit += 20;
					player.rangedCrit += 20;
					player.thrownCrit += 20;
					player.statManaMax2 += 50;
					player.statLifeMax2 += 50;
					break;
				case 5:
					player.magicCrit += 25;
					player.meleeCrit += 25;
					player.rangedCrit += 25;
					player.thrownCrit += 25;
					player.statManaMax2 += 80;
					player.statLifeMax2 += 80;
					break;
				case 6:
					player.magicCrit += 28;
					player.meleeCrit += 28;
					player.rangedCrit += 28;
					player.thrownCrit += 28;
					player.statManaMax2 += 140;
					player.statLifeMax2 += 140;
					break;
				case 7:
					player.magicCrit += 35;
					player.meleeCrit += 35;
					player.rangedCrit += 35;
					player.thrownCrit += 35;
					player.statManaMax2 += 200;
					player.statLifeMax2 += 200;
					break;
			}
		}
	}
}
