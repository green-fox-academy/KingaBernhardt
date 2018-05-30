using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
            name = "Bass Guitar";
        }
        public BassGuitar()
        {
            numberOfStrings = 4;
            name = "Bass Guitar";
        }

        public override void Play()
        {
            Console.WriteLine(name + " , a " + numberOfStrings + " - stringed instrument that " + Sound());
        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }
}
