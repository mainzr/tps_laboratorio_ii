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
using System.IO;

namespace TP3
{
    public partial class frmMenu : Form
    {
        Registro registro;
        string path = null;
        public frmMenu()
        {
            InitializeComponent();
            this.registro = new Registro();
           
        }
        /// <summary>
        /// cierra el form actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// abre el nuevo formulario , donde se hace alta con informacion del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta frmAlta = new frmAlta(registro);

            frmAlta.ShowDialog();
           
        }

        /// <summary>
        /// abre el nuevo formulario donde se hara cmabio de los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmListaClientes f = new frmListaClientes(registro);
          

            f.ShowDialog();
        }


        private void frmMenu_Load(object sender, EventArgs e)
        {
          
            
        }

       
    }
}
