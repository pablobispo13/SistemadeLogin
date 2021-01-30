using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Login.Classes
{
    class Cad_usuario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public Cad_usuario(String nome, String cpf, String senha)
        {

            //Comando SQL --SQLCommand
            cmd.CommandText = " INSERT INTO usuario (nome_usu,cpf_usu,senha_usu) VALUES (@Nome, @CPF, @senha)";
            //Parametros         
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);
          

            //
            //
            try
            {
                //Conectar com banco atraves da classe conexao
                cmd.Connection = conexao.conectar();
                //Executar comando
                cmd.ExecuteNonQuery();
                //Desconectar 
                conexao.desconectar();
                //Mostrar mensagem de erro ou sucesso--variavel
                this.mensagem = "Cadastrado com Sucesso!!";

            }
            catch (SqlException e)
            {
                this.mensagem = "Houve um erro ao cadastrar" + e;
            }
        }
    }

}
