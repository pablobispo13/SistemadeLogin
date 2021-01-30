using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin; //é necessario inserir esse import para o design do app, juntamente de ter a referência instalada

namespace Sistema_de_Login
{
    //Caso tenha alguma duvida ou algum código tiver um comentario com numero acesse  a "centraldeinformacoes.txt" para mais informações
    public partial class Login : MaterialSkin.Controls.MaterialForm //define o uso do design do materialskin
    {
        MaterialSkinManager skinManager;
        Classes.Conexao conexao = new Classes.Conexao();
        bool erro;
        public Login()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;//coloca o estilo dark como padrão ao abrir o app
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
            if (erro == true)
            {

            }
            else
            {
                Login_automatico();
            }

        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void bt_tema_Click(object sender, EventArgs e)
        {
            
            tema();//tema
        }
        private void logar()
        {
           
            try
            {
                
                string cpf = msk_cpf.Text;
                string senha = txt_senha.Text;
               
                if (cpf == "   ,   ,   -")//verifica se não foi colocado nada no cpf
                {
                    notificação.ShowBalloonTip(1000, "Aviso ", "Preencha o campo do CPF", ToolTipIcon.Info);//1
                }
                else if (senha == "")//verifica se não foi colocado nada na senha
                {
                    notificação.ShowBalloonTip(1000, "Aviso ", "Preencha o campo da senha", ToolTipIcon.Info);
                }
                else
                {
                    
                    if (Classes.ValidaCPF.CPF(cpf))//verifica se o cpf é válido
                    {
                        string sql = "";
                        sql = "SELECT * FROM usuario WHERE cpf_usu='" + cpf + "' and senha_usu='" + senha + "'";

                        SqlDataAdapter dp = new SqlDataAdapter(sql, conexao.conectar());//faz a busca no banco de dados para ver se o cadastro existe
                        DataTable dt = new DataTable();                
                        dp.Fill(dt);

                        if (dt.Rows.Count == 1)//se tiver um cadastro onde a senha e o cpf forem igual ao cadastrado
                        {
                            notificação.ShowBalloonTip(1000, "Aviso ", "Logado com sucesso", ToolTipIcon.Info);//ele faz o login

                            string pegardados = "SELECT * FROM usuario WHERE cpf_usu='" + cpf + "'";
                            SqlCommand cmd = new SqlCommand(pegardados, conexao.conectar());

                            cmd.CommandType = CommandType.Text;
                            SqlDataReader reader;
                            conexao.conectar();


                            reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {

                                
                                Classes.Global.nome = reader[1].ToString();//pega o nome da pessoa com cadastro e envia para uma variavel global
                                
                            }
                            reader.Close();
                            notificação.Visible = false;
                            Administrativo Administrativo = new Administrativo();//vai para a tela administrativa
                            Administrativo.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            notificação.ShowBalloonTip(1000, "Aviso ", "Usuário e senha incorretos ou o usuario não foi cadastrado", ToolTipIcon.Info);//se n tiver nada cadastrado
                        }
                    }
                    else
                    {
                        notificação.ShowBalloonTip(1000, "Aviso ", "CPF invalido", ToolTipIcon.Info);//caso seja o cpf seja falso ou n seja valido
                    }
                }
               
            }
          catch
            {
                notificação.ShowBalloonTip(1000, "Houve algum erro no sistema ", "Algum erro inesperado no login ocorreu!", ToolTipIcon.Error);
            }
          
        }
        private void tema()
        {
            if (skinManager.Theme == MaterialSkinManager.Themes.DARK)
            {
                msk_cpf.BackColor = Color.White;
                msk_cpf.ForeColor = Color.Black;
                
                msk_cpf_cad.BackColor = Color.White;
                msk_cpf_cad.ForeColor = Color.Black;
                skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                bt_tema.Text = "DARK"; 
            }
            else
            {
              
                msk_cpf.BackColor = Color.FromArgb(51, 51, 51);
                msk_cpf.ForeColor = Color.White;

                msk_cpf_cad.BackColor = Color.FromArgb(51, 51, 51);
                msk_cpf_cad.ForeColor = Color.White;
                skinManager.Theme = MaterialSkinManager.Themes.DARK;
                bt_tema.Text = "Light";
            }
        }
        
        private void Cadastrar()
            {
                try
                {
                       
                        string cpf = msk_cpf_cad.Text;
                        string senha = txt_senha_cad.Text;
                        string conf_senha = txt_conf_senha.Text;
                        string nome = txt_nome.Text;
                        if (nome == "")
                        {
                            notificação.ShowBalloonTip(1000, "Aviso ", "Preencha o campo do nome", ToolTipIcon.Info);
                            erro = true;
                        }
                        else if (cpf == "   ,   ,   -")
                        {
                            notificação.ShowBalloonTip(1000, "Aviso ", "Preencha o campo do CPF", ToolTipIcon.Info);
                           erro = true;
                        }
                      
                        else if (senha == "")
                        {
                            notificação.ShowBalloonTip(1000, "Aviso ", "Preencha o campo da senha", ToolTipIcon.Info); erro = true;

                }
                        else if (conf_senha == "")
                        {
                            notificação.ShowBalloonTip(1000, "Aviso ", "Preencha o campo da confirmação de senha", ToolTipIcon.Info); erro = true;
                }
                        else
                        {
                            if (Classes.ValidaCPF.CPF(cpf))//verifica se o cpf é válido
                            {
                                string sql = "";
                                sql = "SELECT * FROM usuario WHERE cpf_usu='" + cpf + "'";

                                SqlDataAdapter dp = new SqlDataAdapter(sql, conexao.conectar());
                                DataTable dt = new DataTable();
                                dp.Fill(dt);

                                if (dt.Rows.Count >= 1)//ve se tem algum cadastro com o cpf inserido
                                {
                                      notificação.ShowBalloonTip(1000, "Aviso ", "CPF ja cadastrado no sistema", ToolTipIcon.Info); erro = true;

                                }
                                else
                                {
                                        if(senha == conf_senha)//se ambas senhas forem iguais  ele faz o cadastro usando a classe Cad_usuario
                                        {
                                            Classes.Cad_usuario cad = new Classes.Cad_usuario(nome, cpf, senha);

                                           notificação.ShowBalloonTip(1000, "Aviso ", cad.mensagem, ToolTipIcon.Info); 

                                            erro = false;
                                        }
                                        else
                                        {
                                             notificação.ShowBalloonTip(1000, "Aviso ", "As senhas não se coincidem", ToolTipIcon.Info); erro = true;
                            }
                                     
                                }
                            }

                            else
                            {
                                notificação.ShowBalloonTip(1000, "Aviso ", "CPF invalido", ToolTipIcon.Info); erro = true;
                    }
                        }
                }
                catch
                {
                    notificação.ShowBalloonTip(1000, "Houve algum erro no sistema ", "Algum erro inesperado no cadastro de usuario ocorreu!", ToolTipIcon.Error);
                      erro = true;
                }
        }
        private void Login_automatico()
        {
            string cpf = msk_cpf_cad.Text;
            notificação.ShowBalloonTip(1000, "Aviso ", "Login automatico realizado com sucesso", ToolTipIcon.Info);//ele faz o login
            string pegardados = "SELECT * FROM usuario WHERE cpf_usu='" + cpf + "'";
            SqlCommand cmd = new SqlCommand(pegardados, conexao.conectar());

            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conexao.conectar();


            reader = cmd.ExecuteReader();
            if (reader.Read())
            {


                Classes.Global.nome = reader[1].ToString();

            }
            reader.Close();
            notificação.Visible = false;
            Administrativo Administrativo = new Administrativo();//vai para a tela administrativa
            Administrativo.Show();
            this.Visible = false;
        }
       
    }
}
