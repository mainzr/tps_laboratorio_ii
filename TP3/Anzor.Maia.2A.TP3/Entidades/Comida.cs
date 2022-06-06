using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Comida
    {

        protected string nombre;
        protected double precioTotal;
        protected string tipoComida;

        public Comida()
        {

        }
        public Comida(string nombre, string tipoComida, double precioTotal)
        {
            this.nombre = nombre;
            this.precioTotal = precioTotal;
            this.tipoComida = tipoComida;
        }

        #region Constructores
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public double Precio
        {
            get { return this.precioTotal; }
            set { this.precioTotal = value; }
        }

        public string TipoComida
        {
            get { return this.tipoComida; }
            set { this.tipoComida = value; }
        }


        #endregion
        /// <summary>
        /// muestra los datos que hay en comida
        /// </summary>
        /// <returns>etorna la informaicon en dato de tipo string</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"TIPO Y NOMBRE DE COMIDA/S: {this.Nombre}");
            sb.AppendLine($"PRECIO TOTAL: ${this.Precio}");

            return sb.ToString();
        }


    }
}
