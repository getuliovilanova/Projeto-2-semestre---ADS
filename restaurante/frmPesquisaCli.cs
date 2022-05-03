using Renci.SshNet.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Ubiety.Dns.Core.Records.General;

namespace restaurante
{
    public partial class frmPesquisaCli : Form
    {

        GridClientes carregar = new GridClientes();
     
        // *instanciar a classe Conexão e MySqlCommand
        Conexao conexao = new Conexao();
        MySqlCommand comando = new MySqlCommand();
        MySqlDataAdapter da;
        DataTable dt;
        public int x;

        public frmPesquisaCli()
        {
            InitializeComponent();
        }

        private void frmPesqCliente_Load(object sender, EventArgs e)
        {
            habilitaCPF();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoPesqCPf_CheckedChanged(object sender, EventArgs e)
        {
            habilitaCPF();
        }

        private void rdoPesqTelefone_CheckedChanged(object sender, EventArgs e)
        {
            habilitaTelefone();
        }

        private void rdoPesqNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitaNome();
        }

        private void rdoPesqEmail_CheckedChanged(object sender, EventArgs e)
        {
            habilitaEmail();
        }


        public void habilitaCPF()
        {
            txtPesqCPF.Enabled = true;
            txtPesqCPF.Focus();
            txtPesqNome.Clear();
            txtPesqTelefone.Clear();
            txtPesqEmail.Clear();
            txtPesqNome.Enabled = false;
            txtPesqTelefone.Enabled = false;
            txtPesqEmail.Enabled = false;
        }

        public void habilitaNome()
        {
            txtPesqNome.Enabled = true;
            txtPesqNome.Focus();
            txtPesqCPF.Clear();
            txtPesqTelefone.Clear();
            txtPesqEmail.Clear();
            txtPesqCPF.Enabled = false;
            txtPesqTelefone.Enabled = false;
            txtPesqEmail.Enabled = false;
        }

        public void habilitaTelefone()
        {
            txtPesqTelefone.Enabled = true;
            txtPesqTelefone.Focus();
            txtPesqCPF.Clear();
            txtPesqNome.Clear();
            txtPesqEmail.Clear();
            txtPesqCPF.Enabled = false;
            txtPesqNome.Enabled = false;
            txtPesqEmail.Enabled = false;
        }

        public void habilitaEmail()
        {
            txtPesqEmail.Enabled = true;
            txtPesqEmail.Focus();
            txtPesqCPF.Clear();
            txtPesqNome.Clear();
            txtPesqTelefone.Clear();
            txtPesqCPF.Enabled = false;
            txtPesqNome.Enabled = false;
            txtPesqTelefone.Enabled = false;
        }

        private void txtPesqCPF_Click(object sender, EventArgs e)
        {
            rdoPesqCPf.Checked = true;
        }

        private void txtPesqTelefone_Click(object sender, EventArgs e)
        {
            rdoPesqTelefone.Checked = true;
        }

        private void txtPesqNome_Click(object sender, EventArgs e)
        {
            rdoPesqNome.Checked = true;
        }

        private void txtPesqEmail_Click(object sender, EventArgs e)
        {
            rdoPesqEmail.Checked = true;
        }

        private void btnPesqCliente_Click_1(object sender, EventArgs e)
        {
            string compara = "";

            void pesquisacadastro()
            {
                GridClientes carregar = new GridClientes();
                frmClientes formClientes = new frmClientes();
                formClientes.grdClientes.DataSource = carregar.Preenche_grid();
                formClientes.Show();
                this.Close();
            }

            // Array para guardar os valores de cada text box
            string[] captura = { txtPesqCPF.Text, txtPesqNome.Text, txtPesqTelefone.Text, txtPesqEmail.Text };

            //verifica qual text box foi preenchido e atribui o valor para a variável global pesquisa
            for (x = 0; x < 4; x++)
            {
                if (captura[x] != "")
                {
                    GridClientes.dado = captura[x];
                    switch (x)
                    {
                        case 0:
                            GridClientes.campo = "CPF";
                            break;
                        case 1:
                            GridClientes.campo = "Nome";
                            break;
                        case 2:
                            GridClientes.campo = "Telefone";
                            break;
                        case 3:
                            GridClientes.campo = "Email";
                            break;
                    }
                }
            }

            if (string.Equals(compara,GridClientes.dado))
            {
                MessageBox.Show("Selecione um parametro para pesquisar", "Aviso!");
                txtPesqCPF.Focus();
            }
            else
            {
                pesquisacadastro();
            }

            ////// *fazer essa parte com Switch/Case
            /*if (txtPesqCPF.Text != "")
            {
                GridClientes.pesquisa = txtPesqCPF.Text;
                pesquisacadastro();
            }
            else
            {
                if (txtPesqNome.Text != "")
                {
                    GridClientes.pesquisa = txtPesqNome.Text;
                    pesquisacadastro();
                }
                else
                {
                    if (txtPesqTelefone.Text != "")
                    {
                        GridClientes.pesquisa = txtPesqTelefone.Text;
                        pesquisacadastro();
                    }
                    else
                    {
                        if (txtPesqEmail.Text != "")
                        {
                            GridClientes.pesquisa = txtPesqEmail.Text;
                            pesquisacadastro();
                        }
                        else
                        {
                            MessageBox.Show("Selecione um parametro para pesquisar", "Aviso!");
                            txtPesqCPF.Focus();
                        }
                    }
                }
            } //////// Switch Case 
            */
        }
    }
}
