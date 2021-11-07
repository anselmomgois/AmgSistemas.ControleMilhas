using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Interfaces
{
   public interface IEmpresaRepository
    {
        void Cadastrar(Models.Empresa empresa);

        void Atualizar(Models.Empresa empresa);

        Models.Empresa Buscar(string identificador);
    }
}
