using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ServicioEnvio
    {
        private string tipoEnvio;
       

        public ServicioEnvio(string tipoEnvio)
        {
            this.tipoEnvio = tipoEnvio;
        }

        public string PlanEnvio
        {
            get { return this.tipoEnvio; }
            set { this.tipoEnvio = value; }
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"PLAN SELECCIONADO: {this.PlanEnvio}");

            return sb.ToString();
        }


        /*public override string ToString()
        {
            return Mostrar();
        }*/

    }
}
