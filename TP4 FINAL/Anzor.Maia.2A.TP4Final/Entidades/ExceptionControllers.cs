using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExceptionControllers : Exception
    {
        public ExceptionControllers(string mensaje) : this(mensaje, null)
        {

        }

        public ExceptionControllers(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
           
        }
    }
}
