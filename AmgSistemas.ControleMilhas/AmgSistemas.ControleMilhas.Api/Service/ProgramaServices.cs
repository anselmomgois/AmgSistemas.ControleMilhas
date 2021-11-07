using AmgSistemas.ControleMilhas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Service
{
    public class ProgramaServices : Interfaces.IProgramaService
    {
        private readonly Interfaces.IProgramaRepository _programaRepository;

        public ProgramaServices(Interfaces.IProgramaRepository programaRepository)
        {
            _programaRepository = programaRepository;
        }

        public void Atualizar(Programa programa)
        {
            _programaRepository.Atualizar(programa);
        }

        public Programa Buscar(string identificador)
        {
            return _programaRepository.Buscar(identificador);
        }

        public void Cadastrar(Programa programa)
        {
            _programaRepository.Cadastrar(programa);
        }

        public List<Programa> Recuperar(string identificadorUsuario)
        {
            return _programaRepository.Recuperar(identificadorUsuario);
        }
    }
}
