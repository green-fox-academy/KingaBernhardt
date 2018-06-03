using System;
using System.Collections.Generic;
using System.Text;

namespace AirCraft
{
    class F16 : AirCrafts
    {
        private int ammo = 8;
        private int baseDamage = 30;

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
            return "F16";
        }

        public override string GetStatus()
        {
            return base.GetStatus();
        }

        public bool IsPriority()
        {
            return false;
        }
    }
}
