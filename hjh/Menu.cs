using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hjh
{
    public partial class Menu : Form
    {
        FormRegistro registro;
        FormHistorial historial;
        FormDerechoshumanos derechoshumanos;
        FormAcercade acercade;
        public Menu()
        {
            InitializeComponent();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


        bool menuExpand = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 143)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 40)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void multa_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }


        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 86)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnSettings.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width <= 375)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnSettings.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            if (registro == null)
            {
                registro = new FormRegistro();
                registro.FormClosed += Registro_FormClosed;
                registro.MdiParent = this;
                registro.Dock = DockStyle.Fill;
                registro.Show();
            }
            else
            {
                registro.Activate();
            }
        }
        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            registro = null;
        }

    }
}
