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
    public class Tecnicos
    {
        public int IdTecnico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Especialidad { get; set; }

        public bool Agregar()
        {
            using (SqlConnection con = Conexion.conectar())
            {
                string query = @"INSERT INTO Tecnicos (idTecnico, nombre, apellido, telefono, especialidad)
                             VALUES (@id, @nombre, @apellido, @telefono, @especialidad)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", IdTecnico);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@apellido", Apellido);
                cmd.Parameters.AddWithValue("@telefono", Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@especialidad", Especialidad ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool Editar()
        {
            using (SqlConnection con = Conexion.conectar())
            {
                string query = @"UPDATE Tecnicos SET nombre = @nombre, apellido = @apellido,
                             telefono = @telefono, especialidad = @especialidad
                             WHERE idTecnico = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", IdTecnico);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@apellido", Apellido);
                cmd.Parameters.AddWithValue("@telefono", Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@especialidad", Especialidad ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }


        public static bool Eliminar(int idTecnico)
        {
            using (SqlConnection con = Conexion.conectar())
            {
                string query = "DELETE FROM Tecnicos WHERE idTecnico = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idTecnico);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = Conexion.conectar())
            {
                string query = @"SELECT t.idTecnico, t.nombre, t.apellido, t.telefono, t.especialidad,
                             u.nombreUsuario AS Usuario
                             FROM Tecnicos t
                             INNER JOIN Usuarios u ON t.idTecnico = u.idUsuario";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(tabla);
            }
            return tabla;
        }
    }
}
