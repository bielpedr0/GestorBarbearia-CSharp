namespace BarbAgenda.Views
{
    partial class frmLoguin
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
            btnCreateAccount = new Label();
            label5 = new Label();
            btnClear = new Button();
            btnLogin = new Button();
            checkBxShowPass = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.AutoSize = true;
            btnCreateAccount.Cursor = Cursors.Hand;
            btnCreateAccount.ForeColor = Color.FromArgb(116, 86, 174);
            btnCreateAccount.Location = new Point(97, 390);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(136, 23);
            btnCreateAccount.TabIndex = 33;
            btnCreateAccount.Text = "Crie Uma Conta";
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 363);
            label5.Name = "label5";
            label5.Size = new Size(216, 23);
            label5.TabIndex = 32;
            label5.Text = "Você Não Tem Uma Conta";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(116, 86, 174);
            btnClear.Location = new Point(46, 315);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(216, 35);
            btnClear.TabIndex = 31;
            btnClear.Text = "LIMPAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(116, 86, 174);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(46, 261);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 35);
            btnLogin.TabIndex = 30;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBxShowPass
            // 
            checkBxShowPass.AutoSize = true;
            checkBxShowPass.Cursor = Cursors.Hand;
            checkBxShowPass.FlatStyle = FlatStyle.Flat;
            checkBxShowPass.Location = new Point(143, 225);
            checkBxShowPass.Name = "checkBxShowPass";
            checkBxShowPass.Size = new Size(144, 27);
            checkBxShowPass.TabIndex = 29;
            checkBxShowPass.Text = "Mostrar Senha";
            checkBxShowPass.UseVisualStyleBackColor = true;
            checkBxShowPass.CheckedChanged += checkBxShowPass_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(46, 191);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 171);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 27;
            label3.Text = "Senha";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(46, 121);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 101);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 25;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(46, 29);
            label1.Name = "label1";
            label1.Size = new Size(197, 34);
            label1.TabIndex = 24;
            label1.Text = "BarbAgenda";
            // 
            // btnFechar
            // 
            btnFechar.ForeColor = Color.FromArgb(116, 86, 174);
            btnFechar.Location = new Point(12, 474);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(119, 29);
            btnFechar.TabIndex = 34;
            btnFechar.Text = "Fechar Tudo";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // frmLoguin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 45);
            ClientSize = new Size(313, 515);
            Controls.Add(btnFechar);
            Controls.Add(btnCreateAccount);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(checkBxShowPass);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmLoguin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoguin";
            Load += frmLoguin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnCreateAccount;
        private Label label5;
        private Button btnClear;
        private Button btnLogin;
        private CheckBox checkBxShowPass;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Button btnFechar;
    }
}