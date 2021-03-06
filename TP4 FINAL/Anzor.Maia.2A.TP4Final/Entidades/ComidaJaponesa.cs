using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComidaJaponesa : Comida
    {
        public ComidaJaponesa(string nombre, string tipoComida, double precio) : base(nombre, tipoComida, precio)
        {

        }

        public ComidaJaponesa()
        {

        }

        /// <summary>
        /// muestra la informacion e la clase comida japonesa
        /// </summary>
        /// <returns>la retorna en formato string</returns>
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());


            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
