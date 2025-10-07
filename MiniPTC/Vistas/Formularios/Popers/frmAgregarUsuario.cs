using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Modelos.ConexionDB;
using Modelos.Entidades;

namespace Vistas.Formularios.Popers
{
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();

            this.pbMostrar1.Click += new System.EventHandler(this.pbMostrar1_Click);
            this.pbMostrar2.Click += new System.EventHandler(this.pbMostrar2_Click);
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            this.Load += new System.EventHandler(this.frmAgregarUsuario_Load);

            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
            EstablecerLimites();
        }

        private void EstablecerLimites()
        {
            txtNombre.MaxLength = 90;
            txtApellido.MaxLength = 90;
            txtUsuario.MaxLength = 100;
            txtContrasena.MaxLength = 100;
            txtConfirmarContrasena.MaxLength = 100;
            txtDireccion.MaxLength = 20;
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CargarRoles()
        {
            try
            {
                using (SqlConnection con = Conexion.conectar())
                {
                    if (con != null)
                    {
                        string query = "SELECT idRol, nombreRol FROM Rol ORDER BY nombreRol";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                        DataTable dtRoles = new DataTable();
                        adapter.Fill(dtRoles);

                        cmbRol.DataSource = dtRoles;
                        cmbRol.DisplayMember = "nombreRol";
                        cmbRol.ValueMember = "idRol";
                        cmbRol.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarContrasena.Text) ||
                cmbRol.SelectedValue == null || cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debes completar todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Deben coincidir ambas contraseñas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtContrasena.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Usuario nuevoUsuario = new Usuario
                {
                    NombreUsuario = txtUsuario.Text.Trim(),
                    Clave = BCrypt.Net.BCrypt.HashPassword(txtContrasena.Text),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Telefono = txtDireccion.Text.Trim(),
                    Id_Rol = Convert.ToInt32(cmbRol.SelectedValue),
                    EstadoUsuario = true,
                    PrimerLogin = 0
                };

                if (nuevoUsuario.InsertarUsuario())
                {
                    MessageBox.Show("Usuario Registrado Exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    // Si retorna false, es porque hubo violación de UNIQUE KEY
                    MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void pbMostrar1_Click(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;
        }

        private void pbMostrar2_Click(object sender, EventArgs e)
        {
            txtConfirmarContrasena.UseSystemPasswordChar = !txtConfirmarContrasena.UseSystemPasswordChar;
        }

        private void lblApellido_Click(object sender, EventArgs e)
        {
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void btncerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}