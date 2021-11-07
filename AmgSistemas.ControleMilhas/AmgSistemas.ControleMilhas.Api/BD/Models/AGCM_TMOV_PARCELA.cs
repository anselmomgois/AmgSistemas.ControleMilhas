using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmgSistemas.ControleMilhas.Api.BD.Models
{
    public class AGCM_TMOV_PARCELA
    {

        public string ID_MOV_PARCELA { get; set; }
        [Required()]
        [ForeignKey("AGCM_TMOVIMENTOS")]
        public string ID_MOVIMENTOS { get; set; }
        [Required()]
        public decimal NUM_VALOR { get; set; }
        [Required()]
        public decimal NUM_MILHAS { get; set; }
        [Required()]
        public DateTime DTH_PAGAMENTO { get; set; }
        [Required()]
        public decimal NUM_VALOR_MILHEIRO { get; set; }
        [Required()]
        public bool BOL_MILHAS_RECEBIDAS { get; set; }

        public AGCM_TMOVIMENTOS AGCM_TMOVIMENTOS { get; set; }

    }
}
