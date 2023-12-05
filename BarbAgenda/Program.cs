using BarbAgenda.Infrastructure.Contexts;
using BarbAgenda.Utils;
using BarbAgenda.Views;

namespace BarbAgenda
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BarbAgendaDbContext barbAgendaDbContext = new BarbAgendaDbContext();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ArmazenaInfo armazenaInfo = new ArmazenaInfo();
            armazenaInfo.SetNick("Usuário teste");
            Application.Run(new frmLoguin(barbAgendaDbContext));
        }
    }
}