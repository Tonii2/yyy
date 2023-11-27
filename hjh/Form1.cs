using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace hjh
{
    public partial class Form1 : Form
    {
        private static string connectionString = @"Data Source =LAPTOP-RHMTR2G9\SQLEXPRESS;Initial Catalog=yyy;Integrated Security=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterUser(string nombre, string correo, string usuario, string contrase�a)
        {
            // Crear la conexi�n SQL.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el comando SQL.
                using (SqlCommand command = new SqlCommand("INSERT INTO Usuarios (Nombre, Correo, Usuario, Contrase�a) VALUES (@Nombre, @Correo, @Usuario, @Contrase�a)", connection))
                {
                    // Agregar los par�metros al comando SQL.
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrase�a", contrase�a);

                    // Abrir la conexi�n y ejecutar el comando.
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // M�todo para verificar las credenciales de un usuario.
        private bool CheckCredentials(string usuario, string contrase�a)
        {
            // Crear la conexi�n SQL.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el comando SQL.
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contrase�a = @Contrase�a", connection))
                {
                    // Agregar los par�metros al comando SQL.
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrase�a", contrase�a);

                    // Abrir la conexi�n y ejecutar el comando.
                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();

                    // Si userCount es 1, entonces las credenciales son correctas.
                    return userCount == 1;
                }
            }
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in pPrincipal.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.Black;
                }
            }
        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in pPrincipal.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.White;
                }
            }
        }

        private void txtEnter(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in pReg.Controls)
            {
                if (ctr is Panel && ctr.Name == "p" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Black;
                }
            }
        }
        private void txtLeave(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in pReg.Controls)
            {
                if (ctr is Panel && ctr.Name == "p" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Silver;
                }
            }
        }
        private bool controlTimer = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!controlTimer)
            {
                pContenedor.Left += 10;
                pReg.BringToFront();
                if (pContenedor.Left == 400)
                {
                    timer1.Stop();
                    controlTimer = true;
                }
            }
            else
            {
                pContenedor.Left -= 10;
                pCon.BringToFront();
                if (pContenedor.Left == 0)
                {
                    timer1.Stop();
                    controlTimer = false;
                }
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox2.Text;
            string contrase�a = textBox1.Text;

            if (CheckCredentials(usuario, contrase�a))
            {
                MessageBox.Show("Inicio de sesi�n exitoso.");
                // Aqu� puedes abrir la siguiente ventana de tu aplicaci�n.
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos.");
            }
        }

        private void bntReg_Click(object sender, EventArgs e)
        {
            string nombre = txtNom.Text;
            string correo = txtCor.Text;
            string usuario = txtUsu.Text;
            string contrase�a = txtContra.Text;

            RegisterUser(nombre, correo, usuario, contrase�a);

            MessageBox.Show("Usuario registrado exitosamente.");
        }
    }


}