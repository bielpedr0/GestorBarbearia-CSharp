using MySql.Data.MySqlClient;
using BarbAgenda.Utils;
using BarbAgenda.Infrastructure.Contexts;
using BarbAgenda.Infrastructure;

namespace BarbAgenda.Views
{
    public partial class frmLoguin : Form
    {
        private readonly BarbAgendaDbContext _barbAgendaDbContext;
        private readonly UserRepository userRepository;

        private ArmazenaInfo armazenaInfo;
        public frmLoguin(BarbAgendaDbContext barbAgendaDbContext)
        {
            InitializeComponent();
            _barbAgendaDbContext = barbAgendaDbContext;
            userRepository = new UserRepository(barbAgendaDbContext);
        }

        MySqlConnection con = new MySqlConnection(@"server=localhost;port=3306;uid=root;pwd=159482;database=barb-calendario");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuarioPossuiLogin = userRepository.Login(txtUsername.Text, txtPassword.Text);

            if (!usuarioPossuiLogin)
            {
                MessageBox.Show("Usuário ou Senha Inválidos, Tente Novamente", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextBox();
                txtUsername.Focus();
                con.Close();
            }
            else
            {
                // Cria um novo objeto ArmazenaInfo e preenche com os detalhes do login
                armazenaInfo = new ArmazenaInfo();
                armazenaInfo.SetNick(txtUsername.Text);
                // Abre o Form1 e passa o objeto armazenaInfo apenas se o login for bem-sucedido
                this.Hide();
                Form1 form1 = new Form1(_barbAgendaDbContext, armazenaInfo);
                form1.ShowDialog();
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();
        }

        private void checkBxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateAccount frmCreateAccount = new frmCreateAccount(_barbAgendaDbContext, userRepository);
            frmCreateAccount.ShowDialog();
            this.Close();

        }

        private void ClearTextBox()
        {
            txtPassword.Clear();
            txtUsername.Clear();    
        }

        private void frmLoguin_Load(object sender, EventArgs e)
        {

        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
