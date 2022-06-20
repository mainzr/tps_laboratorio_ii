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
using System.Text.RegularExpressions;

namespace WindowsForms
{
    public partial class frmAltaRepartidor : Form
    {
        
        public frmAltaRepartidor()
        {
            InitializeComponent();

        }

        /// <summary>
        /// da de alta repartidores y los agrega a la lista cn todos sus datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarRepar_Click(object sender, EventArgs e)
        {
           
            
            if (this.txtBoxNuevoNombreRepar.Text == string.Empty || this.txtBoxNuevoApellidoRepar.Text == string.Empty || this.txtBoxNuevoEstadoRepar.Text == string.Empty ||
                this.txtBoxNuevoSexoRepar.Text == string.Empty || this.lblNumeroContactoRepar.Text == string.Empty)
            {
               MessageBox.Show("Debe completar todos los datos con la informacion del repartidor", "Datos incompletos", MessageBoxButtons.OK);
                
            }
            else if (Regex.IsMatch(this.txtBoxNuevoSexoRepar.Text, @"^[f-m-F-M]+$") == false)      
            {
                MessageBox.Show("Ingreso de informacion incorrecta","Error al agregar repartidor", MessageBoxButtons.OK);
                               
            }
            else if(this.txtBoxNuevoEstadoRepar.Text.ToLower() != "inactivo" && this.txtBoxNuevoEstadoRepar.Text.ToLower() != "activo")
            {
                MessageBox.Show("Ingreso de informacion incorrecta (estado del empleado)", "Error al agregar repartidor", MessageBoxButtons.OK);
            }
            else
            {
    
                Repartidores r = new Repartidores(this.txtBoxNuevoNombreRepar.Text, this.txtBoxNuevoApellidoRepar.Text, this.txtBoxNuevoSexoRepar.Text.ToUpper(), this.txtBoxNumContactoRepar.Text, this.txtBoxNuevoEstadoRepar.Text.ToLower());
                r.AgregarRepartidor();

                this.Close();              
            }
        }

        /// <summary>
        /// cierra el form al salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// valida que no se puedan ingresar numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxNumContactoRepar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !(Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Hubo un error al ingresar la informacion del cliente", "Error al ingresar NUMERO DE TELEFONO", MessageBoxButtons.OK);
                e.Handled = true;
            }

        }
    }
}
