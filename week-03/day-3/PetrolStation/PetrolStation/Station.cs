using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    class Station
    {
        public int gasAmountOfStation = 1000;

        public void Refill(Car theCar)
        {
            theCar.gasAmountOfCar += 5;
            gasAmountOfStation -= 5;
        }
    }
}
