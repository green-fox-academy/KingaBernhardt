using System;
using System.Collections.Generic;
using System.Text;

namespace AirCraft
{
    class F35 : AirCrafts
    {
        private int ammo = 12;
        private int baseDamage = 50;

        public override int Fights()
        {
            return base.Fights();
        }

        public override int Refill(int givenNum)
        {
            return base.Refill(givenNum);
        }

        public override string GetType()
        {
            return "F35";
        }

        public override string GetStatus()
        {
            return base.GetStatus();
        }

        public bool IsPriority()
        {
            return true;
        }
    }
}
