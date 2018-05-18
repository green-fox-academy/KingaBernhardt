using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace StarsNight
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Random = new Random();
            Random positionRandom = new Random();
            foxDraw.BackgroundColor(Colors.Black);
            foxDraw.FillColor(Colors.Yellow);
            
        }
        public void DrawManyRandomStars(int many)
        {
            byte randomColor = byte(Random.Next(255);
            FoxDraw.StrokeColor(Colors.Black)
            foxDraw.BackgroundColor(Colors.Black);
            foxDraw.FillColor(Colors.FromRgb());
            for (int i = 0; i < 200; i++)
            {
                foxDraw.DrawRectangle(positionRandom.Next((int)canvas.Width - 7), positionRandom.Next((int)canvas.Height - 7), 7, 7);
            }
        }
    }

}
