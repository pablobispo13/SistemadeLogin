using System;
using System.Collections.Generic;
using System.Data.SqlClient; //é necessario inserir essa import para fazer a conexão com o banco de dados
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Login.Classes
{
    class Conexao
    {
       SqlConnection con = new SqlConnection(); //coloca a conexão na variavel con
        
        public Conexao()
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=bd_sistemadelogin;Integrated Security=True"; //linha de conexao recomendada(caso esteja usando o sql server express)
           
        }
        //Metodo conectar
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;

        }
        //Metodo desconectar
        public void desconectar()
        {

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

