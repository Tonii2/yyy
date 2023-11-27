namespace hjh
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            menuContainer = new FlowLayoutPanel();
            panel2 = new Panel();
            multa = new Button();
            panel6 = new Panel();
            Reg = new Button();
            panel7 = new Panel();
            His = new Button();
            pnSettings = new Panel();
            button2 = new Button();
            pnAbout = new Panel();
            button3 = new Button();
            pnLogout = new Panel();
            button4 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            menuContainer.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            pnSettings.SuspendLayout();
            pnAbout.SuspendLayout();
            pnLogout.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1288, 46);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1149, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 9);
            label1.Name = "label1";
            label1.Size = new Size(533, 31);
            label1.TabIndex = 1;
            label1.Text = "SISTEMA DE MULTAS | CIUDAD DE LA PAZ, BOLIVIA";
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(0, 0);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(55, 47);
            btnHam.SizeMode = PictureBoxSizeMode.Zoom;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(pnSettings);
            sidebar.Controls.Add(pnAbout);
            sidebar.Controls.Add(pnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 46);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(375, 616);
            sidebar.TabIndex = 1;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.Black;
            menuContainer.Controls.Add(panel2);
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel7);
            menuContainer.Location = new Point(3, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(359, 40);
            menuContainer.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(multa);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 40);
            panel2.TabIndex = 3;
            // 
            // multa
            // 
            multa.BackColor = Color.Black;
            multa.FlatAppearance.BorderColor = Color.Black;
            multa.FlatStyle = FlatStyle.Flat;
            multa.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            multa.ForeColor = Color.White;
            multa.Image = (Image)resources.GetObject("multa.Image");
            multa.ImageAlign = ContentAlignment.MiddleLeft;
            multa.Location = new Point(0, -29);
            multa.Name = "multa";
            multa.Padding = new Padding(25, 0, 0, 0);
            multa.Size = new Size(376, 93);
            multa.TabIndex = 2;
            multa.Text = "          Multa";
            multa.TextAlign = ContentAlignment.MiddleLeft;
            multa.UseVisualStyleBackColor = false;
            multa.Click += multa_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(Reg);
            panel6.Location = new Point(3, 49);
            panel6.Name = "panel6";
            panel6.Size = new Size(359, 40);
            panel6.TabIndex = 7;
            // 
            // Reg
            // 
            Reg.BackColor = Color.Black;
            Reg.FlatAppearance.BorderColor = Color.Black;
            Reg.FlatStyle = FlatStyle.Flat;
            Reg.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Reg.ForeColor = Color.White;
            Reg.Image = (Image)resources.GetObject("Reg.Image");
            Reg.ImageAlign = ContentAlignment.MiddleLeft;
            Reg.Location = new Point(0, -29);
            Reg.Name = "Reg";
            Reg.Padding = new Padding(25, 0, 0, 0);
            Reg.Size = new Size(376, 93);
            Reg.TabIndex = 2;
            Reg.Text = "          Registro";
            Reg.TextAlign = ContentAlignment.MiddleLeft;
            Reg.UseVisualStyleBackColor = false;
            Reg.Click += Reg_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Controls.Add(His);
            panel7.Location = new Point(3, 95);
            panel7.Name = "panel7";
            panel7.Size = new Size(359, 40);
            panel7.TabIndex = 8;
            // 
            // His
            // 
            His.BackColor = Color.Black;
            His.FlatAppearance.BorderColor = Color.Black;
            His.FlatStyle = FlatStyle.Flat;
            His.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            His.ForeColor = Color.White;
            His.Image = (Image)resources.GetObject("His.Image");
            His.ImageAlign = ContentAlignment.MiddleLeft;
            His.Location = new Point(0, -29);
            His.Name = "His";
            His.Padding = new Padding(25, 0, 0, 0);
            His.Size = new Size(376, 93);
            His.TabIndex = 2;
            His.Text = "          Historial";
            His.TextAlign = ContentAlignment.MiddleLeft;
            His.UseVisualStyleBackColor = false;
            // 
            // pnSettings
            // 
            pnSettings.BackColor = Color.Black;
            pnSettings.Controls.Add(button2);
            pnSettings.Location = new Point(3, 49);
            pnSettings.Name = "pnSettings";
            pnSettings.Size = new Size(359, 40);
            pnSettings.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, -29);
            button2.Name = "button2";
            button2.Padding = new Padding(25, 0, 0, 0);
            button2.Size = new Size(376, 93);
            button2.TabIndex = 2;
            button2.Text = "          Administración";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // pnAbout
            // 
            pnAbout.BackColor = Color.Black;
            pnAbout.Controls.Add(button3);
            pnAbout.Location = new Point(3, 95);
            pnAbout.Name = "pnAbout";
            pnAbout.Size = new Size(359, 40);
            pnAbout.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, -29);
            button3.Name = "button3";
            button3.Padding = new Padding(25, 0, 0, 0);
            button3.Size = new Size(376, 93);
            button3.TabIndex = 2;
            button3.Text = "          Acerca de";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // pnLogout
            // 
            pnLogout.BackColor = Color.Black;
            pnLogout.Controls.Add(button4);
            pnLogout.Location = new Point(3, 141);
            pnLogout.Name = "pnLogout";
            pnLogout.Size = new Size(359, 40);
            pnLogout.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, -29);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.Size = new Size(376, 93);
            button4.TabIndex = 2;
            button4.Text = "          Salir";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1288, 662);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            pnSettings.ResumeLayout(false);
            pnAbout.ResumeLayout(false);
            pnLogout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel sidebar;
        private Button multa;
        private Panel panel2;
        private Panel pnSettings;
        private Button button2;
        private Panel pnAbout;
        private Button button3;
        private Panel pnLogout;
        private Button button4;
        private Panel panel6;
        private Button Reg;
        private Panel panel7;
        private Button His;
        private FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}