namespace BarbAgenda.Views
{
    partial class formCalendar
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
            dayContainer = new FlowLayoutPanel();
            btnAnterior = new Button();
            btnProximo = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbData = new Label();
            SuspendLayout();
            // 
            // dayContainer
            // 
            dayContainer.BorderStyle = BorderStyle.FixedSingle;
            dayContainer.Location = new Point(58, 121);
            dayContainer.Margin = new Padding(3, 4, 3, 4);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(794, 522);
            dayContainer.TabIndex = 1;
            // 
            // btnAnterior
            // 
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.Location = new Point(696, 651);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 29);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Cursor = Cursors.Hand;
            btnProximo.Location = new Point(777, 651);
            btnProximo.Margin = new Padding(3, 4, 3, 4);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(75, 29);
            btnProximo.TabIndex = 3;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 99);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 4;
            label1.Text = "Domingo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(193, 99);
            label2.Name = "label2";
            label2.Size = new Size(66, 18);
            label2.TabIndex = 5;
            label2.Text = "Segunda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(316, 99);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 6;
            label3.Text = "Terça";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(424, 99);
            label4.Name = "label4";
            label4.Size = new Size(53, 18);
            label4.TabIndex = 7;
            label4.Text = "Quarta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(539, 99);
            label5.Name = "label5";
            label5.Size = new Size(51, 18);
            label5.TabIndex = 8;
            label5.Text = "Quinta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(654, 99);
            label6.Name = "label6";
            label6.Size = new Size(45, 18);
            label6.TabIndex = 9;
            label6.Text = "Sexta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(750, 99);
            label7.Name = "label7";
            label7.Size = new Size(59, 18);
            label7.TabIndex = 10;
            label7.Text = "Sábado";
            // 
            // lbData
            // 
            lbData.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbData.ForeColor = Color.FromArgb(116, 86, 174);
            lbData.Location = new Point(247, 36);
            lbData.Name = "lbData";
            lbData.Size = new Size(389, 35);
            lbData.TabIndex = 11;
            lbData.Text = "MONTH YEAR";
            lbData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formCalendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(864, 682);
            Controls.Add(lbData);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(dayContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "formCalendar";
            Text = "formCalendar";
            Load += formCalendar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel dayContainer;
        private Button btnAnterior;
        private Button btnProximo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbData;
    }
}