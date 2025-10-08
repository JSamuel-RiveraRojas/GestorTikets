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

namespace Vistas.Formularios.Admin
{
    public partial class FrmGestorCategorias : Form
    {
        public FrmGestorCategorias()
        {
            InitializeComponent();
        }

        private void FrmGestorCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            LimpiarCampos();
            txtIdCategoria.Visible = false;
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = Categorias.ObtenerTodas();
        }

        private void LimpiarCampos()
        {
            txtIdCategoria.Clear();
            txtNombreCategoria.Clear();
            txtDescripcionCategoria.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categorias nueva = new Categorias
            {
                NombreCategoria = txtNombreCategoria.Text,
                Descripcion = txtDescripcionCategoria.Text
            };

            if (nueva.Agregar())
            {
                MessageBox.Show("Categoría registrada correctamente");
                CargarCategorias();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar categoría");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdCategoria.Text))
            {
                Categorias categoria = new Categorias
                {
                    IdCategoria = Convert.ToInt32(txtIdCategoria.Text),
                    NombreCategoria = txtNombreCategoria.Text,
                    Descripcion = txtDescripcionCategoria.Text
                };

                if (categoria.Editar())
                {
                    MessageBox.Show("Categoría actualizada");
                    CargarCategorias();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar categoría");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdCategoria.Text))
            {
                int id = Convert.ToInt32(txtIdCategoria.Text);

                if (Categorias.Eliminar(id))
                {
                    MessageBox.Show("Categoría eliminada");
                    CargarCategorias();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar categoría");
                }
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];
                txtIdCategoria.Text = fila.Cells["idCategoria"].Value.ToString();
                txtNombreCategoria.Text = fila.Cells["nombre"].Value.ToString();
                txtDescripcionCategoria.Text = fila.Cells["descripcion"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();


        }
    }
}