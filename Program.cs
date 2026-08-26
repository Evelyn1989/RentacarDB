using System;
using System.Windows.Forms;
using RentacarDB.Formularios; // <-- Asegúrate de incluir esta línea

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