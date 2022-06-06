using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionCamposVacios : Exception
    {
        public ExcepcionCamposVacios(string mensaje) : this(mensaje, null)
        {

        }

        public ExcepcionCamposVacios(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
