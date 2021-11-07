using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmgSistemas.ControleMilhas.Api.BD.Models
{
    public class AGCM_TEMPRESA
    {

        public string ID_EMPRESA { get; set; }
        [Required()]
        public string DES_EMPRESA { get; set; }
        [ForeignKey("AGCM_TUSUARIO")]
        [Required()]
        public string ID_USUARIO { get; set; }

        public AGCM_TUSUARIO AGCM_TUSUARIO { get; set; }
        public ICollection<AGCM_TCOTACAO> AGCM_TCOTACAO { get; set; }
        public ICollection<AGCM_TSALDO_VENDA> AGCM_TSALDO_VENDA { get; set; }

    }
}
