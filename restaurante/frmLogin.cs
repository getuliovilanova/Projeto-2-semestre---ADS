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

namespace restaurante
{
    public partial class frmLogin : Form
    {
        Conexao conexao = new Conexao();
        MySqlCommand comando = new MySqlCommand();
        DataTable dttcardapio = new DataTable();
        int resultado;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            resultado = 0;
            comando.Connection = conexao.conectar();
            comando.CommandText = "SELECT * FROM tbusuarios where NomeUsuario = '" + txtUsuario.Text + "' and Senha = '" + txtSenha.Text + "';";
            comando.ExecuteNonQuery();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dttcardapio);
            resultado = Convert.ToInt32(dttcardapio.Rows.Count.ToString());
            conexao.desconectar();

            if (resultado == 0)
            {
                MessageBox.Show("Usuário ou senha incorreta!", "Erro de Login");
            }
            else
            {
                // Chamar o form Menu
                frmMenu form = new frmMenu();
                this.Hide();
                form.Show();
                
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
