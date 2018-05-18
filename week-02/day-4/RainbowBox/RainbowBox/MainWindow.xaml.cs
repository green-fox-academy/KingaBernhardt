using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace RainbowBox
{

    public partial class MainWindow : Window
    // Create a square drawing function that takes 2 parameters:
    // The square size, and the fill color,
    // and draws a square of that size and color to the center of the canvas.
    // Create a loop that fills the canvas with rainbow colored squares,
    // all squares should be centered, but growing in size

    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int a = 30;
            SquareRainbow(a);

            
        }
        public void SquareRainbow (int squareSide)
        {
            var foxDraw = new FoxDraw(canvas);
            Color[] squareColor = new Color[]{Colors.Cornsilk, Colors.Aqua, Colors.Beige, Colors.Pink, Colors.Purple, Colors.BlueViolet, Colors.DarkBlue, Colors.Red};
      
            for (int i = 7; i >= 1; i--)
            {
                foxDraw.FillColor(squareColor[i]);
                foxDraw.DrawRectangle(canvas.Width / 2 - (squareSide / 2)*i, canvas.Height / 2 - (squareSide / 2)*i, squareSide*i, squareSide*i);

            }
        }
        
    }

}
