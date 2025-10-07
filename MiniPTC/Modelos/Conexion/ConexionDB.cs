using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.ConexionDB
{
    public class Conexion
    {
        public static string servidor = "(local)";
        public static string baseDeDatos = "TicketMiniPTC"; 

        public static SqlConnection conectar()
        {
            try
            {
                String cadena = $"Data Source={servidor};Initial Catalog={baseDeDatos};Integrated Security=True";
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar al servidor{servidor}", "Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool ValidarCredenciales(string nombre, string contrasena)
        {

            using (SqlConnection conexion = conectar())
            {
                if (conexion == null)
                {
                    return false;
                }



                string consulta = "SELECT COUNT (*) FROM Usuarios WHERE nombreUsuario = @nombre AND clave = @clave";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {

                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@clave", contrasena);

                    try
                    {
                        int count = (int)comando.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al ejecutar la validación: " + ex.Message, "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
    }
}
                   
                
