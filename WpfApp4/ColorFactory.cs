using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public class RedFactory : ColorFactory
    {
        public override IShape CreateShape() => new RedCircle();
    }

    public class BlueFactory : ColorFactory
    {
        public override IShape CreateShape() => new BlueSquare();
    }
    public class YellowFactory : ColorFactory
    {
        public override IShape CreateShape() => new YellowTriangle();
    }
}
