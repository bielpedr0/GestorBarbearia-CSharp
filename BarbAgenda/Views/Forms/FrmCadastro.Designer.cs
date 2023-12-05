namespace BarbAgenda.Views
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrar = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            txbEmail = new TextBox();
            txbTelefone = new TextBox();
            txbCPF = new TextBox();
            txbNome = new TextBox();
            label5 = new Label();
            Cliente = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            gvFuncionarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.FromArgb(116, 86, 174);
            btnCadastrar.Location = new Point(38, 591);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(177, 53);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.Enabled = false;
            btnAtualizar.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtualizar.ForeColor = Color.FromArgb(116, 86, 174);
            btnAtualizar.Location = new Point(425, 591);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(221, 53);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Alterar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.FromArgb(116, 86, 174);
            btnExcluir.Location = new Point(653, 591);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(182, 53);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisar.ForeColor = Color.FromArgb(116, 86, 174);
            btnPesquisar.Location = new Point(221, 591);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(198, 53);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txbEmail
            // 
            txbEmail.Enabled = false;
            txbEmail.Location = new Point(55, 493);
            txbEmail.Margin = new Padding(3, 4, 3, 4);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(263, 27);
            txbEmail.TabIndex = 31;
            // 
            // txbTelefone
            // 
            txbTelefone.Enabled = false;
            txbTelefone.Location = new Point(55, 379);
            txbTelefone.Margin = new Padding(3, 4, 3, 4);
            txbTelefone.Name = "txbTelefone";
            txbTelefone.Size = new Size(263, 27);
            txbTelefone.TabIndex = 30;
            // 
            // txbCPF
            // 
            txbCPF.Location = new Point(55, 171);
            txbCPF.Margin = new Padding(3, 4, 3, 4);
            txbCPF.Name = "txbCPF";
            txbCPF.Size = new Size(263, 27);
            txbCPF.TabIndex = 29;
            txbCPF.KeyDown += txbCPF_KeyDown;
            // 
            // txbNome
            // 
            txbNome.Enabled = false;
            txbNome.Location = new Point(55, 281);
            txbNome.Margin = new Padding(3, 4, 3, 4);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(263, 27);
            txbNome.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(363, 72);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(334, 34);
            label5.TabIndex = 32;
            label5.Text = "Cadastro de Clientes";
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.BackColor = SystemColors.Control;
            Cliente.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            Cliente.ForeColor = Color.Black;
            Cliente.Location = new Point(55, 256);
            Cliente.Margin = new Padding(5, 0, 5, 0);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(188, 24);
            Cliente.TabIndex = 33;
            Cliente.Text = "Nome Completo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(55, 145);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 24);
            label6.TabIndex = 34;
            label6.Text = "CPF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(51, 349);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 24);
            label7.TabIndex = 35;
            label7.Text = "Telefone:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(50, 465);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 24);
            label8.TabIndex = 36;
            label8.Text = "Email:";
            // 
            // gvFuncionarios
            // 
            gvFuncionarios.AllowUserToAddRows = false;
            gvFuncionarios.AllowUserToDeleteRows = false;
            gvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvFuncionarios.Location = new Point(335, 145);
            gvFuncionarios.Margin = new Padding(5);
            gvFuncionarios.Name = "gvFuncionarios";
            gvFuncionarios.ReadOnly = true;
            gvFuncionarios.RowHeadersWidth = 51;
            gvFuncionarios.Size = new Size(552, 392);
            gvFuncionarios.TabIndex = 37;
            gvFuncionarios.CellClick += gvFuncionarios_CellClick;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1029, 692);
            Controls.Add(gvFuncionarios);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Cliente);
            Controls.Add(label5);
            Controls.Add(txbEmail);
            Controls.Add(txbTelefone);
            Controls.Add(txbCPF);
            Controls.Add(txbNome);
            Controls.Add(btnPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastrar);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmCadastro";
            Text = "FrmCadastro";
            Load += FrmCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)gvFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private TextBox txbEmail;
        private TextBox txbTelefone;
        private TextBox txbCPF;
        private TextBox txbNome;
        private Label label5;
        private Label Cliente;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView gvFuncionarios;
    }
}