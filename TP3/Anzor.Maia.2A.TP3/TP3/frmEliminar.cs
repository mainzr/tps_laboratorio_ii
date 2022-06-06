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

namespace TP3
{
    public partial class frmEliminar : Form
    {
        Registro unRegistro;
        List<Cliente> listaNueva;
        Serializador serializar;
        public frmEliminar(Registro registro)
        {
            InitializeComponent();
            this.unRegistro = registro;
            this.listaNueva = new List<Cliente>();
            this.serializar = new Serializador();
        }
        /// <summary>
        /// carga el rich text con los elemenetos de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEliminar_Load(object sender, EventArgs e)
        {
            frmListaClientes lista = new frmListaClientes(unRegistro);

             foreach (Cliente item in this.unRegistro.Lista)
             {
                 this.txtClientesExistentesElimi.Text += item.Mostrar();
             }
           
        }

        /// <summary>
        /// elimina un pedido segun el nro de cliente ingresasdo y serializa la nueva lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmAlta f = new frmAlta(unRegistro);
            string ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + "BackupListaPedidos_XmlExtension.xml";
            bool retorno;
            bool eliminado;

            if (string.IsNullOrEmpty(this.txtBoxNroClienteBuscado.Text))
            {
                MessageBox.Show("Se debe ingresar un numero de cliente", "Error al ingresar datos");
            }
            else
            {
                try
                {
                    //funcion elimina pedido
                    eliminado = ClientesIguales();
                }
                catch (ExcepcionRetornoFalse ex)
                {

                    MessageBox.Show(ex.Message);
                }
    
                retorno = this.serializar.SerializarXml(ruta, this.unRegistro.Lista);

                MessageBox.Show("Pedido cancelado correctamente", "Cancelacion exitosa", MessageBoxButtons.OK);
                this.Close();
            }
        }

        /// <summary>
        /// verifica cuando dos clientes son iguales y lo elimina
        /// </summary>
        /// <returns>true si lo elimino, false caso contrario</returns>
        public bool ClientesIguales()
        {
            bool retorno = false;
            foreach (Cliente cliente in this.unRegistro.Lista)
            {
                if (cliente.NroCliente == this.txtBoxNroClienteBuscado.Text)
                {
                    this.unRegistro.Lista.Remove(cliente);
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
    }
}
