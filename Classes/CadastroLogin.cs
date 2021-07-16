using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeUsuario.Classes;

namespace CadastroDeUsuario.Classes
{
    public class CadastroLogin
    {
        public static List<Usuario> Contas = new List<Usuario>();
        public static void RegistrarUsuario(string login, string senha, string nome, int idade, 
            string cpf, int cep, string endereco, string cidade, string estado) 
        {
           Usuario user = new Usuario(login, senha, nome, idade, cpf, cep, endereco, cidade, estado);
           Contas.Add(user);
        }

    }
}
