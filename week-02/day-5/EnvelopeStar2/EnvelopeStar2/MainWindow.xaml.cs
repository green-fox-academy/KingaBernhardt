using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace EnvelopeStar2
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            double x1 = foxDraw.Canvas.Width / 2;
            double y1 = 0;
            double x2 = foxDraw.Canvas.Width;
            double y2 = foxDraw.Canvas.Height / 2;
            EnvelopeStar(x1, y1, y2, x2);
        }
        public void EnvelopeStar(double x1, double y1, double y2, double x2)
        {
            var foxDraw = new FoxDraw(canvas);
            for (int i = 13; i < foxDraw.Canvas.Width/2; i += 13)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(x1, y2+i , x2 - i, y2);
                foxDraw.DrawLine(y1+i, y2, x1, y2+i);
                foxDraw.DrawLine(x2-i, y2, x1, y2 - i);
                foxDraw.DrawLine(y1+i, y2, x1, y2-i);
            }
        }
    }

}
