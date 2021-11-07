using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Models
{
    public class Cotacao
    {

        public string identificador { get; set; }
        public DateTime data { get; set; }
        public decimal valor { get; set; }
        public Empresa empresa { get; set; }
        public Programa programa { get; set; }
        public Usuario usuario { get; set; }
    }
}
