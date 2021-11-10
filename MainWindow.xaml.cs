using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Superheroe superheroe = Superheroe.GetSamples()[0];
        int numeroSuperheroes = Superheroe.GetSamples().Count;
        int superHeroeActual = 0;
        public MainWindow()
        {
            InitializeComponent();
            DockPanelPrincipal.DataContext = superheroe;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) //click en las flechas para cambiar entre superheroes
        {
            if(superHeroeActual < numeroSuperheroes-1)
            {
                superHeroeActual++;
                DockPanelPrincipal.DataContext = Superheroe.GetSamples()[superHeroeActual];
                NumeroImagen_TextBlock.Text = (superHeroeActual + 1) + "/3";
            }
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (superHeroeActual != 0)
            {
                superHeroeActual--;
                DockPanelPrincipal.DataContext = Superheroe.GetSamples()[superHeroeActual];
                NumeroImagen_TextBlock.Text = (superHeroeActual + 1) + "/3";
            }
        }
    }
}
