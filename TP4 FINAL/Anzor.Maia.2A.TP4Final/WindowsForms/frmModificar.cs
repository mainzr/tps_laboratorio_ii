using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsForms
{
    public partial class frmModificar : Form
    {
        Registro unRegistro;
        List<Cliente> nuevaList;
        Serializador serializar;

        public delegate void DelegadoAviso(string mensaje, string tipoMensaje);
        DelegadoAviso delegadoAviso = Avisar;

        public frmModificar(Registro registro)
        {
            InitializeComponent();
            this.unRegistro = registro;
            this.nuevaList = new List<Cliente>();
            this.serializar = new Serializador();
        }

        public List<Cliente> ListaNueva
        {
            get { return this.nuevaList; }
        }

        /// <summary>
        /// cargara los valores que tendra el mensaje segun cuando lo llamen a partir del delegado
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="tipoMensaje"></param>
        static void Avisar(string mensaje, string tipoMensaje)
        {
            MessageBox.Show($"{mensaje}", $"{tipoMensaje}", MessageBoxButtons.OK);
        }
        /// <summary>
        /// carga rich text con los datos de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmModificar_Load(object sender, EventArgs e)
        {
            frmListaClientes formLista = new frmListaClientes(unRegistro);

            foreach (Cliente item in this.unRegistro.Lista)
            {
                this.txtClientesExistentes.Text += item.Mostrar();
            }
        }

        /// <summary>
        /// modifica el cliente elegido, y serializa la nueva lista con los nuevos datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            frmAlta formAlta = new frmAlta(unRegistro);
            frmListaClientes formLista = new frmListaClientes(unRegistro);
            frmMenu f = new frmMenu();
            string ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + "BackupListaPedidos_XmlExtension.xml";
            bool retorno;
            bool encontrado;

            //string nroEncontrado = formAlta.BuscarCliente(frmElegido.NroClienteIngresado);

            if (String.IsNullOrEmpty(this.txtBoxNuevoNombre.Text) || String.IsNullOrEmpty(this.txtBoxNuevoApellido.Text) || String.IsNullOrEmpty(this.txtBoxNuevaDireccion.Text)
                || String.IsNullOrEmpty(this.lblNumeroTelefono.Text) || String.IsNullOrEmpty(this.txtBoxNuevoEmail.Text) || String.IsNullOrEmpty(this.txtBoxNroClienteBuscado.Text))
            {
                delegadoAviso("Debe completar todos los datos con la informacion del cliente", "Datos incompletos");
            }
            else
            {
                try
                {
                    encontrado = ModificarEmpleado();
                }
                catch (ExcepcionRetornoFalse ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
                retorno = this.serializar.SerializarXml(ruta, this.unRegistro.Lista);


                delegadoAviso("Los datos del clientes se actualizaron correctamente\nLos cambios se veran reflejados en la lista original", "Cambios guardados con exito");
                this.Close();


            }
        }

        /// <summary>
        /// modifica el cliente elegido con los nuevos  datos ingresados
        /// </summary>
        /// <returns></returns>
        public bool ModificarEmpleado()
        {
            bool retorno = false;
            

            foreach (Cliente unCliente in this.unRegistro.Lista)
            {
                if (unCliente.NroCliente == this.txtBoxNroClienteBuscado.Text)
                {
                    unCliente.Nombre = this.txtBoxNuevoNombre.Text;
                    unCliente.Apellido = this.txtBoxNuevoApellido.Text;
                    unCliente.Direccion = this.txtBoxNuevaDireccion.Text;
                    unCliente.NumeroTelefono = this.txtBoxNuevoTel.Text;
                    unCliente.Email = this.txtBoxNuevoEmail.Text;
                    retorno = true;

                    break;
                }
                else
                {
                    throw new ExcepcionRetornoFalse("Excepcion controlada");
                }
            }
            return retorno;
        }

        /// <summary>
        /// valida que no se puedan ingresar numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxNuevoTel_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar != (char)Keys.Back && !(Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Hubo un error al ingresar la informacion del cliente", "Error al ingresar NUMERO DE TELEFONO", MessageBoxButtons.OK);
                e.Handled = true;
            }
            
        }

        
    }
}
