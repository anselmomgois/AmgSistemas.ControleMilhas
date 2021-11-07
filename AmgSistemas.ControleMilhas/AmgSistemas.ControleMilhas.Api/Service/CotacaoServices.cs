using AmgSistemas.ControleMilhas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Service
{
    public class CotacaoServices : Interfaces.ICotacaoServices
    {

        private readonly Interfaces.ICotacaoRepository _cotacaoRepository;

        public CotacaoServices(Interfaces.ICotacaoRepository cotacaoRepository)
        {
            _cotacaoRepository = cotacaoRepository;
        }

        public void Atualizar(Cotacao cotacao)
        {
            _cotacaoRepository.Atualizar(cotacao);
        }

        public Cotacao Buscar(string identificador)
        {
            return _cotacaoRepository.Buscar(identificador);
        }

        public void Cadastrar(Cotacao cotacao)
        {
            _cotacaoRepository.Cadastrar(cotacao);
        }

        public void Deletar(string identificador)
        {
            _cotacaoRepository.Deletar(identificador);
        }
    }
}
