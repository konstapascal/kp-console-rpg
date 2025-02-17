﻿using ConsoleRPG.Attributes;
using ConsoleRPG.Inventory;
using ConsoleRPG.Items;
using System.Collections.Generic;

namespace ConsoleRPG.Hero.HeroClasses
{
	public class MageHero : Hero
	{
		// Constructor
		public MageHero(string name) : base(name)
		{
			BasePrimaryAttributes = new PrimaryAttributes() { Strength = 1, Dexterity = 1, Intelligence = 8 };
			BasePrimaryAttributesGain = new PrimaryAttributes() { Strength = 1, Dexterity = 1, Intelligence = 5 };

			AllowedWeaponTypes = new List<string> { WeaponType.WEAPON_STAFF, WeaponType.WEAPON_WAND };
			AllowedArmorTypes = new List<string> { ArmorType.ARMOR_CLOTH };
		}

		// Methods
		public override double CalculateDamage()
		{
			WeaponItem equippedWeapon = (WeaponItem)HeroEquipment.EquipmentSlots[Slots.SLOT_WEAPON];

			// Calculate damage per second of weapon, 1 if nothing equipped
			double damagePerSecond = (equippedWeapon is null) ? 1 : equippedWeapon.DamagePerSecond;
			double calculatedDamage = damagePerSecond * (1 + (double) TotalPrimaryAttributes.Intelligence / 100);

			return calculatedDamage;
		}
	}
}
