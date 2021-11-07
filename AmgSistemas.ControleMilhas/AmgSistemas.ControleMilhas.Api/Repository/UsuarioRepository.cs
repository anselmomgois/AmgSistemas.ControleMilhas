using AmgSistemas.ControleMilhas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Repository
{

    public class UsuarioRepository : Interfaces.IUsuarioRepository
    {

        private readonly BD.BancoContext _contexto;

        public UsuarioRepository(BD.BancoContext contexto)
        {
            _contexto = contexto;
        }

        public void Atualizar(Usuario usuario)
        {
           var usuarioBd =  (from BD.Models.AGCM_TUSUARIO u in _contexto.AGCM_TUSUARIO
             where u.ID_USUARIO == usuario.identificador
             select u).FirstOrDefault();

            if(usuarioBd != null)
            {
                usuarioBd.DES_NOME = usuario.nome;
                usuarioBd.DES_LOGIN = usuario.login;
                _contexto.SaveChanges();
            }
        }

        public Usuario Buscar(string identificador)
        {
            return (from BD.Models.AGCM_TUSUARIO u in _contexto.AGCM_TUSUARIO
                    where u.ID_USUARIO == identificador
                    select new Models.Usuario
                    {
                        identificador = u.ID_USUARIO,
                        login = u.DES_LOGIN,
                        nome = u.DES_NOME
                    }).FirstOrDefault();
        }

        public void Cadastrar(Usuario usuario)
        {
            _contexto.AGCM_TUSUARIO.Add(new BD.Models.AGCM_TUSUARIO
            {
                DES_LOGIN = usuario.login,
                DES_NOME = usuario.nome,
                DES_SENHA = usuario.senha,
                DTH_REGISTRO = DateTime.Now,
                ID_USUARIO = Guid.NewGuid().ToString()
            });

            _contexto.SaveChanges();
        }

        public Usuario Logar(Login login)
        {
            return (from BD.Models.AGCM_TUSUARIO u in _contexto.AGCM_TUSUARIO
                    where u.DES_LOGIN.ToUpper() == login.usuario.ToUpper() && u.DES_SENHA == login.senha
                    select new Models.Usuario
                    {
                        identificador = u.ID_USUARIO,
                        login = u.DES_LOGIN,
                        nome = u.DES_NOME
                    }).FirstOrDefault();
        }
    }
}
