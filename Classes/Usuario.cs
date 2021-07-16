using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeUsuario.Interface;

namespace CadastroDeUsuario.Classes
{
    public class Usuario : IUsuario
    {
        public Usuario(string login, string senha, string nome, int idade,
            string cpf, int cep, string endereco, string cidade, string estado) 
        {
            Login = login;
            Senha = senha;
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Cep = cep;
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
        }
        public string Nome {get; set;}
        public int Idade {get; set;}
        public string Cpf {get; set;}
        public string Login {get; set;}
        public string Senha {get; set;}
        public int Cep {get; set;}
        public string Endereco {get; set;}
        public string Cidade {get; set;}
        public string Estado {get; set;}
    }
}
