using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Interfaces
{
   public interface IProgramaService
    {
        void Cadastrar(Models.Programa programa);

        void Atualizar(Models.Programa programa);

        Models.Programa Buscar(string identificador);

        List<Models.Programa> Recuperar(string identificadorUsuario);
    }
}
