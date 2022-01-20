using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.DesktopsForms;
using UI.Desktop.ABMListForms;
namespace UI.Desktop
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
            //Application.Run(new UsuarioDesktop(ApplicationForm.ModoForm.Alta));
            //Application.Run(new DocentesCursos());
            Application.Run( new FormMain());
        }
    }
}
