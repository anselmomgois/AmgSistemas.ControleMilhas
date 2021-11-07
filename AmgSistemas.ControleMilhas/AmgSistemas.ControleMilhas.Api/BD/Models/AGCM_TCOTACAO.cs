using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmgSistemas.ControleMilhas.Api.BD.Models
{
    public class AGCM_TCOTACAO
    {
        public string ID_COTACAO { get; set; }
        [ForeignKey("AGCM_EMPRESA")]
        [Required()]
        public string ID_EMPRESA { get; set; }
        [ForeignKey("AGCM_TPROGRAMA")]
        [Required()]
        public string ID_PROGRAMA { get; set; }
        [ForeignKey("AGCM_TUSUARIO")]
        [Required()]
        public string ID_USUARIO { get; set; }
        [Required()]
        public DateTime DTH_COTACAO { get; set; }
        [Required()]
        public decimal NUM_VALOR { get; set; }

        public AGCM_TEMPRESA AGCM_EMPRESA { get; set; }
        public AGCM_TPROGRAMA AGCM_TPROGRAMA { get; set; }
        public AGCM_TUSUARIO AGCM_TUSUARIO { get; set; }
    }
}
