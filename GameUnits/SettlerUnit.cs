using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit() : base(1,2)
        {
          public override float Cost
          {
            get
            {
                return 5;
            }
          }
      
        }
        public void Settle()
        {
            
        }
    }
}