using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Modelos.ConexionDB;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Modelos.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string clave;
        private int idRol;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public int IdRol { get => idRol; set => idRol = value; }

        public static bool ExisteAdministrador()
        {
            using (SqlConnection con = Conexion.conectar())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE idRol = 1";
                SqlCommand cmd = new SqlCommand(query, con);
                int cantidad = (int)cmd.ExecuteScalar();
                return cantidad > 0;
            }
        }

        public static bool RegistrarUsuario(Usuario usuario)
        {
            using (SqlConnection con = Conexion.conectar())
            {
                string query = @"INSERT into Usuarios (nombreUsuario, clave, idRol) values (@usuario, @clave, @rol)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@clave", usuario.Clave); // Usar BCrypt
                cmd.Parameters.AddWithValue("@rol", usuario.IdRol);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable ObtenerUsuariosDT()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = Conexion.conectar())
            {
                string query = @"SELECT u.idUsuario AS [Usuario Número], 
                                u.nombreUsuario AS [Usuario], 
                                r.nombreRol AS [Rol]
                         FROM Usuarios u
                         INNER JOIN Roles r ON u.idRol = r.idRol";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tabla);
            }

            return tabla;
        }
        public static Usuario ValidarLogin(string nombreUsuario, string claveIngresada)
        {
            using (SqlConnection con = Conexion.conectar())
            {
                string query = @"SELECT idUsuario, nombreUsuario, clave, idRol FROM Usuarios WHERE nombreUsuario = @usuario";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usuario", nombreUsuario);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string claveHash = reader.GetString(2);

                    // Validar contraseña con la onda de BCrypt
                    if (BCrypt.Net.BCrypt.Verify(claveIngresada, claveHash))
                    {
                        return new Usuario
                        {
                            IdUsuario = reader.GetInt32(0),
                            NombreUsuario = reader.GetString(1),
                            Clave = claveHash,
                            IdRol = reader.GetInt32(3)
                        };
                    }
                }
            }

            return null; // si falla 
        }

        public static List<Usuario> ObtenerUsuariosPorRol(int idRol)
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection con = Conexion.conectar())
            {
                string query = @"SELECT idUsuario, nombreUsuario FROM Usuarios WHERE idRol = @rol";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@rol", idRol);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Usuario
                    {
                        IdUsuario = reader.GetInt32(0),
                        NombreUsuario = reader.GetString(1)
                    });
                }
            }
            return lista;
        }

    }
}