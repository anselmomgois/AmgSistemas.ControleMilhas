using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmgSistemas.ControleMilhas.Api.BD.Models
{
    public class AGCM_TPROGRAMA
    {
        public string ID_PROGRAMA { get; set; }
        [Required()]
        public string DES_PROGRAMA { get; set; }
        [ForeignKey("AGCM_TUSUARIO")]
        [Required()]
        public string ID_USUARIO { get; set; }

        public AGCM_TUSUARIO AGCM_TUSUARIO { get; set; }
        public ICollection<AGCM_TCOTACAO> AGCM_TCOTACAO { get; set; }
        public ICollection<AGCM_TMOVIMENTOS> AGCM_TMOVIMENTOS { get; set; }
        public ICollection<AGCM_TSALDO> AGCM_TSALDO { get; set; }
    }
}
