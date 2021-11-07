using AmgSistemas.ControleMilhas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Service
{
    public class UsuarioServices : Interfaces.IUsuarioService
    {
        private readonly Interfaces.IUsuarioRepository _usuarioRepository;

        public UsuarioServices(Interfaces.IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public void Atualizar(Usuario usuario)
        {
            _usuarioRepository.Atualizar(usuario);
        }

        public Usuario Buscar(string identificador)
        {
            return _usuarioRepository.Buscar(identificador);
        }

        public void Cadastrar(Usuario usuario)
        {
            _usuarioRepository.Cadastrar(usuario);
        }

        public Usuario Logar(Login login)
        {
            return _usuarioRepository.Logar(login);
        }
    }
}
