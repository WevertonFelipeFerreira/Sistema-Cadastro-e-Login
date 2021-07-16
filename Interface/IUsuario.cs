using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario.Interface
{
    public interface IUsuario : IUsuarioLogin, IEndereco
    {
       public string Nome { get; set; }
       public int Idade { get; set; }
       public string Cpf { get; set; }

    }
}
