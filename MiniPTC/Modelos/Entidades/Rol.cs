using Modelos.ConexionDB;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Modelos.Entidades
{
    public class Rol
    {

        private int idRol;
        private string nombreRol;

        public int IdRol { get => idRol; set => idRol = value; }
        public string NombreRol { get => nombreRol; set => nombreRol = value; }

        //roles para el combobox de usuarios
        public static List<Rol> ObtenerRoles()
        {
            List<Rol> lista = new List<Rol>();
            using (SqlConnection con = Conexion.conectar())
            {
                string query = "SELECT idRol, nombreRol FROM Roles";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Rol
                    {
                        IdRol = reader.GetInt32(0),
                        NombreRol = reader.GetString(1)
                    });
                }
            }
            return lista;
        }


    }
}
