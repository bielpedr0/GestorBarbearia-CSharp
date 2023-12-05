namespace BarbAgenda.Views
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menu = new FlowLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            btnMenu = new PictureBox();
            panelhome = new Panel();
            btnHome = new Button();
            panelDashboard = new Panel();
            btnDash = new Button();
            panelCalendar = new Panel();
            btnCalendario = new Button();
            panel1 = new Panel();
            btnCadastro = new Button();
            panel3 = new Panel();
            btnAgendamento = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            btnSair = new Button();
            sideBarTransition = new System.Windows.Forms.Timer(components);
            menu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panelhome.SuspendLayout();
            panelDashboard.SuspendLayout();
            panelCalendar.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(35, 40, 45);
            menu.Controls.Add(panel2);
            menu.Controls.Add(panelhome);
            menu.Controls.Add(panelDashboard);
            menu.Controls.Add(panelCalendar);
            menu.Controls.Add(panel1);
            menu.Controls.Add(panel3);
            menu.Controls.Add(panel4);
            menu.Controls.Add(panel5);
            menu.Dock = DockStyle.Left;
            menu.Location = new Point(0, 0);
            menu.Margin = new Padding(0);
            menu.Name = "menu";
            menu.Size = new Size(240, 763);
            menu.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnMenu);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 128);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(102, 53);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Location = new Point(30, 41);
            btnMenu.Margin = new Padding(5, 4, 5, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(34, 44);
            btnMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMenu.TabIndex = 0;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelhome
            // 
            panelhome.Controls.Add(btnHome);
            panelhome.Location = new Point(0, 128);
            panelhome.Margin = new Padding(0);
            panelhome.Name = "panelhome";
            panelhome.Size = new Size(266, 89);
            panelhome.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Black;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(-17, -13);
            btnHome.Margin = new Padding(5, 4, 5, 4);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(40, 0, 0, 0);
            btnHome.Size = new Size(283, 121);
            btnHome.TabIndex = 1;
            btnHome.Text = "             Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(btnDash);
            panelDashboard.Location = new Point(0, 217);
            panelDashboard.Margin = new Padding(0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(266, 79);
            panelDashboard.TabIndex = 2;
            // 
            // btnDash
            // 
            btnDash.BackColor = Color.Black;
            btnDash.FlatStyle = FlatStyle.Flat;
            btnDash.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDash.ForeColor = Color.White;
            btnDash.ImageAlign = ContentAlignment.MiddleLeft;
            btnDash.Location = new Point(-17, -17);
            btnDash.Margin = new Padding(5, 4, 5, 4);
            btnDash.Name = "btnDash";
            btnDash.Padding = new Padding(40, 0, 0, 0);
            btnDash.Size = new Size(283, 112);
            btnDash.TabIndex = 3;
            btnDash.Text = "             Dashboard";
            btnDash.TextAlign = ContentAlignment.MiddleLeft;
            btnDash.UseVisualStyleBackColor = false;
            btnDash.Click += button2_Click;
            // 
            // panelCalendar
            // 
            panelCalendar.Controls.Add(btnCalendario);
            panelCalendar.Location = new Point(0, 296);
            panelCalendar.Margin = new Padding(0);
            panelCalendar.Name = "panelCalendar";
            panelCalendar.Size = new Size(266, 83);
            panelCalendar.TabIndex = 3;
            // 
            // btnCalendario
            // 
            btnCalendario.BackColor = Color.Black;
            btnCalendario.FlatStyle = FlatStyle.Flat;
            btnCalendario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalendario.ForeColor = Color.White;
            btnCalendario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalendario.Location = new Point(-17, -16);
            btnCalendario.Margin = new Padding(5, 4, 5, 4);
            btnCalendario.Name = "btnCalendario";
            btnCalendario.Padding = new Padding(40, 0, 0, 0);
            btnCalendario.Size = new Size(283, 121);
            btnCalendario.TabIndex = 4;
            btnCalendario.Text = "             Calendario";
            btnCalendario.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendario.UseVisualStyleBackColor = false;
            btnCalendario.Click += btnCalendario_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCadastro);
            panel1.Location = new Point(0, 379);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 89);
            panel1.TabIndex = 4;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.Black;
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastro.Location = new Point(-17, -13);
            btnCadastro.Margin = new Padding(5, 4, 5, 4);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Padding = new Padding(40, 0, 0, 0);
            btnCadastro.Size = new Size(283, 121);
            btnCadastro.TabIndex = 5;
            btnCadastro.Text = "             Cadastro";
            btnCadastro.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAgendamento);
            panel3.Location = new Point(0, 468);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(266, 89);
            panel3.TabIndex = 5;
            // 
            // btnAgendamento
            // 
            btnAgendamento.BackColor = Color.Black;
            btnAgendamento.FlatStyle = FlatStyle.Flat;
            btnAgendamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendamento.ForeColor = Color.White;
            btnAgendamento.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgendamento.Location = new Point(-17, -13);
            btnAgendamento.Margin = new Padding(5, 4, 5, 4);
            btnAgendamento.Name = "btnAgendamento";
            btnAgendamento.Padding = new Padding(40, 0, 0, 0);
            btnAgendamento.Size = new Size(283, 121);
            btnAgendamento.TabIndex = 5;
            btnAgendamento.Text = "            Agendamento";
            btnAgendamento.TextAlign = ContentAlignment.MiddleLeft;
            btnAgendamento.UseVisualStyleBackColor = false;
            btnAgendamento.Click += btnAgendamento_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(0, 557);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 104);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSair);
            panel5.Location = new Point(0, 661);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(266, 96);
            panel5.TabIndex = 7;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Black;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.ForeColor = Color.White;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(-17, -8);
            btnSair.Margin = new Padding(5, 4, 5, 4);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(40, 0, 0, 0);
            btnSair.Size = new Size(283, 121);
            btnSair.TabIndex = 5;
            btnSair.Text = "             Sair";
            btnSair.TextAlign = ContentAlignment.MiddleLeft;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // sideBarTransition
            // 
            sideBarTransition.Interval = 10;
            sideBarTransition.Tick += menuTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1140, 763);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IsMdiContainer = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            menu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panelhome.ResumeLayout(false);
            panelDashboard.ResumeLayout(false);
            panelCalendar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel menu;
        private Panel panelhome;
        private Panel panel2;
        private Button btnHome;
        private Panel panelDashboard;
        private Button btnDash;
        private Panel panelCalendar;
        private Button btnCalendario;
        private PictureBox btnMenu;
        private Label label1;
        private System.Windows.Forms.Timer sideBarTransition;
        private Button btnCadastro;
        private Panel panel1;
        private Panel panel3;
        private Button btnAgendamento;
        private Panel panel4;
        private Panel panel5;
        private Button btnSair;
    }
}

