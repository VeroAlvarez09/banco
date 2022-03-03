using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;

namespace ProyectoBanco
{
    class ConexionBD
    {
        SqlConnection cnn;
        SqlCommand cmd;
        

        public ConexionBD()
        {
            try
            {
                cnn = new SqlConnection("Data Source=.;Initial Catalog=ProyectoBanco;Integrated Security=True");
                cnn.Open();
                MessageBox.Show("Conexion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la Base de Datos" + ex.ToString());
            }
        }

        public string insertar(string tipodocumento, int identificacion, string nombre, string apellidos, string rangoedad, int ingresos, int monto, int cuotas)
        {
            string salida = "Regisro realizado";
            try
            {
                cmd = new SqlCommand("Insert into Formulario(TipoDocumento,Identificacion,Nombre,Apellidos,RangoEdad,IngresosMensuales,MontoSolicitar,CantidadCuotas)values('" + tipodocumento + "', "+ identificacion +", '" + nombre + "','" + apellidos + "'," + rangoedad + ", " + ingresos + ", " + monto + ", " + cuotas + ") ", cnn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto" + ex.ToString();
            }
            return salida;
        }
    }
}
