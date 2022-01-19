﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Hero.HeroClasses
{
	public class WarriorHero : Hero
	{
		// Constructor
		public WarriorHero(string name) : base(name)
		{
			BasePrimaryAttributes = new PrimaryAttributes() { Strength = 5, Dexterity = 2, Intelligence = 1 };
			BasePrimaryAttributesGain = new PrimaryAttributes() { Strength = 3, Dexterity = 2, Intelligence = 1 };

			BasePrimaryAttributes = new PrimaryAttributes() { Strength = 5, Dexterity = 2, Intelligence = 1 };

			AllowedArmorTypes = new List<string> { ArmorType.ARMOR_MAIL, ArmorType.ARMOR_PLATE };
			AllowedWeaponTypes = new List<string> { WeaponType.WEAPON_AXE, WeaponType.WEAPON_HAMMER, WeaponType.WEAPON_SWORD };

		}

		// Methods
		public override int DealDamage()
		{
			throw new NotImplementedException();
		}
	}
}
