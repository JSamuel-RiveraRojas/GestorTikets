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

namespace Vistas.Formularios
{
    public partial class frmContenedor : Form
    {
        public frmContenedor()
        {
            InitializeComponent();

            //if (Sesion.UsuarioActivo?.IdRol == 2) 
            //{
            //    btnGestionEmpleados.Visible = false;
            //}

            this.IsMdiContainer = true;
        }


        private frmDashBoard dashBoardFROM;
        private frmGestorUsuarios UsuariosFROM;
        private frmGestorCrearTikets CrearTiketsFROM;


        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region "Métodos para mostrar formularios"

        private void MostrarFormularioEnPanel<T>(ref T form) where T : Form, new()
        {
            if (form != null && !form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }

            pnlContenedor.Controls.Clear();

            form = new T();

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

            //if (resultado == DialogResult.Yes)
            //{
            //    if (Sesion.UsuarioActivo != null)
            //    {
            //        Sesion.Cerrar();
            //    }

            frmLogin login = new frmLogin();
            login.Show();
            login.FormClosed += (s, args) => this.Close();
            this.Hide();
            //}
        }

        #region "Eventos de Formulario"

        private void frmContenedor_Load(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(ref dashBoardFROM);

            this.WindowState = FormWindowState.Maximized;
        }

        private void FormPrincipal_Load(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        #endregion


        private void button1_Click(object sender, EventArgs e)//btnInicio

        {

            MostrarFormularioEnPanel(ref dashBoardFROM);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Tu código existente
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MostrarFormularioEnPanel(ref CrearTiketsFROM);
        }




        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCrearTikets_Click(object sender, EventArgs e)
        {
        
        }

        private void btnGestroUsuarios_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(ref UsuariosFROM);
        }
    }
    
}