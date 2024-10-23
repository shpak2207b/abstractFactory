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
    public class BlueSquare : IShape
    {
        public void Draw(Canvas canvas)
        {
            Rectangle square = new Rectangle
            {
                Width = 100,
                Height = 100,
                Fill = Brushes.Blue
            };
            canvas.Children.Add(square);

        }
    }
}
