using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int numberOfStrings)
        {
            name = "Electric Guitar";
            this.numberOfStrings = numberOfStrings;
        }
        public ElectricGuitar()
        {
            numberOfStrings = 6;
            name = "Electric Guitar";
        }
        public override void Play()
        {
            Console.WriteLine(name + " , a " + numberOfStrings + " - stringed instrument that " + Sound());
        }

        public override string Sound()
        {
            return "twangs";
        }
    }
}
