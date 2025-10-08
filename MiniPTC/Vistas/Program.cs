using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios;

namespace Vistas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!Usuario.ExisteAdministrador())
            {
                //message boxcque no existe admin
                MessageBox.Show("No existe un usuario administrador. Por favor, cree uno antes de usar el programa.");
                Application.Run(new frmGestorUsuarios());
            }
            else
            {
                Application.Run(new frmLogin());
            }
        }
    }
}
