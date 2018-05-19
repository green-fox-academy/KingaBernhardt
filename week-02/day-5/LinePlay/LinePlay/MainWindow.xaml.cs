using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace LinePlay
{
    public partial class MainWindow : Window
    {
        FoxDraw foxDraw;
        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            int step = 3;
            foxDraw.StrokeColor(Colors.Aqua);
            Line(step);
            foxDraw.StrokeColor(Colors.Red);
            Lines2(step);   
        }
        public void Line(int step)
        {
            for (int j = 0; j <= foxDraw.Canvas.Width/step; j+=step)
            {
                foxDraw.DrawLine(j*step, 0, foxDraw.Canvas.Width, j*step);
            }
        }
        public void Lines2(int step2)
        {
            for (int i = 0; i <= foxDraw.Canvas.Width/step2; i+=step2)
            {
                foxDraw.DrawLine(foxDraw.Canvas.Width-i*step2,foxDraw.Canvas.Height, 0, foxDraw.Canvas.Height-i*step2);
            }
        }
    }
}
