using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace EnvelopeStar
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int step = 3;
            Star(step);
        }
        public void Star(int step)
        {
            var foxDraw = new FoxDraw(canvas);

            for (int i = 0; i <= foxDraw.Canvas.Width/2/step; i+=step)
            {
                foxDraw.DrawLine(foxDraw.Canvas.Width+i*step, foxDraw.Canvas.Height / 2, foxDraw.Canvas.Width / 2 + step, (foxDraw.Canvas.Height / 2)+i*step);
            }
            for (int j = 0; j <= foxDraw.Canvas.Width/2/step; j+=step)
            {
                foxDraw.DrawLine(foxDraw.Canvas.Width/2-j*step, foxDraw.Canvas.Height/2, foxDraw.Canvas.Width / 2 + step, foxDraw.Canvas.Height / 2 + step);
            }
            //foxDraw.DrawLine(foxDraw.Canvas.Width-i*step2,foxDraw.Canvas.Height, 0, foxDraw.Canvas.Height-i*step2);
            //foxDraw.DrawLine(j * step, 0, foxDraw.Canvas.Width, j * step);
        }
    }

}
