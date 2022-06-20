using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComidaChina : Comida
    {

        public ComidaChina(string nombre, string tipoComida, double precio) : base(nombre, tipoComida, precio)
        {

        }

        public ComidaChina()
        {

        }

        /// <summary>
        /// muestra los datos de comida china
        /// </summary>
        /// <returns>retorna la informacion de modo string</returns>
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());


            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Mostrar();
        }
    }
}
