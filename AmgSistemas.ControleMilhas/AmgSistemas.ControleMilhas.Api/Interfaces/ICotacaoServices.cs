using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Interfaces
{
   public interface ICotacaoServices
    {
        void Cadastrar(Models.Cotacao cotacao);

        void Atualizar(Models.Cotacao cotacao);

        Models.Cotacao Buscar(string identificador);
        void Deletar(string identificador);
    }
}
