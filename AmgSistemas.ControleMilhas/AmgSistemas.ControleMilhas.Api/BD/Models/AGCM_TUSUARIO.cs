using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmgSistemas.ControleMilhas.Api.BD.Models
{
    public class AGCM_TUSUARIO
    {

        public string ID_USUARIO { get; set; }
        [Required()]
        public DateTime DTH_REGISTRO { get; set; }
        [Required()]
        public string DES_NOME { get; set; }
        [Required()]
        public string DES_LOGIN { get; set; }
        [Required()]
        public string DES_SENHA { get; set; }

        public ICollection<AGCM_TMOVIMENTOS> AGCM_TMOVIMENTOS { get; set; }
        public ICollection<AGCM_TSALDO> AGCM_TSALDO { get; set; }
        public ICollection<AGCM_TCOTACAO> AGCM_TCOTACAO { get; set; }
        public ICollection<AGCM_TEMPRESA> AGCM_TEMPRESA { get; set; }
        public ICollection<AGCM_TPROGRAMA> AGCM_TPROGRAMA { get; set; }
        public ICollection<AGCM_TMEMBROS> AGCM_TMEMBROS { get; set; }
    }
}
