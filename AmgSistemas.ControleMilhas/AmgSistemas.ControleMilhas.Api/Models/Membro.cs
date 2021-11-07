using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Models
{
    public class Membro
    {
        public string identificador { get; set; }
        public string nome { get; set; }
        public Usuario usuario { get; set; }
    }
}
