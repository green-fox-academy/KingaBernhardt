using System;
using System.Collections.Generic;
using System.Text;

namespace PostIt
{
    class PostIt
    {
        public string backgroundcolor;
        public string text;
        public string textColor;

        public PostIt(string backgroundcolor, string text, string textColor)
        {
            this.backgroundcolor = backgroundcolor;
            this.text = text;
            this.textColor = textColor;
        }
    }
}
