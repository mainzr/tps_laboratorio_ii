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

        /// <summary>
        /// metodo encargado de escribir archivo txt
        /// </summary>
        /// <param name="contenido"></param>
        /// <param name="ruta"></param>
        /// <returns>retorna true si se creo, false caso contrario</returns>
        bool HacerBackUp(string contenido, string ruta);
        /// <summary>
        /// encargado de leer archivo de tipo txt
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>retorna el archivo leido</returns>
        T LeerArchivo(string ruta);
    }
}
