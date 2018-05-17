using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace PositionSquare
{

    public partial class MainWindow : Window
    // create a square drawing function that takes 2 parameters:
    // the x and y coordinates of the square's top left corner
    // and draws a 50x50 square from that point.
    // draw 3 squares with that function.
    // avoid code duplication.

    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int x = 10;
            int y = 10;
            Square(x, y);  
        }

        public void Square (int xCoordinate, int YCoordinate)
        {
            var foxDraw = new FoxDraw(canvas);
            for (int i = 1; i < 4; i++)
            {
                foxDraw.DrawRectangle((xCoordinate+40)*i, (YCoordinate+40)*i, 50, 50);
            }
        }
    }

}
