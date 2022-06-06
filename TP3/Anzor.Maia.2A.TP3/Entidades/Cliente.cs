using System;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(ComidaChina))]
    [XmlInclude(typeof(ComidaCoreana))]
    [XmlInclude(typeof(ComidaJaponesa))]
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private string numeroTelefono;
        private string email;
        private string numeroCliente;
        private Comida unaComida;
        //private ServicioEnvio envio;

        public Cliente()
        {

        }
        public Cliente(string nombre, string apellido, string direccion, string numeroTelefono, string email, string nroCliente, Comida comida)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.numeroTelefono = numeroTelefono;
            this.email = email;
            this.numeroCliente = nroCliente;
            this.unaComida = comida;
           
        }
        public string NumeroCliente
        {
            get { return this.numeroCliente; }
            set { this.numeroCliente = value; }
        }
     
        public Comida UnaComida
        {
            get { return this.unaComida; }
            set { this.unaComida = value; }
        }

        public string Nombre 
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }


        public string NumeroTelefono
        {
            get { return this.numeroTelefono; }
            set { this.numeroTelefono = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string NroCliente
        {
            get { return this.numeroCliente; }
            set { this.numeroCliente = value; }
        }

        //methods
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"***CLIENTE NUMERO: #{this.NumeroCliente}***");
            sb.AppendLine($"NOMBRE: {this.Nombre}");
            sb.AppendLine($"APELLIDO: {this.Apellido}");
            sb.AppendLine($"DIRECCION: {this.Direccion}");
            sb.AppendLine($"NUMERO DE TELEFONO: {this.NumeroTelefono}");
            sb.AppendLine($"EMAIL: {this.Email}");
            sb.AppendLine(this.unaComida.Mostrar());

            sb.AppendLine($"-----------------------------------------");

            return sb.ToString();
        }


       

        public static bool operator ==(Cliente clienteUno, Cliente clienteDos)
        {
            bool retorno = false;
            if( clienteUno.numeroCliente == clienteDos.numeroCliente)
            {
                retorno = true;
                
            }
            return retorno;
        }

        public static bool operator !=(Cliente clienteUno, Cliente clienteDos)
        {
            return !(clienteUno == clienteDos);
        }




    }
}
