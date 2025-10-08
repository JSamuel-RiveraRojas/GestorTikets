using Modelos.ConexionDB;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios.Admin
{
    public partial class frmGestorCrearTicket : Form
    {
        private Usuario usuarioActual;
        public frmGestorCrearTicket(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            CargarCategorias();
            CargarPrioridades();
        }

        private void frmGestorCrearTicket_Load(object sender, EventArgs e)
        {

        }




        private void CargarCategorias()
        {
            using (SqlConnection con = Conexion.conectar())
            {
                string query = "SELECT idCategoria, nombreCategoria FROM Categorias";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbCategoria.DataSource = dt;
                cmbCategoria.DisplayMember = "nombre";
                cmbCategoria.ValueMember = "idCategoria";
            }
        }

        private void CargarPrioridades()
        {
            cmbPrioridad.Items.Clear();
            cmbPrioridad.Items.Add("Alta");
            cmbPrioridad.Items.Add("Media");
            cmbPrioridad.Items.Add("Baja");
            cmbPrioridad.SelectedIndex = 1; // Media por defecto
        }

        private void btnCrearTicket_Click(object sender, EventArgs e)
        {
            Ticket nuevo = new Ticket
            {
                Titulo = txtTitulo.Text,
                Descripcion = txtDescripcion.Text,
                IdCliente = usuarioActual.IdUsuario,
                IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue),
                Estado = "Abierto",
                Prioridad = cmbPrioridad.SelectedItem.ToString()
            };

            if (nuevo.Crear())
            {
                MessageBox.Show("Ticket creado correctamente");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al crear el ticket");
            }
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = 0;
            cmbPrioridad.SelectedIndex = 1;

        }
    }
}
