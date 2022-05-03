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
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void btnPedidosVoltar_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            this.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
