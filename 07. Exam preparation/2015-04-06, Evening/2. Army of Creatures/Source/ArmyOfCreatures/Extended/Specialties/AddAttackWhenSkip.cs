namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;
    
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;
    
    public class AddAttackWhenSkip: Specialty
    {
        private int attackToAdd;

        public AddAttackWhenSkip(int attackToAdd)
        {
            if (attackToAdd < 1 || attackToAdd > 20)
            {
                throw new ArgumentOutOfRangeException("attackToAdd", "attackToAdd should be between 1 and 20, inclusive");
            }

            this.attackToAdd = attackToAdd;
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            //skipCreature.PermanentDefense += this.attackToAdd;
            //skipCreature.CurrentAttack += this.attackToAdd;
            skipCreature.PermanentAttack += this.attackToAdd;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.attackToAdd);
        }
    }
}
