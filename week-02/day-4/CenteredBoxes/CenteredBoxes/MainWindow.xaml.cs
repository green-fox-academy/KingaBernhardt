using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace CenteredBoxes
{

    public partial class MainWindow : Window
    // create a square drawing function that takes 1 parameter:
    // the square size
    // and draws a square of that size to the center of the canvas.
    // draw 3 squares with that function.
    // avoid code duplication.

    {
        public MainWindow()
        {
            InitializeComponent();
            int a = 35;
            var foxDraw = new FoxDraw(canvas);
            

            Boxes(a);
        }
        public void Boxes(int squareSide)
        {
            var foxDraw = new FoxDraw(canvas);
           
            for (int i = 1; i < 4; i++)
            {
                foxDraw.FillColor(Colors.Transparent);
                foxDraw.DrawRectangle(canvas.Width / 2 - squareSide / 2, canvas.Height / 2 - squareSide / 2, squareSide, squareSide);
                squareSide += 50;
            }
        }
    }

}
