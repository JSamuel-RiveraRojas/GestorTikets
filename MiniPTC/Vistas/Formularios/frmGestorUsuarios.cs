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
using Vistas.Formularios.Popers;

namespace Vistas.Formularios
{
    public partial class frmGestorUsuarios : Form
    {
        public frmGestorUsuarios()
        {
            InitializeComponent();

            MostrarUsuarios();

            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
        }

        #region "Metodos"

        public void MostrarUsuarios(string filtro = "")
        {
            try
            {
                dgvVer_Usuarios.DataSource = null;

                if (string.IsNullOrEmpty(filtro))
                {

                    dgvVer_Usuarios.DataSource = Usuario.CargarUsuario();
                }
                else
                {


                    //dgvVer_Usuarios.DataSource = Usuario.BuscarUsuarios(filtro);
                }


                dgvVer_Usuarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvVer_Usuarios.DataSource = null;
            }
        }

        #endregion

        private void btnAgragarUsuario_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario agregarUsuario = new frmAgregarUsuario();
            agregarUsuario.ShowDialog();


            MostrarUsuarios();
        }



        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {

            MostrarUsuarios(txtBuscarUsuario.Text.Trim());
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNEditarUsuario_Click_1(object sender, EventArgs e)
        {

            if (dgvVer_Usuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvVer_Usuarios.SelectedRows[0];

                //      return new Usuario
                //      {
                //          IdUsuario = Convert.ToInt32(fila.Cells["idUsuario"].Value),
                //          //NombreUsuario = fila.Cells["nombreUsuario"].Value?.ToString(),
                //          //NombreCompleto = fila.Cells["nombreCompleto"].Value?.ToString(),
                //          Telefono = fila.Cells["telefono"].Value?.ToString(),
                //          EstadoUsuario = Convert.ToBoolean(fila.Cells["estadoUsuario"].Value),
                //          PrimerLogin = Convert.ToInt32(fila.Cells["primerLogin"].Value)
                //      }
            }
        }
    }
}


