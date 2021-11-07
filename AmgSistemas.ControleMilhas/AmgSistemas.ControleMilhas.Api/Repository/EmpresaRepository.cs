using AmgSistemas.ControleMilhas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Repository
{
    public class EmpresaRepository : Interfaces.IEmpresaRepository
    {

        private readonly BD.BancoContext _contexto;

        public EmpresaRepository(BD.BancoContext contexto)
        {
            _contexto = contexto;
        }

        public void Atualizar(Empresa empresa)
        {
            var empresaBd = (from BD.Models.AGCM_TEMPRESA u in _contexto.AGCM_TEMPRESA
                             where u.ID_EMPRESA == empresa.identificador
                             select u).FirstOrDefault();

            if (empresaBd != null)
            {
                empresaBd.DES_EMPRESA = empresa.descricao;
                _contexto.SaveChanges();
            }
        }

        public Empresa Buscar(string identificador)
        {
            return (from BD.Models.AGCM_TEMPRESA u in _contexto.AGCM_TEMPRESA
                    where u.ID_EMPRESA == identificador
                    select new Models.Empresa
                    {
                        identificador = u.ID_EMPRESA,
                        descricao = u.DES_EMPRESA
                    }).FirstOrDefault();
        }

        public void Cadastrar(Empresa empresa)
        {
            _contexto.AGCM_TEMPRESA.Add(new BD.Models.AGCM_TEMPRESA
            {
                DES_EMPRESA = empresa.descricao,
                ID_EMPRESA = Guid.NewGuid().ToString(),
                ID_USUARIO = empresa.usuario.identificador
            });

            _contexto.SaveChanges();
        }
    }
}
