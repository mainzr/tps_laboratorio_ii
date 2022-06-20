using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Repartidores
    {
        private int idRepartidor;
        private string nombre;
        private string apellido;
        private string sexo;
        private string numeroContacto;
        private string estadoEmplado;


        public Repartidores(string nombre, string apellido, string sexo, string numeroContacto, string estadoEmplado)
        {          
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.numeroContacto = numeroContacto;
            this.estadoEmplado = estadoEmplado;
        } 

        public Repartidores(int idRepartidor, string nombre, string apellido, string sexo, string numeroContacto, string estadoEmplado) 
            :  this(nombre,  apellido,  sexo, numeroContacto,  estadoEmplado) 
        {
            this.idRepartidor = idRepartidor;
        }

        public int IdRepartidor 
        {
            get { return this.idRepartidor; } 
            set { this.idRepartidor = value; } 
        }
        public string Nombre 
        { 
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido 
        { 
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            } 
        }
        public string Sexo 
        {
            get
            {
                return this.sexo;
            }
            set
            {
                this.sexo = value;
            } 
        }
        public string NumeroContacto 
        { 
            get
            {
                return this.numeroContacto;
            }
            set
            {
                this.numeroContacto = value;
            } 
        }
        public string EstadoEmplado
        {
            get { return this.estadoEmplado; }
            set { this.estadoEmplado = value; }
        }


        /// <summary>
        /// muestra todos los respartidores exixtentes
        /// </summary>
        /// <returns>los datos de los repartidores en formato string</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"***ID EMPLEADO: #{this.IdRepartidor}***");
            sb.AppendLine($"NOMBRE: {this.Nombre}");
            sb.AppendLine($"APELLIDO: {this.Apellido}");
            sb.AppendLine($"SEXO: {this.Sexo}");
            sb.AppendLine($"NUMERO DE CONTACTO: {this.NumeroContacto}");
            sb.AppendLine($"ESTADO DEL EMPLEADO: {this.EstadoEmplado}");

            sb.AppendLine($"-----------------------------------------");

            return sb.ToString();
        }
    }
}
