namespace BarbAgenda.Views
{
    partial class formDashboard
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
            maskedTextBoxDataInicial = new MaskedTextBox();
            maskedTextBoxDataFinal = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            labelValorTotal = new Label();
            btnGerarRelatorio = new Button();
            label4 = new Label();
            dataGridViewRelatorioAgendamento = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRelatorioAgendamento).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBoxDataInicial
            // 
            maskedTextBoxDataInicial.Location = new Point(135, 116);
            maskedTextBoxDataInicial.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxDataInicial.Name = "maskedTextBoxDataInicial";
            maskedTextBoxDataInicial.Size = new Size(114, 27);
            maskedTextBoxDataInicial.TabIndex = 0;
            // 
            // maskedTextBoxDataFinal
            // 
            maskedTextBoxDataFinal.Location = new Point(352, 116);
            maskedTextBoxDataFinal.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxDataFinal.Name = "maskedTextBoxDataFinal";
            maskedTextBoxDataFinal.Size = new Size(114, 27);
            maskedTextBoxDataFinal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 120);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 2;
            label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 120);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Data Final:";
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelValorTotal.Location = new Point(50, 731);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(0, 20);
            labelValorTotal.TabIndex = 5;
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Location = new Point(504, 116);
            btnGerarRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(125, 31);
            btnGerarRelatorio.TabIndex = 6;
            btnGerarRelatorio.Text = "Gerar Relatório";
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(116, 86, 174);
            label4.Location = new Point(50, 12);
            label4.Name = "label4";
            label4.Size = new Size(348, 37);
            label4.TabIndex = 7;
            label4.Text = "Relatório de Agendamentos";
            // 
            // dataGridViewRelatorioAgendamento
            // 
            dataGridViewRelatorioAgendamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRelatorioAgendamento.Location = new Point(50, 175);
            dataGridViewRelatorioAgendamento.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRelatorioAgendamento.Name = "dataGridViewRelatorioAgendamento";
            dataGridViewRelatorioAgendamento.RowHeadersWidth = 51;
            dataGridViewRelatorioAgendamento.RowTemplate.Height = 25;
            dataGridViewRelatorioAgendamento.Size = new Size(744, 521);
            dataGridViewRelatorioAgendamento.TabIndex = 8;
            // 
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 804);
            Controls.Add(dataGridViewRelatorioAgendamento);
            Controls.Add(label4);
            Controls.Add(btnGerarRelatorio);
            Controls.Add(labelValorTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBoxDataFinal);
            Controls.Add(maskedTextBoxDataInicial);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "formDashboard";
            Text = "formDashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRelatorioAgendamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBoxDataInicial;
        private MaskedTextBox maskedTextBoxDataFinal;
        private Label label1;
        private Label label2;
        private Label labelValorTotal;
        private Button btnGerarRelatorio;
        private Label label4;
        private DataGridView dataGridViewRelatorioAgendamento;
    }
}