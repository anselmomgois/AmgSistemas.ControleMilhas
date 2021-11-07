using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MembroController : Controller
    {
        private readonly Interfaces.IMembroService _membroService;

        public MembroController(Interfaces.IMembroService membroService)
        {
            _membroService = membroService;
        }

        [HttpPost()]
        public Models.RetornoGenerico Post(Models.Membro membro)
        {
            try
            {

                Models.RetornoGenerico objRetorno = new Models.RetornoGenerico();

                if (string.IsNullOrEmpty(membro.identificador))
                {
                    _membroService.Cadastrar(membro);
                }
                else
                {
                    _membroService.Atualizar(membro);
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

                objRetorno.retorno = _membroService.Buscar(id);
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
