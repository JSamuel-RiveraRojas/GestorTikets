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
        public int ClienteId { get; set; }
        public int? IdTecnicoAsignado { get; set; }
        public int IdCategoria { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string Solucion { get; set; }

        // Campos para mostrar
        public string NombreCliente { get; set; }
        public string NombreTecnico { get; set; }
        public string NombreCategoria { get; set; }

        // CREATE
        public bool Insertar()
        {
            using (SqlConnection conexion = ConexionDB.Conexion.conectar())
            {
                string query = @"INSERT INTO Tickets (titulo, descripcion, clienteid, idTecnico_Asignado, idCategoria, estado, prioridad, solucion) 
                               VALUES (@titulo, @descripcion, @clienteId, @tecnicoId, @categoriaId, @estado, @prioridad, @solucion)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@titulo", this.Titulo);
                cmd.Parameters.AddWithValue("@descripcion", this.Descripcion);
                cmd.Parameters.AddWithValue("@clienteId", this.ClienteId);
                cmd.Parameters.AddWithValue("@tecnicoId", this.IdTecnicoAsignado ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@categoriaId", this.IdCategoria);
                cmd.Parameters.AddWithValue("@estado", this.Estado ?? "Abierto");
                cmd.Parameters.AddWithValue("@prioridad", this.Prioridad ?? "Media");
                cmd.Parameters.AddWithValue("@solucion", this.Solucion ?? (object)DBNull.Value);

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // READ
        public static DataTable ListarTodos()
        {
            using (SqlConnection conexion = ConexionDB.Conexion.conectar())
            {
                string query = @"SELECT 
                               t.idTicket, t.titulo, t.descripcion, 
                               c.nombre + ' ' + c.apellido as Cliente,
                               tec.nombre + ' ' + tec.apellido as Tecnico,
                               cat.nombre_Categoria as Categoria,
                               t.estado, t.prioridad, t.fechaCreacion,
                               t.fechaActualizacion, t.fechaCierre, t.solucion
                               FROM Tickets t
                               LEFT JOIN Usuarios c ON t.clienteid = c.idUsuario
                               LEFT JOIN Usuarios tec ON t.idTecnico_Asignado = tec.idUsuario
                               INNER JOIN Categorias cat ON t.idCategoria = cat.idCategoria
                               ORDER BY t.fechaCreacion DESC";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static Ticket ObtenerPorId(int idTicket)
        {
            using (SqlConnection conexion = ConexionDB.Conexion.conectar())
            {
                string query = @"SELECT 
                               t.idTicket, t.titulo, t.descripcion, t.clienteid, t.idTecnico_Asignado, 
                               t.idCategoria, t.estado, t.prioridad, t.fechaCreacion, t.fechaActualizacion, 
                               t.fechaCierre, t.solucion,
                               c.nombre + ' ' + c.apellido as NombreCliente,
                               tec.nombre + ' ' + tec.apellido as NombreTecnico,
                               cat.nombre_Categoria as NombreCategoria
                               FROM Tickets t
                               LEFT JOIN Usuarios c ON t.clienteid = c.idUsuario
                               LEFT JOIN Usuarios tec ON t.idTecnico_Asignado = tec.idUsuario
                               INNER JOIN Categorias cat ON t.idCategoria = cat.idCategoria
                               WHERE t.idTicket = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idTicket);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Ticket
                    {
                        IdTicket = reader.GetInt32(0),
                        Titulo = reader.GetString(1),
                        Descripcion = reader.GetString(2),
                        ClienteId = reader.GetInt32(3),
                        IdTecnicoAsignado = reader.IsDBNull(4) ? null : (int?)reader.GetInt32(4),
                        IdCategoria = reader.GetInt32(5),
                        Estado = reader.GetString(6),
                        Prioridad = reader.GetString(7),
                        FechaCreacion = reader.GetDateTime(8),
                        FechaActualizacion = reader.GetDateTime(9),
                        FechaCierre = reader.IsDBNull(10) ? null : (DateTime?)reader.GetDateTime(10),
                        Solucion = reader.IsDBNull(11) ? "" : reader.GetString(11),
                        NombreCliente = reader.GetString(12),
                        NombreTecnico = reader.IsDBNull(13) ? "" : reader.GetString(13),
                        NombreCategoria = reader.GetString(14)
                    };
                }
                return null;
            }
        }

        // UPDATE
        public bool Actualizar()
        {
            using (SqlConnection conexion = ConexionDB.Conexion.conectar())
            {
                string query = @"UPDATE Tickets SET 
                               titulo = @titulo, 
                               descripcion = @descripcion, 
                               clienteid = @clienteId, 
                               idTecnico_Asignado = @tecnicoId, 
                               idCategoria = @categoriaId, 
                               estado = @estado, 
                               prioridad = @prioridad, 
                               fechaActualizacion = GETDATE(),
                               fechaCierre = @fechaCierre,
                               solucion = @solucion 
                               WHERE idTicket = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@titulo", this.Titulo);
                cmd.Parameters.AddWithValue("@descripcion", this.Descripcion);
                cmd.Parameters.AddWithValue("@clienteId", this.ClienteId);
                cmd.Parameters.AddWithValue("@tecnicoId", this.IdTecnicoAsignado ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@categoriaId", this.IdCategoria);
                cmd.Parameters.AddWithValue("@estado", this.Estado);
                cmd.Parameters.AddWithValue("@prioridad", this.Prioridad);
                cmd.Parameters.AddWithValue("@fechaCierre", this.FechaCierre ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@solucion", this.Solucion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@id", this.IdTicket);

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // DELETE
        public static bool Eliminar(int idTicket)
        {
            using (SqlConnection conexion = ConexionDB.Conexion.conectar())
            {
                string query = "DELETE FROM Tickets WHERE idTicket = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idTicket);

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Métodos adicionales
        public static bool AsignarTecnico(int idTicket, int idTecnico)
        {
            using (SqlConnection conexion = ConexionDB.Conexion.conectar())
            {
                string query = @"UPDATE Tickets SET 
                               idTecnico_Asignado = @tecnicoId, 
                               estado = 'En Progreso',
                               fechaActualizacion = GETDATE()
                               WHERE idTicket = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@tecnicoId", idTecnico);
                cmd.Parameters.AddWithValue("@id", idTicket);

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool CambiarEstado(int idTicket, string estado, string solucion = null)
        {
            using (SqlConnection conexion = ConexionDB.Conexion.conectar())
            {   
                string query = @"UPDATE Tickets SET 
                               estado = @estado, 
                               solucion = @solucion,
                               fechaActualizacion = GETDATE(),
                               fechaCierre = CASE WHEN @estado = 'Cerrado' THEN GETDATE() ELSE fechaCierre END
                               WHERE idTicket = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@solucion", solucion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@id", idTicket);

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable ListarPorCliente(int idCliente)
        {
            using (SqlConnection conexion = ConexionDB.Conexion.conectar())
            {
                string query = @"SELECT 
                               t.idTicket, t.titulo, t.estado, t.prioridad, t.fechaCreacion,
                               cat.nombre_Categoria as Categoria,
                               tec.nombre + ' ' + tec.apellido as Tecnico
                               FROM Tickets t
                               LEFT JOIN Usuarios tec ON t.idTecnico_Asignado = tec.idUsuario
                               INNER JOIN Categorias cat ON t.idCategoria = cat.idCategoria
                               WHERE t.clienteid = @clienteId
                               ORDER BY t.fechaCreacion DESC";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@clienteId", idCliente);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable ListarPorTecnico(int idTecnico)
        {
            using (SqlConnection conexion = ConexionDB.Conexion.conectar())
            {
                string query = @"SELECT 
                               t.idTicket, t.titulo, t.estado, t.prioridad, t.fechaCreacion,
                               cat.nombre_Categoria as Categoria,
                               c.nombre + ' ' + c.apellido as Cliente
                               FROM Tickets t
                               INNER JOIN Usuarios c ON t.clienteid = c.idUsuario
                               INNER JOIN Categorias cat ON t.idCategoria = cat.idCategoria
                               WHERE t.idTecnico_Asignado = @tecnicoId
                               ORDER BY t.fechaCreacion DESC";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@tecnicoId", idTecnico);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}