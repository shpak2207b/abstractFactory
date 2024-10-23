using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp4
{
    public class YellowTriangle : IShape
    {
        public void Draw(Canvas canvas)
        {
            Polygon triangle = new Polygon
            {
                Points = new PointCollection(new List<Point>
            {
                new Point(50, 0),   
                new Point(100, 100), 
                new Point(0, 100)    
            }),
                Fill = Brushes.Yellow
            };
            canvas.Children.Add(triangle);
        }
    }
}
