using BarbAgenda.Infrastructure;
using BarbAgenda.Infrastructure.Contexts;
using BarbAgenda.Models;
using BarbAgenda.Views.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace BarbAgenda.Views
{
    public partial class FrmCadastro : Form
    {
        private readonly BarbAgendaDbContext _barbAgendaDbContext;

        private ClienteRepository clienteRepository;
        private DataTable dataTable;
        public FrmCadastro(BarbAgendaDbContext barbAgendaDbContext)
        {
            InitializeComponent();
            _barbAgendaDbContext = barbAgendaDbContext;
        }
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            clienteRepository = new ClienteRepository(_barbAgendaDbContext);

            //cria uma tabela vazia
            dataTable = new DataTable();

            //insere os dados do relatório na tabela
            clienteRepository.GerarRelatorioCliente(dataTable);

            //diz para o grid utilizar essa tabela como fonte de dados
            //nesse caso o grid irá exibir os dados da tabela!
            gvFuncionarios.DataSource = dataTable;

            //libera os recursos da tabela!

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrar frmCadastrar = new FrmCadastrar(_barbAgendaDbContext, this);
            frmCadastrar.ShowDialog();
        }

        private string nomeOriginal;
        private string cpfOriginal;
        private string telefoneOriginal;
        private string emailOriginal;
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string cpf = txbCPF.Text.Trim();
            if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Insira um valor para o campo cpf");
                return;
            }

            // Pesquisa se existe um cliente com o CPF passado
            Cliente cliente = clienteRepository.GetByCpf(cpf);

            if (cliente is null)
            {
                // Limpa os textbox com os dados do cliente
                clearTextBox();
                // Mostra uma mensagem de erro
                MessageBox.Show($"Não existe um cliente com o CPF: {cpf}");
            }
            else
            {
                // Armazena os dados originais obtidos na pesquisa
                nomeOriginal = cliente.Nome;
                cpfOriginal = cliente.Cpf;
                telefoneOriginal = cliente.Telefone;
                emailOriginal = cliente.Email;

                // Preenche os campos do formulário com os dados obtidos
                txbNome.Text = nomeOriginal;
                txbCPF.Text = cpfOriginal;
                txbTelefone.Text = telefoneOriginal;
                txbEmail.Text = emailOriginal;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recupera os dados atuais dos campos
                string nomeAtual = txbNome.Text.Trim();
                string cpfAtual = txbCPF.Text.Trim();
                string telefoneAtual = txbTelefone.Text.Trim();
                string emailAtual = txbEmail.Text.Trim();

                // Verifica se os dados foram modificados
                if (nomeAtual != nomeOriginal || cpfAtual != cpfOriginal || telefoneAtual != telefoneOriginal || emailAtual != emailOriginal)
                {
                    // Cria um novo objeto Cliente apenas com os campos alterados
                    Cliente clienteAtualizado = new Cliente
                    {
                        Nome = nomeAtual,
                        Cpf = cpfAtual,
                        Telefone = telefoneAtual,
                        Email = emailAtual
                    };

                    // Atualiza somente os campos que foram alterados
                    // (você precisará implementar a lógica para fazer isso no seu método de atualização)
                    bool sucesso = clienteRepository.Update(clienteAtualizado);

                    if (sucesso)
                    {
                        // Atualiza os dados originais para os novos valores
                        nomeOriginal = nomeAtual;
                        cpfOriginal = cpfAtual;
                        telefoneOriginal = telefoneAtual;
                        emailOriginal = emailAtual;

                        MessageBox.Show("Dados Salvos!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();

                        clearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar os dados do cliente");
                    }

                }
                else
                {
                    MessageBox.Show("Nenhum dado foi alterado.");
                }

            }
            catch (MySqlException erro)
            {
                // Tratamento de exceção para o banco de dados
                MessageBox.Show("Erro no banco de dados: " + erro.Message, "ERRO BANCO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                // Tratamento de outras exceções
                MessageBox.Show("Erro desconhecido: " + erro.Message, "ERRO Desconhecido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {//recupera o cpf usado na pesquisa (remove os espaços em branco do começo e fim do texto)
            string cpf = txbCPF.Text.Trim();
            if (cpf == "")
            {
                MessageBox.Show("Insira um valor para o campo \"Nome - Pesquisar\"");
                return;
            }

            //caso encontre uma pessoa com o cpf digitado
            if (clienteRepository.RemoveByCpf(cpf) == true)
            {


                clearTextBox();

                MessageBox.Show("Cliente removido do cadastro com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clienteRepository.GerarRelatorioCliente(dataTable);

            }

            else
            {

                clearTextBox();


                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Não foi possivel remover o cliente do cadastro!");
                sb.AppendLine("Verifique se existe um cliente cadastrado com o cpf pesquisado!");
                MessageBox.Show(sb.ToString());
            }


            clearTextBox();
        }



        private void clearTextBox()
        {
            txbNome.Clear();
            txbCPF.Clear();
            txbTelefone.Clear();
            txbEmail.Clear();
        }

        private void gvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Certifique-se de que a célula clicada está dentro dos limites das células de dados
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = this.gvFuncionarios.Rows[e.RowIndex];

                // Agora você pode acessar os valores das células na linha selecionada

                Cliente cliente = new Cliente
                {
                    Nome = selectedRow.Cells["Nome"].Value.ToString(),
                    Cpf = selectedRow.Cells["Cpf"].Value.ToString(),
                    Telefone = selectedRow.Cells["Telefone"].Value.ToString(),
                    Email = selectedRow.Cells["Email"].Value.ToString(),
                };

                HabilitarTxbAtualizacao();
                HabilitarBtnAtualizacao();
                CarregarValoresTextBox(cliente);
            }
        }

        private void txbCPF_KeyDown(object sender, KeyEventArgs e)
        {
            DesabilitarBtnAtualizacao();
            DesabilitarTxbAtualizacao();
            LimparTxbAtualizacao();
        }

        private void LimparTxbAtualizacao()
        {
            txbNome.Clear();
            txbTelefone.Clear();
            txbEmail.Clear();
        }

        private void HabilitarBtnAtualizacao()
        {
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void HabilitarTxbAtualizacao()
        {
            txbNome.Enabled = true;
            txbTelefone.Enabled = true;
            txbEmail.Enabled = true;
        }

        private void DesabilitarBtnAtualizacao()
        {
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void DesabilitarTxbAtualizacao()
        {
            txbNome.Enabled = false;
            txbTelefone.Enabled = false;
            txbEmail.Enabled = false;
        }

        private void CarregarValoresTextBox(Cliente cliente)
        {
            txbCPF.Text = cliente.Cpf;
            txbNome.Text = cliente.Nome;
            txbTelefone.Text = cliente.Email;
            txbEmail.Text = cliente.Email;
        }

        public void AtualizarGrid()
        {
            // Atualiza o DataTable e, por consequência, o grid
            dataTable.Clear();
            clienteRepository.GerarRelatorioCliente(dataTable);
        }

       

    }
}
