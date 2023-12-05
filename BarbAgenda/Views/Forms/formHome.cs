using BarbAgenda.Utils;

namespace BarbAgenda.Views
{
    public partial class formHome : Form
    {
        private ArmazenaInfo armazenaInfo;
        public formHome(ArmazenaInfo armazenaInfo)
        {
            InitializeComponent();
            this.armazenaInfo = armazenaInfo;
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            timer1.Start();

            LblBemVindos.Text = "Bem Vindo " + armazenaInfo.GetNick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
