using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace Horizontal
{

    public partial class MainWindow : Window
    // Create a line drawing function that takes 2 parameters:
    // The x and y coordinates of the line's starting point
    // and draws a 50 long horizontal line from that point.
    // Draw 3 lines with that function. Use loop for that.

    {
        public MainWindow()
        {
            InitializeComponent();
            int x = 45;
            int y = 30;
            var foxDraw = new FoxDraw(canvas);
            Horizontal(x, y);

        }
        public void Horizontal(int x1, int y1)
        {
            var foxDraw = new FoxDraw(canvas);
            for (int i = 1; i < 4; i++)
            {
                foxDraw.DrawLine(x1, y1*i, x1+50, y1*i);
            }
        }
    }

}
