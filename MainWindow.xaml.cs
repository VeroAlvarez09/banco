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

namespace ProyectoBanco
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Inicio(object sender, RoutedEventArgs e)
        {
            string user = "Veronica", pass = "Veronica";

            if (User.Text == user && Pass.Password == pass)
            {
                VentanaPrincipal principal = new VentanaPrincipal();
                principal.AllowDrop = this.AllowDrop;
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario invalido.");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
