﻿namespace ArmyOfCreatures.Extended.Creatures
{
	using System;
	using ArmyOfCreatures.Extended.Specialties;
	using ArmyOfCreatures.Logic.Creatures;
	using ArmyOfCreatures.Logic.Specialties;
	
	public class Griffin: Creature
	{
		public Griffin()
		: base(8, 8, 25, 4.5m)
        {
			this.AddSpecialty(new DoubleDefenseWhenDefending(5));
			this.AddSpecialty(new AddDefenseWhenSkip(3));
			this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
	}
}