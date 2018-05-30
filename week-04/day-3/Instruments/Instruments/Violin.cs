using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        public Violin(int numberOfStrings)
        {
            name = "Violin";
        }
        public Violin()
        {
            name = "Violin";
            numberOfStrings = 4;
        }

        public override void Play()
        {
            Console.WriteLine(name + " , a " + numberOfStrings + " -stringed instrument that " + Sound());
        }

        public override string Sound()
        {
            return "screeches";
        }
    }
}
