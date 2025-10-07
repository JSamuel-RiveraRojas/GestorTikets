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
        private bool estadoUsuario;
        private int id_Rol;
        private int primerLogin;
        private string nombre;
        private string apellido;
        private string telefono;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public bool EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
        public int Id_Rol { get => id_Rol; set => id_Rol = value; }
        public int PrimerLogin { get => primerLogin; set => primerLogin = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public Usuario() { }

        public bool VerificarLogin(string nombreusuario, string clave)
        {
            try
            {
                string hashEnBaseDeDatos = "";
                SqlConnection con = Conexion.conectar();
                string query = "Select clave from Usuarios Where nombreUsuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Usuario", nombreusuario);

                if (cmd.ExecuteScalar() == null)
                {
                    return false;
                }
                else
                {
                    hashEnBaseDeDatos = cmd.ExecuteScalar().ToString();
                    return BCrypt.Net.BCrypt.Verify(clave, hashEnBaseDeDatos);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int IdentificarRol(string nombreusuario)
        {
            try
            {
                int id_Rol;
                SqlConnection con = Conexion.conectar();
                string query = "Select id_Rol from Usuarios Where nombreUsuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Usuario", nombreusuario);
                id_Rol = Convert.ToInt32(cmd.ExecuteScalar());
                return id_Rol;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static DataTable CargarUsuario()
        {
            SqlConnection conexion = Conexion.conectar();
            string consultaQuery = "SELECT * FROM Vista_Usuarios_Completa";
            SqlDataAdapter ad = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public static void MostrarUsuarioBuscar(DataGridView dgv, string textoBuscar)
        {
            try
            {
                SqlConnection con = Conexion.conectar();
                string consulta = "SELECT Usuarios.idUsuario AS [N°], Usuarios.nombreUsuario AS [Usuario], Rol.nombreRol AS [Rol], " +
                                  "CASE estadoUsuario WHEN 0 THEN 'ACTIVO' WHEN 1 THEN 'INACTIVO' END AS [Estado] " +
                                  "FROM Usuarios " +
                                  "INNER JOIN Rol ON Usuarios.id_Rol = Rol.idRol " +
                                  "WHERE Usuarios.nombreUsuario LIKE @buscar";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                adaptador.SelectCommand.Parameters.AddWithValue("@buscar", "%" + textoBuscar + "%");

                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool InsertarUsuario()
        {
            try
            {
                using (SqlConnection con = Conexion.conectar())
                {
                    string comando = "INSERT INTO Usuarios(nombreUsuario, clave, estadoUsuario, id_Rol, primerLogin, nombre, apellido, telefono) " +
                                     "VALUES (@nombreUsuario, @clave, @estadoUsuario, @id_Rol, @primerLogin, @nombre, @apellido, @telefono);";
                    using (SqlCommand cmd = new SqlCommand(comando, con))
                    {
                        cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@clave", clave);
                        cmd.Parameters.AddWithValue("@estadoUsuario", estadoUsuario);
                        cmd.Parameters.AddWithValue("@id_Rol", id_Rol);
                        cmd.Parameters.AddWithValue("@primerLogin", primerLogin);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@telefono", telefono ?? (object)DBNull.Value);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool ActualizarUsuario()
        {
            try
            {
                SqlConnection conexion = Conexion.conectar();
                string consultaUpdate = "UPDATE Usuarios SET nombreUsuario = @nombreUsuario, estadoUsuario = @estadoUsuario, " +
                                        "id_Rol = @id_Rol, nombre = @nombre, apellido = @apellido, telefono = @telefono " +
                                        "WHERE idUsuario = @idUsuario";
                SqlCommand actualizar = new SqlCommand(consultaUpdate, conexion);
                actualizar.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                actualizar.Parameters.AddWithValue("@estadoUsuario", estadoUsuario);
                actualizar.Parameters.AddWithValue("@id_Rol", id_Rol);
                actualizar.Parameters.AddWithValue("@nombre", nombre);
                actualizar.Parameters.AddWithValue("@apellido", apellido);
                actualizar.Parameters.AddWithValue("@telefono", telefono ?? (object)DBNull.Value);
                actualizar.Parameters.AddWithValue("@idUsuario", IdUsuario);
                actualizar.ExecuteNonQuery();
                MessageBox.Show("Datos Actualizados", "Actualizar");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos" + ex);
                return false;
            }
        }

        public static DataTable BuscarUsuario(string termino)
        {
            SqlConnection conn = Conexion.conectar();
            string comando = "SELECT Usuarios.idUsuario, Usuarios.nombreUsuario As [Nombre], Rol.nombreRol As [Rol], " +
                             "Usuarios.clave As [Clave], CASE estadoUsuario WHEN 0 THEN 'ACTIVO' WHEN 1 THEN 'INACTIVO' END As [Estado] " +
                             "FROM Usuarios INNER JOIN Rol ON Usuarios.id_Rol = Rol.idRol " +
                             "WHERE Usuarios.nombreUsuario LIKE '%' + @termino + '%'";
            SqlDataAdapter ad = new SqlDataAdapter(comando, conn);
            ad.SelectCommand.Parameters.AddWithValue("@termino", termino);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public static string ClaveEnMemoria { get; set; }

        public bool ActualizarClaveUsuario()
        {
            try
            {
                SqlConnection conexion = Conexion.conectar();
                string consultaUpdate = "Update Usuarios set clave = @clave, primerLogin = 1 where nombreUsuario = @nombre";
                SqlCommand actualizar = new SqlCommand(consultaUpdate, conexion);
                actualizar.Parameters.AddWithValue("@nombre", nombreUsuario);
                actualizar.Parameters.AddWithValue("@clave", clave);
                actualizar.ExecuteNonQuery();
                MessageBox.Show("Datos Actualizados", "Actualizar");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos" + ex);
                return false;
            }
        }

        public static int IdentificarPrimerLogin(string usuario)
        {
            try
            {
                int primerLogin;
                SqlConnection con = Conexion.conectar();
                string query = "Select primerLogin from Usuarios Where nombreUsuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Usuario", usuario);
                primerLogin = Convert.ToInt32(cmd.ExecuteScalar());
                return primerLogin;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al identificar el inicio de sesión" + ex, "Error");
                return -1;
            }
        }

        public static bool VerificarCorreo(string nombreusuario)
        {
            try
            {
                using (SqlConnection con = Conexion.conectar())
                {
                    string query = "SELECT COUNT(1) FROM Usuarios WHERE nombreUsuario = @Usuario";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", nombreusuario.Trim());

                        object result = cmd.ExecuteScalar();
                        int count = result != null ? Convert.ToInt32(result) : 0;

                        return count > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool HayUsuariosRegistrados()
        {
            bool existenUsuarios = false;
            try
            {
                using (SqlConnection conn = Conexion.conectar())
                {
                    if (conn != null)
                    {
                        string query = "SELECT COUNT(*) FROM Usuarios";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        int count = (int)cmd.ExecuteScalar();
                        existenUsuarios = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return existenUsuarios;
        }

        public static int IdentificarEstado(string nombreusuario)
        {
            try
            {
                SqlConnection con = Conexion.conectar();
                string query = "Select estadoUsuario from Usuarios Where nombreUsuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Usuario", nombreusuario);

                int estado = Convert.ToInt32(cmd.ExecuteScalar());
                return estado;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}