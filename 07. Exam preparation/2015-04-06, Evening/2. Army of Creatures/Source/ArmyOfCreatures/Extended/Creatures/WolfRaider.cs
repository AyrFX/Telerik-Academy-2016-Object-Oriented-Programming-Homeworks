﻿namespace ArmyOfCreatures.Extended.Creatures
{
	using System;
	using ArmyOfCreatures.Extended.Specialties;
	using ArmyOfCreatures.Logic.Creatures;
	
	public class WolfRaider: Creature
	{
		public WolfRaider()
			: base(8, 5, 10, 3.5m)
        {
			this.AddSpecialty(new DoubleDamage(7));
        }
	}
}
