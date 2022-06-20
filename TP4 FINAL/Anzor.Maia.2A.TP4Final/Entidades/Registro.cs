using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Registro : IBackUp<string>
    {
        private List<Cliente> listaClientes;
        private Cliente cliente;
        private string path = null;

        public Registro()
        {
            this.listaClientes = new List<Cliente>();
        }


        #region Constructores
        public List<Cliente> Lista
        {
            get { return this.listaClientes; }
            set { this.listaClientes = value; }
        }

        public string Ruta 
        {
            get { return this.path ; }
            set {this.path = value; }
        }

        #endregion
        /// <summary>
        /// agrega un cliente a la lista si no existe
        /// </summary>
        /// <param name="registro"></param>
        /// <param name="cliente"></param>
        /// <returns>true si lo agrego con exito false caso contrario</returns>
        public bool AgregarPedido(Registro registro, Cliente cliente)
        {
            bool retorno = false;
            foreach (Cliente unCliente in registro.listaClientes)
            {
                if(unCliente != cliente)
                {
                    registro.listaClientes.Add(unCliente);
                    retorno = true;
                }
            }
            return retorno;
        }
        
        /// <summary>
        /// muestra la informacion de cada cliente
        /// </summary>
        /// <returns>retorna informaicon de tipo stirng</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Cliente unCliente in this.listaClientes)
            {
                sb.AppendLine(unCliente.Mostrar());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        /// <summary>
        /// busca un cliente sea igual a otro a partir de numero de cliente
        /// </summary>
        /// <param name="nroCliente"></param>
        /// <returns>true si lo encontro, false caso contrario</returns>
        public bool BuscarCliente(string nroCliente)
        {
            bool retorno = false;

            foreach (Cliente unCliente in this.listaClientes)
            {
                if (unCliente.NroCliente == nroCliente)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

       
        /// <summary>
        /// escribe archivo de tipo txt
        /// </summary>
        /// <param name="contenido"></param>
        /// <param name="ruta"></param>
        /// <returns>retorna true si escribio</returns>
        public bool HacerBackUp(string contenido, string ruta)
        {
            bool retorno = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(ruta)) 
                {
                    sw.WriteLine(contenido);
                    retorno = true;
                }
            }
            catch (ExceptionControllers e)
            {

                throw new ExceptionControllers("Error al crear archivo", e);
            }

            return retorno;
        }
        /// <summary>
        /// lee archivo de tipo txt.
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public string LeerArchivo(string ruta)
        {
            string retorno = String.Empty;

            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    retorno = sr.ReadToEnd();
                }
            }
            catch (ExceptionControllers e)
            {

                throw new ExceptionControllers("Error al leer archivo", e);
            }
            return retorno;
        }

        
    }
}
