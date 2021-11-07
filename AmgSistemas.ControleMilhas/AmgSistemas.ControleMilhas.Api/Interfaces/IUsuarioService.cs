using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Interfaces
{
   public interface IUsuarioService
    {
        void Cadastrar(Models.Usuario usuario);

        void Atualizar(Models.Usuario usuario);

        Models.Usuario Buscar(string identificador);

        Models.Usuario Logar(Models.Login login);
    }
}
