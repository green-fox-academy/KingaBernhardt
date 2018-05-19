using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace Diagonals
{

    public partial class MainWindow : Window
    // Draw the canvas' diagonals.
    // If it starts from the upper-left corner it should be green, otherwise it should be red.
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);


            foxDraw.StrokeColor(Colors.Green);
            var startPoint = new Point(0, 0);
            var endPoint = new Point(canvas.Width, canvas.Height);
            foxDraw.DrawLine(startPoint, endPoint);

            foxDraw.StrokeColor(Colors.Red);
            var startPoint2 = new Point(canvas.Width,0);
            var endPoint2 = new Point(0, canvas.Height);
            foxDraw.DrawLine(startPoint2, endPoint2);
        }
    }

}
