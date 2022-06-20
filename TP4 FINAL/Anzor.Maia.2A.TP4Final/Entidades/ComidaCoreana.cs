using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComidaCoreana : Comida
    {

        public ComidaCoreana(string nombre, string tipoComida, double precio) : base(nombre, tipoComida, precio)
        {

        }


        public ComidaCoreana()
        {

        }

        /// <summary>
        /// metodo muestra atrbuto de clase comida coreana
        /// </summary>
        /// <returns>retorna los datos en formato string</returns>
        public string Mostrar()
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
