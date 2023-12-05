namespace BarbAgenda.Views
{
    partial class FormEvento
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
            txbData = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridViewCalendario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendario).BeginInit();
            SuspendLayout();
            // 
            // txbData
            // 
            txbData.BorderStyle = BorderStyle.FixedSingle;
            txbData.Enabled = false;
            txbData.Location = new Point(12, 33);
            txbData.Margin = new Padding(3, 4, 3, 4);
            txbData.Name = "txbData";
            txbData.Size = new Size(363, 27);
            txbData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 2;
            label1.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 3;
            label2.Text = "Agendamentos:";
            // 
            // dataGridViewCalendario
            // 
            dataGridViewCalendario.AllowUserToAddRows = false;
            dataGridViewCalendario.AllowUserToDeleteRows = false;
            dataGridViewCalendario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCalendario.Location = new Point(12, 105);
            dataGridViewCalendario.Margin = new Padding(4, 5, 4, 5);
            dataGridViewCalendario.Name = "dataGridViewCalendario";
            dataGridViewCalendario.ReadOnly = true;
            dataGridViewCalendario.RowHeadersWidth = 51;
            dataGridViewCalendario.Size = new Size(362, 313);
            dataGridViewCalendario.TabIndex = 5;
            // 
            // FormEvento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 432);
            Controls.Add(dataGridViewCalendario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbData);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEvento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEvento";
            Load += FormEvento_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbData;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewCalendario;
    }
}