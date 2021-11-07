using AmgSistemas.ControleMilhas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Service
{
    public class MembroServices : Interfaces.IMembroService
    {

        private readonly Interfaces.IMembroRepository _membroRepository;

        public MembroServices(Interfaces.IMembroRepository membroRepository)
        {
            _membroRepository = membroRepository;
        }

        public void Atualizar(Membro membro)
        {
            _membroRepository.Atualizar(membro);
        }

        public Membro Buscar(string identificador)
        {
            return _membroRepository.Buscar(identificador);
        }

        public void Cadastrar(Membro membro)
        {
            _membroRepository.Cadastrar(membro);
        }
    }
}
