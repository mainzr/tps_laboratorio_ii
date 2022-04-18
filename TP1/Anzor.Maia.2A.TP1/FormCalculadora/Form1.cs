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

namespace FormCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// cierra el programa al presionar el boton cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// limpia todas las casillas y el operador seleccionado anteriormente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.SelectedIndex = 0;
            lblResultado.Text = "";
            
        }
        /// <summary>
        /// carga los tipos de operadores disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add(" ");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("+");

            lblResultado.Text = "0";
            

        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;

            Operando num1 = new Operando(Convert.ToDouble(numero1));
            Operando num2 = new Operando(Convert.ToDouble(numero2));

            resultado = Calculadora.Operar(num1, num2, Convert.ToChar(operador));//SI EL METODO ES ESTATICO SE LLMAMA MEDIANTE LA CLASE

            return resultado;
        }
        /// <summary>
        /// realiza la operacion seleccionada al realizar click en el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = 0;

            txtNumero1.Text = txtNumero1.Text.Replace('.', ',');
            txtNumero2.Text = txtNumero2.Text.Replace('.', ',');

            if (cmbOperador.Text == "")
            {
                cmbOperador.Text = "+";
            }


            if (double.TryParse(txtNumero1.Text, out resultado) == false)
            {
                txtNumero1.Text = "0";
                lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
                lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}");
            }
            else if (double.TryParse(txtNumero2.Text, out resultado) == false)
            {
                txtNumero2.Text = "0";
                lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
                lstOperaciones.Items.Add($"{txtNumero2.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}");
            }
            else
            {
                lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
                lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}");
            }


         

        }

        /// <summary>
        /// convierte el numero a bianario al seleccionar el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando objeto = new Operando();

            if (string.IsNullOrEmpty(lblResultado.Text) == true)
            {
                lblResultado.Text = "Error al realizar conversion";
            }
            else
            {
               lblResultado.Text = objeto.DecimalBinario(lblResultado.Text);
            }

        }

        /// <summary>
        /// convierte el numero a decimal al seleccionar el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando objeto = new Operando();

            if (string.IsNullOrEmpty(lblResultado.Text) == true)
            {
                lblResultado.Text = "Error";
            }
            else
            {
                lblResultado.Text = objeto.BinarioDecimal(lblResultado.Text);
            }

        }
        /// <summary>
        /// evento que se va a activar al intentar cerrar el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult variable;

            variable = MessageBox.Show("¿Seguro desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(variable == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

       
    }
}
