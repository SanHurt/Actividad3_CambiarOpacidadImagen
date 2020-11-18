using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Actividad3_CambiarOpacidadImagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void altaRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.9;
        }

        private void mediaRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.6;
        }

        private void bajaRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Opacity = 0.4;
        }

        private void uniformeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.Uniform;
        }

        private void rellenoUniformeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.UniformToFill;
        }

        private void sinAjusteRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.None;
        }

        private void rellenoRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imagenImage.Stretch = Stretch.Fill;
        }
    }
}
