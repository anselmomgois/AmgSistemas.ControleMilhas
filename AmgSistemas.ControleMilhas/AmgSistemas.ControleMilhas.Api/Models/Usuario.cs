using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Models
{
    public class Usuario
    {
        public string identificador { get; set; }
        public string login { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
    }
}
