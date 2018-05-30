using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{ 
    public abstract class StringedInstrument : Instrument
    {
        private int numberOfStrings;

        public abstract string Sound();
    }
}
