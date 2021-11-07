using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AmgSistemas.ControleMilhas.Api.BD.Models
{
    public class AGCM_TMEMBROS
    {

        public string ID_MEMBRO { get; set; }
        [ForeignKey("AGCM_TUSUARIO")]
        [Required()]
        public string ID_USUARIO { get; set; }
        public string DES_NOME { get; set; }

        public AGCM_TUSUARIO AGCM_TUSUARIO { get; set; }

        public ICollection<AGCM_TMOVIMENTOS> AGCM_TMOVIMENTOS { get; set; }
        public ICollection<AGCM_TSALDO> AGCM_TSALDO { get; set; }

    }
}
