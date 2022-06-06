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



        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"TIPO Y NOMBRE DE COMIDA/S: {this.Nombre}");
            sb.AppendLine($"PRECIO TOTAL: ${this.Precio}");

            return sb.ToString();
        }


    }
}
