using MySql.Data.MySqlClient;
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


    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void cardapioTSM_Click(object sender, EventArgs e)
        {

        }


        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
         /*   Cadastro cad = new Cadastro(txtCPF.Text, txtNome.Text, txtTelefone.Text,
                txtEmail.Text, txtEndereco.Text);
            MessageBox.Show(cad.mensagem); */
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Chamar o form Menu
            frmClientes form = new frmClientes();
            this.Close();
            form.Show();

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            // Chamar o form Menu
            frmPedidos form = new frmPedidos();
            this.Close();
            form.Show();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {   
            // Chamar o form Menu
            frmCardapio form = new frmCardapio();
            this.Close();
            form.Show();
        }
    }
}
