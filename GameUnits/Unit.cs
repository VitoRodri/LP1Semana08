using System;

namespace GameUnits
{
    public abstract class Unit
    {
        public abstract float Cost {get;}
        private int movement;
        public virtual int Health {get; set;}

        public Unit(int movement, int health)
        {
            this.movement=movement;
            Health=health;
        }
        public string Move()
        {
            return $"Moved: {movement}";
        }
        public override string ToString()
        {
            return $"{Health} {Cost}";
        }
    }
}