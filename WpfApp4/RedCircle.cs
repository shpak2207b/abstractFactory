using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp4
{
    public class RedCircle : IShape
    {
        public void Draw(Canvas canvas)
        {
            Ellipse circle = new Ellipse
            {
                Width = 100,
                Height = 100,
                Fill = Brushes.Red
            };
            canvas.Children.Add(circle);
        }
    }
}
