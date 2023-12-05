namespace BarbAgenda.Views.Forms
{
    partial class FrmCadastrar
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            Cliente = new Label();
            txbEmail = new TextBox();
            txbTelefone = new TextBox();
            txbCPF = new TextBox();
            txbNome = new TextBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(32, 254);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 24);
            label8.TabIndex = 45;
            label8.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(32, 175);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 24);
            label7.TabIndex = 44;
            label7.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(32, 19);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 24);
            label6.TabIndex = 43;
            label6.Text = "CPF:";
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.BackColor = SystemColors.Control;
            Cliente.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            Cliente.ForeColor = Color.Black;
            Cliente.Location = new Point(32, 98);
            Cliente.Margin = new Padding(5, 0, 5, 0);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(188, 24);
            Cliente.TabIndex = 42;
            Cliente.Text = "Nome Completo:";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(32, 282);
            txbEmail.Margin = new Padding(3, 4, 3, 4);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(263, 27);
            txbEmail.TabIndex = 41;
            // 
            // txbTelefone
            // 
            txbTelefone.Location = new Point(32, 203);
            txbTelefone.Margin = new Padding(3, 4, 3, 4);
            txbTelefone.Name = "txbTelefone";
            txbTelefone.Size = new Size(263, 27);
            txbTelefone.TabIndex = 40;
            // 
            // txbCPF
            // 
            txbCPF.Location = new Point(32, 47);
            txbCPF.Margin = new Padding(3, 4, 3, 4);
            txbCPF.Name = "txbCPF";
            txbCPF.Size = new Size(263, 27);
            txbCPF.TabIndex = 39;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(32, 126);
            txbNome.Margin = new Padding(3, 4, 3, 4);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(263, 27);
            txbNome.TabIndex = 38;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.FromArgb(116, 86, 174);
            btnCadastrar.Location = new Point(398, 54);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(177, 106);
            btnCadastrar.TabIndex = 37;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(398, 253);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(177, 56);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmCadastrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(617, 336);
            Controls.Add(btnCancelar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Cliente);
            Controls.Add(txbEmail);
            Controls.Add(txbTelefone);
            Controls.Add(txbCPF);
            Controls.Add(txbNome);
            Controls.Add(btnCadastrar);
            Name = "FrmCadastrar";
            Text = "FrmCadastrar";
            Load += FrmCadastrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label Cliente;
        private TextBox txbEmail;
        private TextBox txbTelefone;
        private TextBox txbCPF;
        private TextBox txbNome;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}