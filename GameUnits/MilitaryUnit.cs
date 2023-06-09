using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower {get; }
        public int XP {get; private set;}

        public override int Health =>Health+XP;
        public override float Cost => AttackPower+XP;
        public void Attack( Unit u)
        {
            XP++;
            Health--;

        }
        public override string ToString()
        {
            return $"{Health} {Cost} {AttackPower} {XP}";
        }
    }
}