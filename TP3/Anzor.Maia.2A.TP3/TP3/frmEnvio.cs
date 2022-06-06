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
    public partial class frmEnvio : Form
    {
        Registro unRegistro;
       
        string elegido;
        public frmEnvio(Registro registro)
        {
            InitializeComponent();
            //this.unRegistro = new Registro();
            this.unRegistro = registro;
            elegido = string.Empty;
        }

        public string PlanEnvioElegido
        {
            get { return this.EnvioElegido(); }
            set { this.elegido = value; }
        }

        private void frmEnvio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ServicioEnvio servicioEnvio = new ServicioEnvio(this.PlanEnvioElegido);
            frmListaClientes frmLista = new frmListaClientes(unRegistro);
            frmAlta formAlta = new frmAlta(unRegistro);


            MessageBox.Show($"{this.unRegistro.ToString()}{servicioEnvio.Mostrar()}", "Listado completo de facturacion", MessageBoxButtons.OK);


            this.Hide();
            this.Close();
            
        }
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

        private void rdbBasico_CheckedChanged(object sender, EventArgs e)
        {
           if(this.rdbBasico.Checked == true)
           {
                this.richTxtBox.Text = "\n\n~Cupones de descuento mensuales de 5% en pedidos\n\n";
           }
        }

        private void rdBEstandar_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rdBEstandar.Checked == true)
            {
                this.richTxtBox.Text = "\n~Descuento del 10% en envios en ordenes mayores a $4000 en proximas compras\n\n~Cupones de descuento mensuales del 25% en pedidos";
            }
        }

        private void rdbPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbPremium.Checked == true)
            {
                this.richTxtBox.Text = "\n~Envios gratis en ordenes mayores a $2000\n\n~Cupones mensuales del 50% de descuento en proximos pedidos\n\n~Prioridad de envio\n";
            }
        }
    }
}
