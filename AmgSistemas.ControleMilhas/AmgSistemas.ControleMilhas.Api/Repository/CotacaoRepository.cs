using AmgSistemas.ControleMilhas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Repository
{
    public class CotacaoRepository : Interfaces.ICotacaoRepository
    {

        private readonly BD.BancoContext _contexto;

        public CotacaoRepository(BD.BancoContext contexto)
        {
            _contexto = contexto;
        }

        public void Atualizar(Cotacao cotacao)
        {
            var cotacaoBd = (from BD.Models.AGCM_TCOTACAO u in _contexto.AGCM_TCOTACAO
                             where u.ID_COTACAO == cotacao.identificador
                             select u).FirstOrDefault();

            if (cotacaoBd != null)
            {
                cotacaoBd.DTH_COTACAO = cotacao.data;
                cotacaoBd.NUM_VALOR = cotacao.valor;
                cotacaoBd.ID_EMPRESA = cotacao.empresa.identificador;
                cotacaoBd.ID_PROGRAMA = cotacao.programa.identificador;
                
                _contexto.SaveChanges();
            }
        }

        public Cotacao Buscar(string identificador)
        {
            return (from BD.Models.AGCM_TCOTACAO u in _contexto.AGCM_TCOTACAO
                    join BD.Models.AGCM_TEMPRESA e in _contexto.AGCM_TEMPRESA on u.ID_EMPRESA equals e.ID_EMPRESA
                    join BD.Models.AGCM_TPROGRAMA p in _contexto.AGCM_TPROGRAMA on u.ID_PROGRAMA equals p.ID_PROGRAMA
                    where u.ID_COTACAO == identificador
                    select new Models.Cotacao
                    {
                        identificador = u.ID_COTACAO,
                        data = u.DTH_COTACAO,
                        valor = u.NUM_VALOR,
                        empresa = new Empresa
                        {
                            identificador = u.ID_EMPRESA,
                            descricao = e.DES_EMPRESA
                        },
                        programa = new Programa
                        {
                            identificador = u.ID_PROGRAMA,
                            descricao = p.DES_PROGRAMA
                        }
                    }).FirstOrDefault();
        }

        public void Cadastrar(Cotacao cotacao)
        {
            _contexto.AGCM_TCOTACAO.Add(new BD.Models.AGCM_TCOTACAO
            {
                DTH_COTACAO = cotacao.data,
                NUM_VALOR = cotacao.valor,
                ID_PROGRAMA = cotacao.programa.identificador,
                ID_COTACAO = Guid.NewGuid().ToString(),
                ID_EMPRESA = cotacao.empresa.identificador,
                ID_USUARIO = cotacao.usuario.identificador
            });

            _contexto.SaveChanges();
        }

        public void Deletar(string identificador)
        {
            _contexto.AGCM_TCOTACAO.Remove((from BD.Models.AGCM_TCOTACAO c in _contexto.AGCM_TCOTACAO
                                            where c.ID_COTACAO == identificador
                                            select c).FirstOrDefault());
        }
    }
}
