using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace FourRectangles
{

    public partial class MainWindow : Window
    // draw four different size and color rectangles.
    // avoid code duplication.

    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Color[] ShapeColor = new Color[] {Colors.Blue, Colors.Green, Colors.Honeydew, Colors.Gray};

                
            for (int i = 0; i < ShapeColor.Length; i++)
                {
                    foxDraw.FillColor(ShapeColor[i]);
                    foxDraw.DrawRectangle(10 * i, 10 * i, 20 * i, 40 * i);
                }
        }
    }

}
