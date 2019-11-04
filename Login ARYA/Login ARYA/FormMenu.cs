using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_ARYA
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
           Login();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formServicios = new FormServicios();
            formServicios.MdiParent = this;
            formServicios.Show();
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formOrdenes = new FormOrdenes();
            formOrdenes.MdiParent = this;
            formOrdenes.Show();
        }

        private void diagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDiagnosticos = new FormDiagnosticos();
            formDiagnosticos.MdiParent = this;
            formDiagnosticos.Show();
        }
    }
}
