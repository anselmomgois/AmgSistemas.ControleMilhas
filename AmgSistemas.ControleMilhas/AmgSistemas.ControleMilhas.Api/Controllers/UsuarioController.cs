using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {

        private readonly Interfaces.IUsuarioService _usuarioSevices;

        public UsuarioController(Interfaces.IUsuarioService usuarioServices)
        {
            _usuarioSevices = usuarioServices;
        }

        [HttpPost()]
        public Models.RetornoGenerico Post(Models.Usuario usuario)
        {
            try
            {

                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();

                if (string.IsNullOrEmpty(usuario.identificador))
                {
                    _usuarioSevices.Cadastrar(usuario);
                }
                else
                {
                    _usuarioSevices.Atualizar(usuario);
                }

                objRetorno.codigo = 0;

                return objRetorno;
            }
            catch (Exception ex)
            {
                return new Models.RetornoGenerico() { codigo = 1, descricao = ex.ToString() };
            }
        }

        [Route("logar")]
        [HttpPost()]
        public Models.RetornoGenerico Post(Models.Login login)
        {
            try
            {

                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();


                objRetorno.retorno = _usuarioSevices.Logar(login);

                objRetorno.codigo = 0;

                return objRetorno;
            }
            catch (Exception ex)
            {
                return new Models.RetornoGenerico() { codigo = 1, descricao = ex.ToString() };
            }
        }

        [HttpGet("{id}")]
        public Models.RetornoGenerico Get(string id)
        {
            try
            {
                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();

                objRetorno.retorno = _usuarioSevices.Buscar(id);
                objRetorno.codigo = 0;

                return objRetorno;
            }
            catch (Exception ex)
            {
                return new Models.RetornoGenerico() { codigo = 1, descricao = ex.ToString() };
            }
        }
    }
}
