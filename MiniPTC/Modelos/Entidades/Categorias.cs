using Modelos.ConexionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Categorias
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        public bool Agregar()
        {
            using (SqlConnection con = Conexion.conectar())
            {
                string query = @"INSERT INTO Categorias (nombreCategoria, descripcion)
                             VALUES (@nombre, @descripcion)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", NombreCategoria);
                cmd.Parameters.AddWithValue("@descripcion", Descripcion ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Editar()
        {
            using (SqlConnection con = Conexion.conectar())
            {
                string query = @"UPDATE Categorias SET nombreCategoria = @nombre, descripcion = @descripcion
                             WHERE idCategoria = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", IdCategoria);
                cmd.Parameters.AddWithValue("@nombre", NombreCategoria);
                cmd.Parameters.AddWithValue("@descripcion", Descripcion ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool Eliminar(int idCategoria)
        {
            using (SqlConnection con = Conexion.conectar())
            {
                string query = "DELETE FROM Categorias WHERE idCategoria = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idCategoria);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable ObtenerTodas()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = Conexion.conectar())
            {
                string query = "SELECT idCategoria, nombreCategoria, descripcion FROM Categorias";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(tabla);
            }
            return tabla;
        }
    }
}
