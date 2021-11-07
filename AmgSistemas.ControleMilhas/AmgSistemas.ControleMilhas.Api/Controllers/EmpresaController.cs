using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmpresaController : Controller
    {

        private readonly Interfaces.IEmpresaService _empresaService;

        public EmpresaController(Interfaces.IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }


        [HttpPost()]
        public Models.RetornoGenerico Post(Models.Empresa empresa)
        {
            try
            {

                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();

                if (string.IsNullOrEmpty(empresa.identificador))
                {
                    _empresaService.Cadastrar(empresa);
                }
                else
                {
                    _empresaService.Atualizar(empresa);
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

                objRetorno.retorno = _empresaService.Buscar(id);
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
