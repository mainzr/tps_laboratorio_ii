using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class frmListaRepartidores : Form
    {
        RegistroRepartidores registroRepartidores;
        public frmListaRepartidores(RegistroRepartidores registro)
        {
            InitializeComponent();
            this.registroRepartidores = registro;
        }

        /// <summary>
        /// inserta la lista con la informacion de los repartidores en richtext
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmListaRepartidores_Load(object sender, EventArgs e)
        {
            this.registroRepartidores.ListaRepartidores = GestorSQL.LeerRepartidores();

            foreach (Repartidores item in this.registroRepartidores.ListaRepartidores)
            {
                this.richTxtListaRepar.Text += item.Mostrar();
            }

           
        }

      
        /// <summary>
        /// cierra el fomulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// abre el formulario donde se dara de alta un repartidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarRepa_Click(object sender, EventArgs e)
        {
            frmAltaRepartidor f = new frmAltaRepartidor();

            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
