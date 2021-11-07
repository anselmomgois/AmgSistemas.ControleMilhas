using AmgSistemas.ControleMilhas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Repository
{
    public class ProgramaRepository : Interfaces.IProgramaRepository
    {

        private readonly BD.BancoContext _contexto;

        public ProgramaRepository(BD.BancoContext contexto)
        {
            _contexto = contexto;
        }

        public void Atualizar(Programa programa)
        {
            var programaBd = (from BD.Models.AGCM_TPROGRAMA u in _contexto.AGCM_TPROGRAMA
                             where u.ID_PROGRAMA == programa.identificador
                             select u).FirstOrDefault();

            if (programaBd != null)
            {
                programaBd.DES_PROGRAMA = programa.descricao;
                _contexto.SaveChanges();
            }
        }

        public Programa Buscar(string identificador)
        {
            return (from BD.Models.AGCM_TPROGRAMA u in _contexto.AGCM_TPROGRAMA
                    where u.ID_PROGRAMA == identificador
                    select new Models.Programa
                    {
                        identificador = u.ID_PROGRAMA,
                        descricao = u.DES_PROGRAMA
                    }).FirstOrDefault();
        }

        public void Cadastrar(Programa programa)
        {
            _contexto.AGCM_TPROGRAMA.Add(new BD.Models.AGCM_TPROGRAMA
            {
                DES_PROGRAMA = programa.descricao,
                ID_PROGRAMA = Guid.NewGuid().ToString(),
                ID_USUARIO = programa.usuario.identificador
            });

            _contexto.SaveChanges();
        }

        public List<Programa> Recuperar(string identificadorUsuario)
        {
            return (from BD.Models.AGCM_TPROGRAMA u in _contexto.AGCM_TPROGRAMA
                    where u.ID_USUARIO == identificadorUsuario
                    select new Models.Programa
                    {
                        identificador = u.ID_PROGRAMA,
                        descricao = u.DES_PROGRAMA
                    }).ToList();
        }
    }
}
