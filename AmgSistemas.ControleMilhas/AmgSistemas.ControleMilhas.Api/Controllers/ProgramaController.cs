using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProgramaController : Controller
    {
        private readonly Interfaces.IProgramaService _programaService;

        public ProgramaController(Interfaces.IProgramaService programaService)
        {
            _programaService = programaService;
        }


        [HttpPost()]
        public Models.RetornoGenerico Post(Models.Programa programa)
        {
            try
            {

                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();

                if (string.IsNullOrEmpty(programa.identificador))
                {
                    _programaService.Cadastrar(programa);
                }
                else
                {
                    _programaService.Atualizar(programa);
                }

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

                objRetorno.retorno = _programaService.Buscar(id);
                objRetorno.codigo = 0;

                return objRetorno;
            }
            catch (Exception ex)
            {
                return new Models.RetornoGenerico() { codigo = 1, descricao = ex.ToString() };
            }
        }

        [HttpGet("{id}")]
        [Route("Recuperar")]
        public Models.RetornoGenerico Recuperar(string id)
        {
            try
            {
                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();

                objRetorno.retorno = _programaService.Recuperar(id);
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
