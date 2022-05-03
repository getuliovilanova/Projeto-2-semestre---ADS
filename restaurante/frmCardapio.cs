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
using Ubiety.Dns.Core.Records;

namespace restaurante
{
    public partial class frmCardapio : Form
    {
        // *instanciar a classe Conexão e MySqlCommand
        Conexao conexao = new Conexao();
        MySqlConnection conectado;
        MySqlCommand comando = new MySqlCommand();
        MySqlDataAdapter adaptador;
        DataTable dttcardapio;
          
        public frmCardapio()
        {
            InitializeComponent();

        }

        public void Preencher()
        {//preenche o Data Grid com os dados da tabela cardapio
            
            conexao.conectar();
            //recebe endereço do bd p/ se conectar
            //Comando Sql -> Select
            string strSelect = "SELECT* FROM restaurante.tbcardapio;";
            //Cria o Data Table (recipiente temporário p/os dados)
            DataTable dttcardapio = new DataTable();
            conexao.desconectar();

            try
            {
                MySqlDataAdapter adaptador = new MySqlDataAdapter(strSelect, conexao.conectar());
                // preenche o Data Grid
                adaptador.Fill(dttcardapio);
                dgvCardapio.DataSource = dttcardapio;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void Limpar()
        {
            /*
            txtNomeProduto.Text = "";
            txtDescricao.Clear();
            txtCategoria.Clear();
            txtValor.Clear();
            */
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
         /*   //conectar com o bd  -- instanciar a classe conexão
            try
            {
                //Comando Sql -> insert
                comando.CommandText = "insert into restaurante.tbcardapio (Nome,Descricao,ValorUn,Categoria)" +
                    " values (@Nome,@Descricao,@ValorUn,@Categoria)";

                //parametros
                comando.Parameters.AddWithValue("@Nome", txtNomeProduto.Text);
                comando.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                comando.Parameters.AddWithValue("@ValorUn", txtValor.Text);
                comando.Parameters.AddWithValue("@Categoria", txtCategoria.Text);

                //recebe endereço do bd p/ se conectar
                comando.Connection = conexao.conectar();
                //executar o comando
                comando.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //conexao = null;
                comando = null;
                //msg de sucesso ou erro
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                Preencher();
                conexao = null;
                Limpar();
            }*/
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void btnCardapioVoltar_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            this.Close();
            form.Show();
        }

        private void frmCardapio_Load(object sender, EventArgs e)
        {
            Preencher();
        }

        private void dgvCardapio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
