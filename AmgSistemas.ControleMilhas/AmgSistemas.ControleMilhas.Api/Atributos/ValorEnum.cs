using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.ControleMilhas.Api.Atributos
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class ValorEnum : Attribute
    {

        public string Valor { get; set; }

        public ValorEnum(string valor)
        {
            this.Valor = valor;
        }

    }
}
