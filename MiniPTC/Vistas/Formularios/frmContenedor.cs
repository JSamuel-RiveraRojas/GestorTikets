using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios.Admin;

namespace Vistas.Formularios
{
    public partial class frmContenedor : Form
    {
        private Usuario usuarioActual;
        public frmContenedor(string rol, Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            lblRol.Text = rol;
            lblUsuario.Text = usuario.NombreUsuario;

            this.IsMdiContainer = true;
        }


        private frmDashBoard dashBoardFROM;
        private frmGestorUsuarios UsuariosFROM;
        private FrmGestorTecnicos tecnicoForm;
        private FrmGestorCategorias categoriaForm;



        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region "Métodos para mostrar formularios"

        private void MostrarFormularioEnPanel(Form form)
        {
            pnlContenedor.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Add(form);
            pnlContenedor.Tag = form;

            form.Show();
            form.BringToFront();
        }

        #endregion

        #region "MÉTODOS MAXIMIZAR/MINIMIZAR"

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnminimizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region "Eventos de Barra de Título"

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

       



        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro que deseas cerrar sesión?",
                "Confirmar cierre de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );


            frmLogin login = new frmLogin();
            login.Show();
            login.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        #region "Eventos de Formulario"

        private void frmContenedor_Load(object sender, EventArgs e)
        {
            frmDashBoard dashBoardForm = new frmDashBoard();
            MostrarFormularioEnPanel(dashBoardForm);
            this.WindowState = FormWindowState.Maximized;

            // Ajustar visibilidad de botones según el rol del usuario
            if (lblRol.Text == "Administrador")
            {
                btnGestroUsuarios.Visible = true;
                btnTecnicos.Visible = true;
                btnCategoria.Visible = true;
                btnCrearTikets.Visible = false;
                btinTikets.Visible = false;
            }
            else if (lblRol.Text == "Técnico")
            {
                btnCategoria.Visible = false;
                btnGestroUsuarios.Visible = false;
                btnTecnicos.Visible = false;
                btinTikets.Visible = false;
                btnCrearTikets.Visible = false;
            }
            else if (lblRol.Text == "Cliente")
            {
                btnCategoria.Visible = false;
                btnGestroUsuarios.Visible = false;
                btnTecnicos.Visible = false;
                btnCrearTikets.Visible = true;
                btinTikets.Visible = true;

            }   


        }

        private void FormPrincipal_Load(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        #endregion




        private void button3_Click(object sender, EventArgs e)
        {
            
        }






        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCrearTikets_Click(object sender, EventArgs e)
        {
            frmGestorCrearTicket crearForm = new frmGestorCrearTicket(usuarioActual);
            MostrarFormularioEnPanel(crearForm);
        }

        private void btnGestorUsuarios_Click(object sender, EventArgs e)
        {
            frmGestorUsuarios usuariosForm = new frmGestorUsuarios();
            MostrarFormularioEnPanel(usuariosForm);
        }

        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            FrmGestorTecnicos tecnicoForm = new FrmGestorTecnicos();
            MostrarFormularioEnPanel(tecnicoForm);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmGestorCategorias categoriaForm = new FrmGestorCategorias();
            MostrarFormularioEnPanel(categoriaForm);
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCrearTikets_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
    }
    
}