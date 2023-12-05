using BarbAgenda.Infrastructure.Contexts;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbAgenda.Views.UCs
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, numday);
            lbDays.Text = date.Day.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {

            static_day = lbDays.Text;

            // Passe o contexto como parâmetro ao criar o FormEvento
            BarbAgendaDbContext contexto = new BarbAgendaDbContext(); // Supondo que você tenha acesso ao contexto aqui
            FormEvento formEvento = new FormEvento(static_day, contexto);
            formEvento.Show();
        }

        
    }
}
