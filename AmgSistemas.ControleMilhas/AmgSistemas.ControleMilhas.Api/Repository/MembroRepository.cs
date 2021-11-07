using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.ControleMilhas.Api.Models;

namespace AmgSistemas.ControleMilhas.Api.Repository
{
    public class MembroRepository : Interfaces.IMembroRepository
    {
        private readonly BD.BancoContext _contexto;

        public MembroRepository(BD.BancoContext contexto)
        {
            _contexto = contexto;
        }

        public void Atualizar(Membro membro)
        {
            var membroBd = (from BD.Models.AGCM_TMEMBROS u in _contexto.AGCM_TMEMBROS
                             where u.ID_MEMBRO == membro.identificador
                             select u).FirstOrDefault();

            if (membroBd != null)
            {
                membroBd.DES_NOME = membro.nome;
                _contexto.SaveChanges();
            }
        }

        public Membro Buscar(string identificador)
        {
            return (from BD.Models.AGCM_TMEMBROS u in _contexto.AGCM_TMEMBROS
                    where u.ID_MEMBRO == identificador
                    select new Models.Membro
                    {
                        identificador = u.ID_MEMBRO,
                        nome = u.DES_NOME,
                        usuario = new Usuario
                        {
                            identificador = u.ID_USUARIO
                        }
                    }).FirstOrDefault();
        }

        public void Cadastrar(Membro membro)
        {
            _contexto.AGCM_TMEMBROS.Add(new BD.Models.AGCM_TMEMBROS
            {
                DES_NOME = membro.nome,
                ID_MEMBRO = Guid.NewGuid().ToString(),
                ID_USUARIO = membro.usuario.identificador
            });

            _contexto.SaveChanges();
        }
    }
}
