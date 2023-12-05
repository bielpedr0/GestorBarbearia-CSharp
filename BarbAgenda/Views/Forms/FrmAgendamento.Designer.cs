namespace BarbAgenda.Views
{
    partial class FrmAgendamento
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
            formularioImg = new PictureBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            dataGridView1 = new DataGridView();
            comboBoxServico = new ComboBox();
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            txbValor = new TextBox();
            label1 = new Label();
            btnAgendar = new Button();
            Cliente = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxCliente = new ComboBox();
            btnExcluir = new Button();
            maskedTextBoxData = new MaskedTextBox();
            maskedTextBoxTime = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)formularioImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // formularioImg
            // 
            formularioImg.Location = new Point(16, -39);
            formularioImg.Margin = new Padding(5);
            formularioImg.Name = "formularioImg";
            formularioImg.Size = new Size(821, 809);
            formularioImg.SizeMode = PictureBoxSizeMode.StretchImage;
            formularioImg.TabIndex = 2;
            formularioImg.TabStop = false;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(117, 428);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(642, 231);
            dataGridView1.TabIndex = 4;
            // 
            // comboBoxServico
            // 
            comboBoxServico.FormattingEnabled = true;
            comboBoxServico.Items.AddRange(new object[] { "Corte", "Barba", "Sobrancelha", "Corte + barba", "Corte + Sobrancelha", "Completo" });
            comboBoxServico.Location = new Point(223, 197);
            comboBoxServico.Margin = new Padding(5);
            comboBoxServico.Name = "comboBoxServico";
            comboBoxServico.Size = new Size(159, 28);
            comboBoxServico.TabIndex = 5;
            // 
            // mySqlCommand2
            // 
            mySqlCommand2.CacheAge = 0;
            mySqlCommand2.Connection = null;
            mySqlCommand2.EnableCaching = false;
            mySqlCommand2.Transaction = null;
            // 
            // txbValor
            // 
            txbValor.Enabled = false;
            txbValor.Location = new Point(223, 256);
            txbValor.Margin = new Padding(5);
            txbValor.Name = "txbValor";
            txbValor.Size = new Size(159, 27);
            txbValor.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(356, 49);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 34);
            label1.TabIndex = 9;
            label1.Text = "Agenda";
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.White;
            btnAgendar.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgendar.ForeColor = Color.FromArgb(116, 86, 174);
            btnAgendar.Location = new Point(453, 141);
            btnAgendar.Margin = new Padding(5);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(239, 87);
            btnAgendar.TabIndex = 10;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.BackColor = SystemColors.Control;
            Cliente.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            Cliente.ForeColor = Color.Black;
            Cliente.Location = new Point(117, 145);
            Cliente.Margin = new Padding(5, 0, 5, 0);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(93, 24);
            Cliente.TabIndex = 11;
            Cliente.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(120, 201);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 16;
            label3.Text = "Serviço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(117, 259);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 24);
            label4.TabIndex = 17;
            label4.Text = "Valor R$:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(120, 318);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 24);
            label5.TabIndex = 18;
            label5.Text = "Data:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("MS UI Gothic", 14.15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(120, 366);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 24);
            label6.TabIndex = 19;
            label6.Text = "Horário:";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(223, 141);
            comboBoxCliente.Margin = new Padding(5);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(159, 28);
            comboBoxCliente.TabIndex = 20;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.Control;
            btnExcluir.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = SystemColors.Desktop;
            btnExcluir.Location = new Point(622, 372);
            btnExcluir.Margin = new Padding(5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(137, 47);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // maskedTextBoxData
            // 
            maskedTextBoxData.Location = new Point(223, 315);
            maskedTextBoxData.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxData.Name = "maskedTextBoxData";
            maskedTextBoxData.Size = new Size(159, 27);
            maskedTextBoxData.TabIndex = 22;
            // 
            // maskedTextBoxTime
            // 
            maskedTextBoxTime.Location = new Point(223, 363);
            maskedTextBoxTime.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxTime.Name = "maskedTextBoxTime";
            maskedTextBoxTime.Size = new Size(159, 27);
            maskedTextBoxTime.TabIndex = 23;
            // 
            // FrmAgendamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 692);
            Controls.Add(maskedTextBoxTime);
            Controls.Add(maskedTextBoxData);
            Controls.Add(btnExcluir);
            Controls.Add(comboBoxCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Cliente);
            Controls.Add(btnAgendar);
            Controls.Add(label1);
            Controls.Add(txbValor);
            Controls.Add(comboBoxServico);
            Controls.Add(dataGridView1);
            Controls.Add(formularioImg);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmAgendamento";
            Text = "FrmAgendamento";
            Load += FrmAgendamento_Load;
            ((System.ComponentModel.ISupportInitialize)formularioImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox formularioImg;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dataGridView1;
        private ComboBox comboBoxServico;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private TextBox txbValor;
        private Label label1;
        private Button btnAgendar;
        private Label Cliente;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxCliente;
        private Button btnExcluir;
        private MaskedTextBox maskedTextBoxData;
        private MaskedTextBox maskedTextBoxTime;
    }
}