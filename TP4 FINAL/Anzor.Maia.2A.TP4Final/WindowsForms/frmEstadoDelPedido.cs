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
using System.Threading;

namespace WindowsForms
{
    public partial class frmEstadoDelPedido : Form
    {
        Cliente cliente;
        Registro r;
        frmAlta fAlta;
        Comida c;

        public frmEstadoDelPedido(Registro registro)
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
                Thread.Sleep(500);
                Cerrar();
                
            });

        }

       

        /// <summary>
        /// logra que el mensaje del estado del pedido titile
        /// </summary>
        public void Carga()
        {
            if (InvokeRequired)
            {
                Action action = new Action(Carga);
                this.Invoke(action);
            }
            else
            {
                lblCargando.Visible = true;
                Thread.Sleep(1000);
                lblCargando.Visible = false;
                Thread.Sleep(1000);
            }

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

               // this.labelCargando.Text = "Preparando pedido...";
                progressBar.Increment(1);

               
            }
        }



        /// <summary>
        /// arranque el cambio de mensajes alternando por tiempo y mensaje
        /// </summary>
        public void FuncionArranque()
        {
            if (InvokeRequired)
            {
                Action action = new Action(FuncionArranque);
                this.Invoke(action);
            }
            else
            {
               
               
                while (progressBar.Value < progressBar.Maximum)
                {
                  
                    FuncionCargarComida();

                }
            }
        }

        private void frmEstadoDelPedido_Load(object sender, EventArgs e)
        {
            EstadoComida();

        }

        private void Cerrar()
        {
            if (InvokeRequired)
            {
                Action action = new Action(Cerrar);
                this.Invoke(action);
            }
            else
            {
                if (progressBar.Value == progressBar.Maximum)
                {
                    this.labelCargando.Visible = false;
                 
                    this.labelCargando.Update();
                    Thread.Sleep(500);
                    this.lblPedidoListo.Visible = true;
                    this.lblPedidoListo.Text = "Comida en destino..\nPedido exitoso!";
                    this.lblPedidoListo.Refresh();
                    this.lblPedidoListo.Update();
                   
                    Thread.Sleep(3000);
                }
                // Carga();
                this.Close();
            }
        }
    }
}
