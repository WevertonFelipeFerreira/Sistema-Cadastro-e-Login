using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario.Interface
{
    public interface IUsuarioLogin
    {
         string Login { get; set; }
         string Senha { get; set; }
    }
}
