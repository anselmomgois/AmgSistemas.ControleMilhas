using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmgSistemas.ControleMilhas.Api.BD.Models
{
    public class AGCM_TSALDO
    {

        public string ID_SALDO { get; set; }
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
        public decimal NUM_VALOR_COMPRA { get; set; }
        [Required()]
        public decimal NUM_MILHAS { get; set; }
        [Required()]
        public decimal NUM_MILHAS_VENDIDAS { get; set; }
        [Required()]
        public DateTime DTH_REGISTRO { get; set; }
        [Required()]
        public DateTime DTH_MODIFICACAO { get; set; }

        public AGCM_TPROGRAMA AGCM_TPROGRAMA { get; set; }
        public AGCM_TUSUARIO AGCM_TUSUARIO { get; set; }
        public AGCM_TMEMBROS AGCM_TMEMBROS { get; set; }

        public ICollection<AGCM_TSALDO_VENDA> AGCM_TSALDO_VENDA { get; set; }
    }
}
