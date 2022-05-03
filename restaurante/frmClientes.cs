using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurante
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void pnlClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientesVoltar_Click(object sender, EventArgs e)
        {
            frmMenu formMenu = new frmMenu();
            this.Close();        
            formMenu.Show();
        }

        private void btnPesqCliente_Click(object sender, EventArgs e)
        {
            frmPesquisaCli formpesq = new frmPesquisaCli();
            formpesq.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
