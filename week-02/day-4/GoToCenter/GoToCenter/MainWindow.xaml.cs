using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace GoToCenter
{

    public partial class MainWindow : Window
    // Create a line drawing function that takes 2 parameters:
    // The x and y coordinates of the line's starting point
    // and draws a line from that point to the center of the canvas.
    // Draw 3 lines with that function. Use loop for that.

    {
        public MainWindow()
        {
            var x = 100;
            var y = 300;
            InitializeComponent();
            ThreeLinesLoop(x,y);
            
        }
        public void ThreeLinesLoop(int x, int y)
        {

            var foxDraw = new FoxDraw(canvas);
            for (int i = 1; i < 4; i++)
            {
                foxDraw.DrawLine(x * i, y * i, canvas.Width / 2, canvas.Height / 2);

            }
        }
    }

}
