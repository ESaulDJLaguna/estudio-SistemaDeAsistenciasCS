using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_asistencias
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Qu� pantalla se mostrar� al inicio de la aplicaci�n
            Application.Run(new Presentacion.TomarAsistencias());
            //Application.Run(new Presentacion.MenuPrincipal());
        }
    }
}
