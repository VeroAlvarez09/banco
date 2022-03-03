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
using System.Windows.Shapes;

namespace ProyectoBanco
{
    /// <summary>
    /// Lógica de interacción para VentanaPrincipal.xaml
    /// </summary>
    public partial class VentanaPrincipal : Window
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void Empleado(object sender, RoutedEventArgs e)
        {
            Formulario formulario = new Formulario();
            formulario.tipoCliente.Text = "Empleado";
            formulario.LblCredito.Content = "Formulario de solicitud de credito Empleado";
            formulario.Porcentaje.Text = "0.5";
            formulario.AllowDrop = this.AllowDrop;
            formulario.Show();
        }

        private void Independiente(object sender, RoutedEventArgs e)
        {
            Formulario formulario = new Formulario();
            formulario.tipoCliente.Text = "Independiente";
            formulario.LblCredito.Content = "Formulario de solicitud de credito Independiente";
            formulario.Porcentaje.Text = "0.10";
            formulario.AllowDrop = this.AllowDrop;
            formulario.Show();
        }

        private void Pensionado(object sender, RoutedEventArgs e)
        {
            Formulario formulario = new Formulario();
            formulario.tipoCliente.Text = "Pensionado";
            formulario.LblCredito.Content = "Formulario de solicitud de credito Pensionado";
            formulario.Porcentaje.Text = "0.15";
            formulario.AllowDrop = this.AllowDrop;
            formulario.Show();
        }

        private void Desempleado(object sender, RoutedEventArgs e)
        {
            Formulario formulario = new Formulario();
            formulario.tipoCliente.Text = "Desempleado";
            formulario.LblCredito.Content = "Formulario de solicitud de credito Desempleado";
            formulario.Porcentaje.Text = "0.20";
            formulario.AllowDrop = this.AllowDrop;
            formulario.Show();
        }
    }
}
