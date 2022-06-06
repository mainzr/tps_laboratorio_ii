using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IBackUp<T>
    {
        string Ruta { get; set; }

        bool HacerBackUp(string contenido, string ruta);
        T LeerArchivo(string ruta);
    }
}
