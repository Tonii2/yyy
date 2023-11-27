namespace hjh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pPrincipal = new Panel();
            btnAc = new Button();
            label3 = new Label();
            label4 = new Label();
            btnRegistro = new Button();
            label2 = new Label();
            label1 = new Label();
            pContenedor = new Panel();
            pCon = new Panel();
            button1 = new Button();
            pContraI = new Panel();
            textBox1 = new TextBox();
            label10 = new Label();
            pUsuarioI = new Panel();
            textBox2 = new TextBox();
            label11 = new Label();
            label14 = new Label();
            pictureBox2 = new PictureBox();
            pReg = new Panel();
            bntReg = new Button();
            pContra = new Panel();
            txtContra = new TextBox();
            label9 = new Label();
            pUsuario = new Panel();
            txtUsu = new TextBox();
            label8 = new Label();
            pCorreo = new Panel();
            txtCor = new TextBox();
            label7 = new Label();
            pNombre = new Panel();
            txtNom = new TextBox();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pPrincipal.SuspendLayout();
            pContenedor.SuspendLayout();
            pCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pPrincipal
            // 
            pPrincipal.BackColor = Color.Black;
            pPrincipal.Controls.Add(btnAc);
            pPrincipal.Controls.Add(label3);
            pPrincipal.Controls.Add(label4);
            pPrincipal.Controls.Add(btnRegistro);
            pPrincipal.Controls.Add(label2);
            pPrincipal.Controls.Add(label1);
            pPrincipal.Location = new Point(0, 40);
            pPrincipal.Name = "pPrincipal";
            pPrincipal.Size = new Size(807, 370);
            pPrincipal.TabIndex = 0;
            // 
            // btnAc
            // 
            btnAc.BackColor = Color.Transparent;
            btnAc.FlatAppearance.BorderColor = Color.White;
            btnAc.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btnAc.FlatAppearance.MouseOverBackColor = Color.White;
            btnAc.FlatStyle = FlatStyle.Flat;
            btnAc.Font = new Font("Lato", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnAc.ForeColor = Color.White;
            btnAc.Location = new Point(21, 215);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(331, 41);
            btnAc.TabIndex = 5;
            btnAc.Text = "Iniciar";
            btnAc.UseVisualStyleBackColor = false;
            btnAc.Click += btnAc_Click;
            btnAc.MouseEnter += btnMouseEnter;
            btnAc.MouseLeave += btnMouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 119);
            label3.Name = "label3";
            label3.Size = new Size(252, 26);
            label3.TabIndex = 4;
            label3.Text = "Click para iniciar sesión";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Lato", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(-10, 41);
            label4.Name = "label4";
            label4.Size = new Size(371, 41);
            label4.TabIndex = 3;
            label4.Text = "¿Cuentas con usuario?";
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.Transparent;
            btnRegistro.FlatAppearance.BorderColor = Color.White;
            btnRegistro.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btnRegistro.FlatAppearance.MouseOverBackColor = Color.White;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Lato", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistro.ForeColor = Color.White;
            btnRegistro.Location = new Point(429, 215);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(331, 41);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            btnRegistro.MouseEnter += btnMouseEnter;
            btnRegistro.MouseLeave += btnMouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(443, 119);
            label2.Name = "label2";
            label2.Size = new Size(297, 26);
            label2.TabIndex = 1;
            label2.Text = "Regístrate dando click abajo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Lato", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(412, 41);
            label1.Name = "label1";
            label1.Size = new Size(383, 41);
            label1.TabIndex = 0;
            label1.Text = "¿No tienes una cuenta?";
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.White;
            pContenedor.Controls.Add(pCon);
            pContenedor.Controls.Add(pReg);
            pContenedor.Location = new Point(0, 10);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(400, 430);
            pContenedor.TabIndex = 1;
            // 
            // pCon
            // 
            pCon.Controls.Add(button1);
            pCon.Controls.Add(pContraI);
            pCon.Controls.Add(textBox1);
            pCon.Controls.Add(label10);
            pCon.Controls.Add(pUsuarioI);
            pCon.Controls.Add(textBox2);
            pCon.Controls.Add(label11);
            pCon.Controls.Add(label14);
            pCon.Controls.Add(pictureBox2);
            pCon.Location = new Point(6, 5);
            pCon.Name = "pCon";
            pCon.Size = new Size(390, 420);
            pCon.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            button1.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lato", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 285);
            button1.Name = "button1";
            button1.Size = new Size(362, 41);
            button1.TabIndex = 14;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pContraI
            // 
            pContraI.BackColor = Color.Silver;
            pContraI.Location = new Point(17, 249);
            pContraI.Name = "pContraI";
            pContraI.Size = new Size(362, 3);
            pContraI.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(15, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 30);
            textBox1.TabIndex = 12;
            textBox1.Tag = "ContraI";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 195);
            label10.Name = "label10";
            label10.Size = new Size(116, 24);
            label10.TabIndex = 11;
            label10.Text = "Contraseña:";
            // 
            // pUsuarioI
            // 
            pUsuarioI.BackColor = Color.Silver;
            pUsuarioI.Location = new Point(17, 180);
            pUsuarioI.Name = "pUsuarioI";
            pUsuarioI.Size = new Size(362, 3);
            pUsuarioI.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(13, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(362, 30);
            textBox2.TabIndex = 9;
            textBox2.Tag = "UsuarioI";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(12, 126);
            label11.Name = "label11";
            label11.Size = new Size(84, 24);
            label11.TabIndex = 8;
            label11.Text = "Usuario:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Lato", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(80, 85);
            label14.Name = "label14";
            label14.Size = new Size(231, 41);
            label14.TabIndex = 1;
            label14.Text = "Iniciar Sesión";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(157, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pReg
            // 
            pReg.Controls.Add(bntReg);
            pReg.Controls.Add(pContra);
            pReg.Controls.Add(txtContra);
            pReg.Controls.Add(label9);
            pReg.Controls.Add(pUsuario);
            pReg.Controls.Add(txtUsu);
            pReg.Controls.Add(label8);
            pReg.Controls.Add(pCorreo);
            pReg.Controls.Add(txtCor);
            pReg.Controls.Add(label7);
            pReg.Controls.Add(pNombre);
            pReg.Controls.Add(txtNom);
            pReg.Controls.Add(label6);
            pReg.Controls.Add(label5);
            pReg.Controls.Add(pictureBox1);
            pReg.Location = new Point(9, 5);
            pReg.Name = "pReg";
            pReg.Size = new Size(390, 420);
            pReg.TabIndex = 0;
            // 
            // bntReg
            // 
            bntReg.BackColor = Color.Black;
            bntReg.FlatAppearance.BorderColor = Color.White;
            bntReg.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            bntReg.FlatAppearance.MouseOverBackColor = Color.DimGray;
            bntReg.FlatStyle = FlatStyle.Flat;
            bntReg.Font = new Font("Lato", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            bntReg.ForeColor = Color.White;
            bntReg.Location = new Point(12, 372);
            bntReg.Name = "bntReg";
            bntReg.Size = new Size(362, 41);
            bntReg.TabIndex = 14;
            bntReg.Text = "Registrar";
            bntReg.UseVisualStyleBackColor = false;
            bntReg.Click += bntReg_Click;
            // 
            // pContra
            // 
            pContra.BackColor = Color.Silver;
            pContra.Location = new Point(15, 363);
            pContra.Name = "pContra";
            pContra.Size = new Size(362, 3);
            pContra.TabIndex = 13;
            // 
            // txtContra
            // 
            txtContra.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContra.Location = new Point(13, 334);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(362, 30);
            txtContra.TabIndex = 12;
            txtContra.Tag = "Contra";
            txtContra.Enter += txtEnter;
            txtContra.Leave += txtLeave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(13, 310);
            label9.Name = "label9";
            label9.Size = new Size(116, 24);
            label9.TabIndex = 11;
            label9.Text = "Contraseña:";
            // 
            // pUsuario
            // 
            pUsuario.BackColor = Color.Silver;
            pUsuario.Location = new Point(14, 304);
            pUsuario.Name = "pUsuario";
            pUsuario.Size = new Size(362, 3);
            pUsuario.TabIndex = 10;
            // 
            // txtUsu
            // 
            txtUsu.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsu.Location = new Point(12, 275);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(362, 30);
            txtUsu.TabIndex = 9;
            txtUsu.Tag = "Usuario";
            txtUsu.Enter += txtEnter;
            txtUsu.Leave += txtLeave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 251);
            label8.Name = "label8";
            label8.Size = new Size(84, 24);
            label8.TabIndex = 8;
            label8.Text = "Usuario:";
            // 
            // pCorreo
            // 
            pCorreo.BackColor = Color.Silver;
            pCorreo.Location = new Point(15, 235);
            pCorreo.Name = "pCorreo";
            pCorreo.Size = new Size(362, 3);
            pCorreo.TabIndex = 7;
            // 
            // txtCor
            // 
            txtCor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCor.Location = new Point(13, 206);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(362, 30);
            txtCor.TabIndex = 6;
            txtCor.Tag = "Correo";
            txtCor.Enter += txtEnter;
            txtCor.Leave += txtLeave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 182);
            label7.Name = "label7";
            label7.Size = new Size(177, 24);
            label7.TabIndex = 5;
            label7.Text = "Correo electrónico:";
            // 
            // pNombre
            // 
            pNombre.BackColor = Color.Silver;
            pNombre.Location = new Point(14, 173);
            pNombre.Name = "pNombre";
            pNombre.Size = new Size(362, 3);
            pNombre.TabIndex = 4;
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNom.Location = new Point(12, 144);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(362, 30);
            txtNom.TabIndex = 3;
            txtNom.Tag = "Nombre";
            txtNom.Enter += txtEnter;
            txtNom.Leave += txtLeave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 120);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 2;
            label6.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(111, 85);
            label5.Name = "label5";
            label5.Size = new Size(153, 41);
            label5.TabIndex = 1;
            label5.Text = "Registro";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(157, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(807, 442);
            Controls.Add(pContenedor);
            Controls.Add(pPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.MidnightBlue;
            pPrincipal.ResumeLayout(false);
            pPrincipal.PerformLayout();
            pContenedor.ResumeLayout(false);
            pCon.ResumeLayout(false);
            pCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pReg.ResumeLayout(false);
            pReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pPrincipal;
        private Label label2;
        private Label label1;
        private Button btnRegistro;
        private Button btnAc;
        private Label label3;
        private Label label4;
        private Panel pContenedor;
        private Panel pReg;
        private PictureBox pictureBox1;
        private TextBox txtNom;
        private Label label6;
        private Label label5;
        private Panel pContra;
        private TextBox txtContra;
        private Label label9;
        private Panel pUsuario;
        private TextBox txtUsu;
        private Label label8;
        private Panel pCorreo;
        private TextBox txtCor;
        private Label label7;
        private Panel pNombre;
        private Button bntReg;
        private Panel pCon;
        private Button button1;
        private Panel pContraI;
        private TextBox textBox1;
        private Label label10;
        private Panel pUsuarioI;
        private TextBox textBox2;
        private Label label11;
        private Label label14;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}