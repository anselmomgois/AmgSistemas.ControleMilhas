using AmgSistemas.ControleMilhas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Service
{
    public class EmpresaServices : Interfaces.IEmpresaService
    {
        private readonly Interfaces.IEmpresaRepository _empresaRepository;

        public EmpresaServices(Interfaces.IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public void Atualizar(Empresa empresa)
        {
            _empresaRepository.Atualizar(empresa);
        }

        public Empresa Buscar(string identificador)
        {
            return _empresaRepository.Buscar(identificador);
        }

        public void Cadastrar(Empresa empresa)
        {
            _empresaRepository.Cadastrar(empresa);
        }
    }
}
