namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;
    
    public class DoubleDamage: Specialty
    {
        //Fields
        private int roundsLeft;
        
        //Constructor
        public DoubleDamage(int rounds)
        {
            this.roundsLeft = rounds;
        }

        //Methods
        public override decimal ChangeDamageWhenAttacking(
            ICreaturesInBattle attackerWithSpecialty,
            ICreaturesInBattle defender,
            decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (this.roundsLeft <= 0)
            {
                // Effect expires after fixed number of rounds
                return currentDamage;
            }

            this.roundsLeft--;
            return currentDamage * 2M;
        }

        //		public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        //        {
        //            if (defender == null)
        //            {
        //                throw new ArgumentNullException("defender");
        //            }
        //
        //            if (attackerWithSpecialty == null)
        //            {
        //                throw new ArgumentNullException("attackerWithSpecialty");
        //            }
        //
        //            if (this.roundsLeft <= 0)
        //            {
        //                // Effect expires after fixed number of rounds
        //                return;
        //            }
        //
        //            defender. *= 2;
        //            this.roundsLeft--;
        //        }

        public override string ToString()
        {
            return string.Format(
                CultureInfo.InvariantCulture,
                "{0}({1})", this.GetType().Name, this.roundsLeft);
        }
    }
}
