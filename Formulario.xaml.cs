using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoBanco
{
    /// <summary>
    /// Lógica de interacción para Formulario.xaml
    /// </summary>
    public partial class Formulario : Window
    {
        
        public Formulario()
        {
            InitializeComponent();
        }

        private void Sulicitud(object sender, RoutedEventArgs e)
        {
            ConexionBD c = new ConexionBD();
            InfoSolicitud solicitud = new InfoSolicitud();
            if(TipoDoc.Text != "" && Documento.Text != "" && Nombres.Text != ""
                && Apellidos.Text != "" && RangoEdad.Text != "" && IngresosMensuales.Text != "" 
                && MontoSolicitar.Text != "" && Cuotas.Text != "")
            {
                solicitud.LblTipoDoc.Content = TipoDoc.Text;
                solicitud.LblDoc.Content = Documento.Text;
                solicitud.LblNombres.Content = Nombres.Text;
                solicitud.LblApellidos.Content = Apellidos.Text;
                solicitud.LblRangoEdad.Content = RangoEdad.Text;
                solicitud.LblIngresos.Content = IngresosMensuales.Text;
                solicitud.LblMonto.Content = MontoSolicitar.Text;
                solicitud.LblCuotas.Content = Cuotas.Text;
                solicitud.LblPorcentaje.Content = Porcentaje.Text;

                float valorPorcentaje = (float.Parse(Porcentaje.Text) * float.Parse(MontoSolicitar.Text)) / float.Parse(Cuotas.Text);
                float total = valorPorcentaje + float.Parse(MontoSolicitar.Text);
                float totalCuota = total / float.Parse(Cuotas.Text);

                solicitud.LblTotal.Content = total;
                solicitud.LblTotalCuota.Content = totalCuota;

                /// Aqui se deben almacenar los datos en la base de datos.

                c.insertar(TipoDoc.Text, Convert.ToInt32(Documento.Text), Nombres.Text, Apellidos.Text, RangoEdad.Text, Convert.ToInt32(IngresosMensuales.Text), Convert.ToInt32(MontoSolicitar.Text), Convert.ToInt32(Cuotas.Text));

                TipoDoc.Text = "";
                Documento.Text = "";
                Nombres.Text = "";
                Apellidos.Text = "";
                RangoEdad.Text = "";
                IngresosMensuales.Text = "";
                MontoSolicitar.Text = "";
                Cuotas.Text = "";

                solicitud.AllowDrop = this.AllowDrop;
                solicitud.Show();
            }
            else
            {
                MessageBox.Show("Todos los datos son obligatorios.");
            }

        }
    }
}
