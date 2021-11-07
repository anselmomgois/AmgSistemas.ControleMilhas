using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Interfaces
{
   public interface IMembroRepository
    {
        void Cadastrar(Models.Membro membro);

        void Atualizar(Models.Membro membro);

        Models.Membro Buscar(string identificador);
    }
}
