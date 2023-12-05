using BarbAgenda.Infrastructure;
using BarbAgenda.Infrastructure.Contexts;
using BarbAgenda.Models;
using MySql.Data.MySqlClient;


namespace BarbAgenda.Views
{
    public partial class frmCreateAccount : Form
    {
        private readonly BarbAgendaDbContext _barbAgendaDbContext;
        private readonly UserRepository _userRepository;
        public frmCreateAccount(BarbAgendaDbContext barbAgendaDbContext, UserRepository userRepository)
        {
            InitializeComponent();
            _barbAgendaDbContext = barbAgendaDbContext;
            _userRepository = userRepository;
        }

        MySqlConnection con = new MySqlConnection(@"server=localhost;port=3306;uid=root;pwd=834483Ti;database=barbagenda");
        
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        String confirmandoTeoria;


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConfPassword.Text == "")
            {
                MessageBox.Show("Use" +
                    "Nome do usuário e senha estão vazios.", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConfPassword.Text)
            {
                var userFoiCriado = _userRepository.Add(new User { Nome = txtUsername.Text, Password = txtPassword.Text });

                if (userFoiCriado)
                {
                    txtPassword.Text = "";
                    txtConfPassword.Text = "";
                    txtUsername.Text = "";
                    MessageBox.Show("Sua conta foi criada com sucesso", "Cadastrado com sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error ao criar conta", "Falha no cadastro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Senhas não conferem, por favor tente novamente", "Falha no cadastro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConfPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void checkBxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfPassword.PasswordChar = '*';

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtConfPassword.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoguin frmlogin = new frmLoguin(_barbAgendaDbContext);
            frmlogin.ShowDialog();
            this.Close();
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
