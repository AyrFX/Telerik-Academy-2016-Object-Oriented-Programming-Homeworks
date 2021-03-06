﻿namespace ArmyOfCreatures.Extended.Specialties
{
	using System;
	using System.Globalization;
	using ArmyOfCreatures.Logic.Battles;
	using ArmyOfCreatures.Logic.Specialties;
	
	public class DoubleAttackWhenAttacking: Specialty
	{
		//Fields
		private int rounds;
		
		//Constructros
		public DoubleAttackWhenAttacking(int rounds)
        {
            if (rounds <= 0)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0");
            }

            this.rounds = rounds;
        }
		
		//Methods
		public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {
			if (rounds <= 0)
			{
				return;
			}
			attackerWithSpecialty.CurrentAttack *= 2;
			this.rounds--;
        }
		
		public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
	}
}
