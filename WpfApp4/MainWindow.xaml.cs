using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ColorFactory _currentFactory;

        public MainWindow()
        {
            InitializeComponent();
            _currentFactory = new RedFactory(); // По умолчанию
            DrawShape();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Очистка холста
            DrawingCanvas.Children.Clear();

            // Изменение фабрики в зависимости от выбранного цвета
            switch ((ColorComboBox.SelectedItem as ComboBoxItem)?.Content)
            {
                case "Red":
                    _currentFactory = new RedFactory();
                    break;
                case "Blue":
                    _currentFactory = new BlueFactory();
                    break;
                case "Yellow": // Добавлено для обработки желтого цвета
                    _currentFactory = new YellowFactory();
                    break;
            }
            DrawShape();
        }

        private void DrawShape()
        {
            IShape shape = _currentFactory.CreateShape();
            shape.Draw(DrawingCanvas);
        }
    }

}

