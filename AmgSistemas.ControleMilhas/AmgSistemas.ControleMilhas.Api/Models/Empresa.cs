using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Models
{
    public class Empresa
    {
        public string identificador { get; set; }
        public string descricao { get; set; }
        public Usuario usuario { get; set; }
    }
}
