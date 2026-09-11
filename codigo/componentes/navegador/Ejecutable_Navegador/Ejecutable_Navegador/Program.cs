using CapaVista_Navegador;
namespace Ejecutable_Navegador
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            Application.Run(new Frm_Crud());
        }
    }
}