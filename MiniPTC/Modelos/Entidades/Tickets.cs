using System;
using System.Data;
using System.Data.SqlClient;
using Modelos.ConexionDB;

namespace Modelos.Entidades
{
    public class Ticket
    {
        public int IdTicket { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int IdCliente { get; set; }
        public int IdCategoria { get; set; }
        public int? IdTecnico { get; set; } 
        public string Estado { get; set; }
        public string Prioridad { get; set; }

        public bool Crear()
        {
            using (SqlConnection con = Conexion.conectar())
            {
                string query = @"INSERT INTO Tickets (titulo, descripcion, idCliente, idCategoria, idTecnico, estado, prioridad)
                             VALUES (@titulo, @descripcion, @cliente, @categoria, NULL, @estado, @prioridad)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@titulo", Titulo);
                cmd.Parameters.AddWithValue("@descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@cliente", IdCliente);
                cmd.Parameters.AddWithValue("@categoria", IdCategoria);
                cmd.Parameters.AddWithValue("@estado", Estado);
                cmd.Parameters.AddWithValue("@prioridad", Prioridad);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}