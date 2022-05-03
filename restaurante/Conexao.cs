using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace restaurante
{
    // Construtor da conexão
    public class Conexao
    {
        MySqlConnection con = new MySqlConnection("Server=tuliovilanova.mysql.database.azure.com; " +
            "Port=3306; Database=restaurante; Uid=adminrestaurante@tuliovilanova; " +
            "Pwd=@teste4321;");

        // Metodo Conectar
        public MySqlConnection conectar()
        {// verifica se a conexão está fechada, se estiver conecta ao database
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        // Método Desconectar

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {// verifica se a conexão está aberta, se estiver fecha a conexão
                con.Close();
            }
        }

    }
}
