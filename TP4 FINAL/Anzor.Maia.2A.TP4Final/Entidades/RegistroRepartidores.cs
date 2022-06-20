using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RegistroRepartidores
    {
        private List<Repartidores> listaRepartidores;


        public RegistroRepartidores()
        {
            this.listaRepartidores = new List<Repartidores>();
        }

        public List<Repartidores> ListaRepartidores
        {
            get { return this.listaRepartidores; }
            set { this.listaRepartidores = value; }
        }

     

        /// <summary>
        /// muestra la informacion de cada cliente
        /// </summary>
        /// <returns>retorna informaicon de tipo stirng</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Repartidores unRepartidores in this.ListaRepartidores)
            {
                sb.AppendLine(unRepartidores.Mostrar());
            }
            return sb.ToString();
        }


        public override string ToString()
        {
            return Mostrar();
        }
    }
}
