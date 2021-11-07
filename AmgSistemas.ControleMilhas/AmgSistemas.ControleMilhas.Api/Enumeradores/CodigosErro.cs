using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmgSistemas.ControleMilhas.Api.Atributos;

namespace AmgSistemas.ControleMilhas.Api.Enumeradores
{
    public enum CodigosErro
    {
        [ValorEnum("1")]
        ErroDefault,
        [ValorEnum("2")]
        ErroNegocio,
        [ValorEnum("0")]
        SemErro,
        [ValorEnum("3")]
        SolicitarSenha
    }
}
