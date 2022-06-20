using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades;
using System.Linq;

namespace WindowsForms
{
    public partial class frmEnvio : Form
    {
        Registro unRegistro;
        Cliente c;      
        string elegido;

        public delegate void AvisarPedidoHechoHandler();

        public event AvisarPedidoHechoHandler OnAvisarPedidoHecho;

        public frmEnvio(Registro registro)
        {
            InitializeComponent();
            
            this.unRegistro = registro;
            elegido = string.Empty;
            c = new Cliente();
        }

        public string PlanEnvioElegido
        {
            get { return this.EnvioElegido(); }
            set { this.elegido = value; }
        }
        public string nroCliente
        {
            get {return this.lblNroCliente.Text; }
        }

        private void frmEnvio_Load(object sender, EventArgs e)
        {
            foreach (Cliente item in unRegistro.Lista)
            {
                this.lblNroCliente.Text += item.NumeroCliente;
            }

        }

        /// <summary>
        /// muestra por nueva ventana contenido total de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            frmCargadnoComida f = new frmCargadnoComida(unRegistro);
            
            this.OnAvisarPedidoHecho += Mensaje;
            this.OnAvisarPedidoHecho.Invoke();


            Task t = Task.Run(f.ShowDialog);
            
            
            this.Hide();
            this.Close();
          
        }

        /// <summary>
        /// muestra el mensaje del ultimo cliente/pedido ingresado
        /// </summary>
        public void Mensaje()
        {
            ServicioEnvio servicioEnvio = new ServicioEnvio(this.PlanEnvioElegido);
            frmAlta formAlta = new frmAlta(unRegistro);

            c = this.unRegistro.Lista.Last();
            MessageBox.Show($"{c.Mostrar() + servicioEnvio.Mostrar()}", "INFORMACION COMPLETA DE FACTURACION", MessageBoxButtons.OK);          

        }


        /// <summary>
        /// verifica que tipo de comdida fue la elegida
        /// </summary>
        /// <returns>retorna el tipo de comida elegida segun boton seleccionado</returns>
        public string EnvioElegido()
        {


            if (this.rdbBasico.Checked)
            {
                this.elegido = "Basico";
            }
            else if (this.rdBEstandar.Checked)
            {
                this.elegido = "Estandar";
            }
            else if (this.rdbPremium.Checked)
            {
                this.elegido = "Premium";
            }

            return elegido;
        }

        /// <summary>
        /// datos de informacion segun el tipo de plan a elegir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbBasico_CheckedChanged(object sender, EventArgs e)
        {
            
           if(this.rdbBasico.Checked == true)
           {
                this.richTxtBox.Text = "\n\n~Cupones de descuento mensuales de 5% en pedidos\n\n";
           }
        }
        /// <summary>
        /// datos de informacion segun el tipo de plan a elegir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBEstandar_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rdBEstandar.Checked == true)
            {
                this.richTxtBox.Text = "\n~Descuento del 10% en envios en ordenes mayores a $4000 en proximas compras\n\n~Cupones de descuento mensuales del 25% en pedidos";
            }
        }

        /// <summary>
        /// datos de informacion segun el tipo de plan a elegir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbPremium.Checked == true)
            {
                this.richTxtBox.Text = "\n~Envios gratis en ordenes mayores a $2000\n\n~Cupones mensuales del 50% de descuento en proximos pedidos\n\n~Prioridad de envio\n";
            }
        }
    }
}
