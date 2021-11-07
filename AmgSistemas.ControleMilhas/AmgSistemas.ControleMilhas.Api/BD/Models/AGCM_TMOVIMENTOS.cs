using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmgSistemas.ControleMilhas.Api.BD.Models
{
    public class AGCM_TMOVIMENTOS
    {

        public string ID_MOVIMENTOS { get; set; }
        [Required()]
        [ForeignKey("AGCM_TUSUARIO")]
        public string ID_USUARIO { get; set; }
        [Required()]
        [ForeignKey("AGCM_TPROGRAMA")]
        public string ID_PROGRAMA { get; set; }
        [Required()]
        [ForeignKey("AGCM_TMEMBROS")]
        public string ID_MEMBRO { get; set; }
        [Required()]
        public DateTime DTH_MOVIMENTO { get; set; }
        [Required()]
        public string DES_MOVIMENTO { get; set; }
        public decimal NUM_VALOR_TOTAL_GASTO { get; set; }
        [Required()]
        public Int32 QTD_PARCELAS { get; set; }
        [Required()]
        public string  COD_TIPO { get; set; }

        public AGCM_TUSUARIO AGCM_TUSUARIO { get; set; }
        public AGCM_TMEMBROS AGCM_TMEMBROS { get; set; }
        public AGCM_TPROGRAMA AGCM_TPROGRAMA { get; set; }

        public ICollection<AGCM_TMOV_PARCELA> AGCM_TMOV_PARCELA { get; set; }
    }
}
