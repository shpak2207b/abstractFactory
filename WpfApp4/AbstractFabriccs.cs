using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public interface AbstractFabriccs
    {
        IShape CreateShape();
    }

    // Интерфейс для фигур
    public interface IShape
    {
        void Draw(System.Windows.Controls.Canvas canvas);
      
    }

    // Абстрактная фабрика для цветов
    public abstract class ColorFactory : AbstractFabriccs
    {
        public abstract IShape CreateShape();
    }
}