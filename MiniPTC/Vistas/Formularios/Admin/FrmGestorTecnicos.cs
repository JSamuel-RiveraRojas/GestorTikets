using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class FrmGestorTecnicos : Form
    {
        public FrmGestorTecnicos()
        {
            InitializeComponent();
        }

        private void FrmGestorTecnicos_Load(object sender, EventArgs e)
        {
            CargarUsuariosTecnicos();
            CargarTecnicos();
        }
        private void CargarUsuariosTecnicos()
        {
            cmbTecnico.DataSource = Usuario.ObtenerUsuariosPorRol(2);
            cmbTecnico.DisplayMember = "NombreUsuario";
            cmbTecnico.ValueMember = "IdUsuario";
        }
        private void CargarTecnicos()
        {
            dgvTecnicos.DataSource = Tecnicos.ObtenerTodos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEspecialidad.Clear();
            cmbTecnico.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Tecnicos nuevo = new Tecnicos
            {
                IdTecnico = Convert.ToInt32(cmbTecnico.SelectedValue),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Especialidad = txtEspecialidad.Text
            };

            if (nuevo.Agregar())
            {
                MessageBox.Show("Técnico registrado correctamente");
                CargarTecnicos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar técnico");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTecnicos.SelectedRows.Count > 0)
            {
                Tecnicos tecnico = new Tecnicos
                {
                    IdTecnico = Convert.ToInt32(dgvTecnicos.SelectedRows[0].Cells["idTecnico"].Value),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Especialidad = txtEspecialidad.Text
                };

                if (tecnico.Editar())
                {
                    MessageBox.Show("Técnico actualizado");
                    CargarTecnicos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar técnico");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTecnicos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvTecnicos.SelectedRows[0].Cells["idTecnico"].Value);

                if (Tecnicos.Eliminar(id))
                {
                    MessageBox.Show("Técnico eliminado");
                    CargarTecnicos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar técnico");
                }
            }
        }

        private void dgvTecnicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTecnicos.Rows[e.RowIndex];
                cmbTecnico.SelectedValue = fila.Cells["idTecnico"].Value;
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["apellido"].Value.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
                txtEspecialidad.Text = fila.Cells["especialidad"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }
    }
}
