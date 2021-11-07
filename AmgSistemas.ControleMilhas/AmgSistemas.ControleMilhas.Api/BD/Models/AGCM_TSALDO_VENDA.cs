using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmgSistemas.ControleMilhas.Api.BD.Models
{
    public class AGCM_TSALDO_VENDA
    {

        public string ID_SALDO_VENDA { get; set; }
        [Required()]
        [ForeignKey("AGCM_TSALDO")]
        public string ID_SALDO { get; set; }
        [Required()]
        [ForeignKey("AGCM_TEMPRESA")]
        public string ID_EMPRESA { get; set; }
        [Required()]
        public decimal  NUM_MILHAS_VENDIDAS { get; set; }
        [Required()]
        public decimal  NUM_VALOR_MILHEIRO { get; set; }
        [Required()]
        public DateTime DTH_REGISTRO { get; set; }

        public AGCM_TSALDO AGCM_TSALDO { get; set; }
        public AGCM_TEMPRESA AGCM_TEMPRESA { get; set; }

    }
}
