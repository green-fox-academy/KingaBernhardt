using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace CenteredSquare
{

    public partial class MainWindow : Window
    // Draw a green 10x10 square to the canvas' center.

    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawRectangle(395, 220, 10, 10);
        }
    }

}
