using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLogin.DAL; 

namespace ProjetoLogin.Modelo
{
    public class Controle
    {
        public bool tem; // Variável para verificar se a ação foi realizada com sucesso
        public string mensagem = ""; // Variável para armazenar mensagens de erro ou sucesso

        public bool acessar(String login, String senha) 
        {
            LoginDaoComandos loginDao = new LoginDaoComandos(); 
            tem = loginDao.verificarLogin(login, senha); // Chamada do método verificarLogin da classe LoginDaoComandos
            if (!loginDao.mensagem.Equals("")) // Se a mensagem de erro for diferente de vazio
            {
                this.mensagem = loginDao.mensagem; // Atribui a mensagem de erro à variável mensagem
            }
            return tem; // Retorna a variável tem (true ou false)
        }

        public string cadastrar(string email, string senha, string confSenha) // Método para cadastrar um novo usuário
        {
            LoginDaoComandos loginDao = new LoginDaoComandos(); // Instanciação da classe LoginDaoComandos
            this.mensagem = loginDao.cadastrar(email, senha, confSenha); // Chamada do método cadastrar da classe LoginDaoComandos
            if (loginDao.tem) // Se a ação foi realizada com sucesso
            {
                this.tem = true; // Atribui true à variável tem
            }
            return mensagem; // Retorna a mensagem de erro ou sucesso
        }
    }
}