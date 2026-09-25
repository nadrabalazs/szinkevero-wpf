using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace szinkevero_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sliBlue.Value = 0;
            sliGreen.Value = 0;
            sliRed.Value = 0;
        }

        private void sliRed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ColorChanger();
        }

        private void sliGreen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ColorChanger();
        }

        private void sliBlue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ColorChanger();
        }
        private void ColorChanger()
        {
            byte red, green, blue;
            blue = Convert.ToByte(sliBlue.Value);
            green = Convert.ToByte(sliGreen.Value);
            red = Convert.ToByte(sliRed.Value);
            rctTeglalap.Fill = new SolidColorBrush(Color.FromRgb(red, green, blue));
            redValue.Content = red;
            blueValue.Content = blue;
            greenValue.Content = green;
        }
    }
}