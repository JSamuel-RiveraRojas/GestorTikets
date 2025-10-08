using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmGestorUsuarios : Form
    {
        public frmGestorUsuarios()
        {
            
            InitializeComponent();
            CargarRoles();
        }

        #region "Metodos"

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario
            {
                NombreUsuario = txtUsuario.Text,
                Clave = BCrypt.Net.BCrypt.HashPassword(txtClave.Text),
                IdRol = (int)cmbRol.SelectedValue
            };

            if (Usuario.RegistrarUsuario(nuevo))
            {
                

                if (nuevo.IdRol == 1)
                {
                    MessageBox.Show("Administrador creado correctamente");
                    this.Hide();
                    new frmLogin().Show();
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show("Usuario creado, pero no es administrador.");
                    CargarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Error al crear el usuario");
            }
        }

        private void CargarUsuarios()
        {
            dgvVer_Usuarios.DataSource = Usuario.ObtenerUsuariosDT();
        }

        //cargar roles en el combobox desde la clase Rol
        private void CargarRoles()
        {
            cmbRol.DataSource = Rol.ObtenerRoles();
            cmbRol.DisplayMember = "nombreRol";
            cmbRol.ValueMember = "idRol";
            cmbRol.SelectedIndex = -1; // No seleccionar ningún rol por defecto
        }

        private void frmGestorUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarRoles();
        }
    }
}


