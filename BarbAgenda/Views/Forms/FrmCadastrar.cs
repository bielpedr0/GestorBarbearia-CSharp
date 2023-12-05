using BarbAgenda.Infrastructure;
using BarbAgenda.Infrastructure.Contexts;
using BarbAgenda.Models;
using System.Data;

namespace BarbAgenda.Views.Forms
{
    public partial class FrmCadastrar : Form
    {
        private readonly BarbAgendaDbContext _barbAgendaDbContext;

        private ClienteRepository clienteRepository;
        private DataTable dataTable;
        private FrmCadastro _frmCadastro;


        public FrmCadastrar(BarbAgendaDbContext barbAgendaDbContext, FrmCadastro frmCadastro)
        {
            InitializeComponent();
            _barbAgendaDbContext = barbAgendaDbContext;
            _frmCadastro = frmCadastro;
        }



        private void FrmCadastrar_Load(object sender, EventArgs e)
        {
            clienteRepository = new ClienteRepository(_barbAgendaDbContext);
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string cpf = txbCPF.Text.Trim();
            var cliente = clienteRepository.GetByCpf(cpf);

            if (cliente is not null)
            {
                MessageBox.Show($"Já existe um registro para o CPF: {cpf}");
                return;
            }

            if (!IsValidCpf(cpf))
            {
                MessageBox.Show("CPF inválido. Por favor, insira um CPF válido.");
                return;
            }

            string nome = txbNome.Text.Trim();
            if (nome == "")
            {
                MessageBox.Show("Insira um valor para o campo \"Nome\"");
                return;
            }

            string telefone = txbTelefone.Text.Trim();
            if (cpf == "")
            {
                MessageBox.Show("Insira um valor para o campo \"Telefone\"");
                return;
            }

            string email = txbEmail.Text.Trim();
            if (cpf == "")
            {
                MessageBox.Show("Insira um valor para o campo \"Email\"");
                return;
            }

            // Cria um objeto cliente apenas com o CPF
            Cliente clienteToCreate = new Cliente
            {
                Cpf = cpf,
                Nome = nome,
                Telefone = telefone,
                Email = email
            };


            // Cadastra o cliente no banco
            clienteRepository.Add(clienteToCreate);

            // Limpa os campos após o cadastro
            clearTextBox();

            // Informa ao usuário que o cliente foi cadastrado no banco
            MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _frmCadastro.AtualizarGrid();
            this.Close();
        }


        private bool IsValidCpf(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", ""); // Remove pontos e traços do CPF

            if (cpf.Length != 11 || !cpf.All(char.IsDigit)) // Verifica se o CPF tem 11 dígitos numéricos
                return false;

            // Verifica se todos os dígitos são iguais, o que torna o CPF inválido
            if (new string(cpf[0], 11) == cpf)
                return false;

            // Calcula o primeiro dígito verificador
            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += int.Parse(cpf[i].ToString()) * (10 - i);
            int firstDigit = 11 - (sum % 11);
            if (firstDigit >= 10)
                firstDigit = 0;

            // Verifica se o primeiro dígito verificador está correto
            if (int.Parse(cpf[9].ToString()) != firstDigit)
                return false;

            // Calcula o segundo dígito verificador
            sum = 0;
            for (int i = 0; i < 10; i++)
                sum += int.Parse(cpf[i].ToString()) * (11 - i);
            int secondDigit = 11 - (sum % 11);
            if (secondDigit >= 10)
                secondDigit = 0;

            // Verifica se o segundo dígito verificador está correto
            if (int.Parse(cpf[10].ToString()) != secondDigit)
                return false;

            return true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearTextBox()
        {
            txbNome.Clear();
            txbCPF.Clear();
            txbTelefone.Clear();
            txbEmail.Clear();
        }

    }

}