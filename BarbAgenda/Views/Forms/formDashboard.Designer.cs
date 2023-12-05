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
            this.maskedTextBoxDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewRelatorioAgendamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorioAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxDataInicial
            // 
            this.maskedTextBoxDataInicial.Location = new System.Drawing.Point(118, 87);
            this.maskedTextBoxDataInicial.Name = "maskedTextBoxDataInicial";
            this.maskedTextBoxDataInicial.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxDataInicial.TabIndex = 0;
            // 
            // maskedTextBoxDataFinal
            // 
            this.maskedTextBoxDataFinal.Location = new System.Drawing.Point(308, 87);
            this.maskedTextBoxDataFinal.Name = "maskedTextBoxDataFinal";
            this.maskedTextBoxDataFinal.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxDataFinal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelValorTotal.Location = new System.Drawing.Point(44, 548);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(0, 15);
            this.labelValorTotal.TabIndex = 5;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(441, 87);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(109, 23);
            this.btnGerarRelatorio.TabIndex = 6;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Relatório de Agendamentos";
            // 
            // dataGridViewRelatorioAgendamento
            // 
            this.dataGridViewRelatorioAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatorioAgendamento.Location = new System.Drawing.Point(44, 131);
            this.dataGridViewRelatorioAgendamento.Name = "dataGridViewRelatorioAgendamento";
            this.dataGridViewRelatorioAgendamento.RowTemplate.Height = 25;
            this.dataGridViewRelatorioAgendamento.Size = new System.Drawing.Size(651, 397);
            this.dataGridViewRelatorioAgendamento.TabIndex = 8;
            // 
            // formDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 603);
            this.Controls.Add(this.dataGridViewRelatorioAgendamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxDataFinal);
            this.Controls.Add(this.maskedTextBoxDataInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDashboard";
            this.Text = "formDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorioAgendamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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