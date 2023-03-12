using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.DAL
{
    public class Conexao
    {
        //cria uma nova conexão SQL Server
        SqlConnection con = new SqlConnection();

        //construtor da classe, define a string de conexão
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-M8P312K\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True";
        }

        //abre a conexão com o banco de dados
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //fecha a conexão com o banco de dados
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}