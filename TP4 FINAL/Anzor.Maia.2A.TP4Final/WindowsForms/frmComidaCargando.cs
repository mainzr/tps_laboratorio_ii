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

namespace WindowsForms
{
    public partial class frmCargadnoComida : Form
    {
        Cliente cliente;
        Registro r;
        frmAlta fAlta;
        Comida c;


        public frmCargadnoComida(Registro registro)
        {
            
            InitializeComponent();
            cliente = new Cliente();
            fAlta = new frmAlta(r);
            r = registro;
           
        }

        /// <summary>
        /// muestra el estado del pedido con el numero de orden del cliente 
        /// </summary>
        public void EstadoComida()
        {
           
            foreach (Cliente item in r.Lista)
            {
                this.groupBox1.Text = $"ESTADO DEL PEDIDO #{item.NumeroCliente}";
            }

            Task t = Task.Run(() =>
            {
                FuncionArranque();
         
            });

        }  

        /// <summary>
        /// evento load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCargadnoComida_Load(object sender, EventArgs e)
        {
            EstadoComida();
          
        }

        /// <summary>
        /// logra que el mensaje del estado del pedido titile
        /// </summary>
        public void Carga()
        {
            lblCargando.Visible = true;
            Thread.Sleep(1000);
            lblCargando.Visible = false;
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Carga el mensaje de la comida por cada momento e incrementa el valor de la barra
        /// </summary>
        public void FuncionCargarComida()
        {
 
            if (InvokeRequired)
            {
                Action action = new Action(FuncionCargarComida);
                this.Invoke(action);
            }
            else
            {
                this.lblCargando.Text = "Procesando pedido...";

                progressBar.Increment(1);

                if(progressBar.Value == progressBar.Maximum)
                {
                    this.lblCargando.Visible = true;
                    this.lblCargando.Text = "Comida en destino\nPedido exitoso!";
                    
                }
                
            }
            
        }

        /// <summary>
        /// arranque el cambio de mensajes alternando por tiempo y mensaje
        /// </summary>
        public void FuncionArranque()
        {
            Carga();
            while (progressBar.Value < progressBar.Maximum)
            {
                Carga();
                FuncionCargarComida();
            }
            Carga();
           
            this.Close();
        }

        

    }
}
