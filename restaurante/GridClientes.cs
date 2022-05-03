using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;

namespace restaurante
{
    class GridClientes
    {
        Conexao conexao = new Conexao();
        MySqlCommand comando = new MySqlCommand();
        MySqlDataAdapter da;

        public static string dado;
        public static string campo;


        public DataTable Preenche_grid()
        {
            //Comando Sql -> Select
            //string strSelect = "select CPF,Nome,Telefone,Email,Endereco from tbclientes where" + campo + "='" + dado + "';";
            string strSelect = "select CPF,Nome,Telefone,Email,Endereco from tbclientes where " + campo + "='" + dado + "';";
            //Cria o Data Table
            DataTable dtt = new DataTable();
            
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(strSelect, conexao.conectar());
                // preenche o Data Grid
                da.Fill(dtt);
                comando.Dispose();
                conexao.desconectar();
                return dtt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
