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

namespace Ejercicio1_AdivinarUnNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numeroAleatorio;
        public MainWindow()
        {
            InitializeComponent();
            numeroAleatorio = GeneraNumeroAleatorio();
        }

        private int GeneraNumeroAleatorio()
        {
            Random seed = new Random();
            
            return seed.Next(0, 101);
        }

        private void BotonComprobrar_Button_Click(object sender, RoutedEventArgs e)
        {
            int numIntroducido = int.Parse(nuemroIntroducido_TextBox.Text);

            if (numeroAleatorio == numIntroducido)
                mensaje_TextBlock.Text = "¡Has acertado!";
            else if (numeroAleatorio > numIntroducido)
                mensaje_TextBlock.Text = "Te has quedado corto";
            else
                mensaje_TextBlock.Text = "Te has pasado";
        }

        private void BotonReiniciar_Button_Click(object sender, RoutedEventArgs e)
        {
            numeroAleatorio = GeneraNumeroAleatorio();
            mensaje_TextBlock.Text = "";
            nuemroIntroducido_TextBox.Text = "";
        }
    }
}
