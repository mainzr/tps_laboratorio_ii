using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionRetornoFalse : Exception
    {
        public ExcepcionRetornoFalse(string mensaje) : this(mensaje, null)
        {

        }

        public ExcepcionRetornoFalse(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
