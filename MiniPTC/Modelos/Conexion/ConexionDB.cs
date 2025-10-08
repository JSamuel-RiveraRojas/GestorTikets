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
        public static string baseDeDatos = "SistemaTicketsMiniPTC"; 

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

    }
}
                   
                
