using GreenFox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColoredBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        // Draw a box that has different colored lines on each edge.

        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(100, 100, 100, 300);

            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(100, 100, 300, 100);

            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(100, 300, 300, 300);

            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(300, 300, 300, 100);


        }
    }
}
