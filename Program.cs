using System;
using System.Windows.Forms;
<<<<<<< Updated upstream
=======
using RentacarDB.Formularios; // <-- Asegúrate de incluir esta línea
>>>>>>> Stashed changes

namespace RentacarDB
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Abre directamente tu menú principal
            Application.Run(new frmMenu());
        }
    }
}