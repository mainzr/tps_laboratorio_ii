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
    public partial class frmAlta : Form
    {
        Registro unRegistro;
        string tipoComida;
        Cliente cliente;
        Serializador serializar;
        public frmAlta(Registro registro)
        {
            InitializeComponent();
            //this.unRegistro = registro;
            this.unRegistro = registro;
            tipoComida = string.Empty;
            serializar = new Serializador();
        }

        //ctores cliente

        public string NroCliente
        {
            get { return NroClienteRan(); }
        }
        public string Nombre
        {
            get { return this.txtBoxNombre.Text; }
            set { this.txtBoxNombre.Text = value; }
        }

        public string Apellido
        {
            get { return this.txtBoxApellido.Text; }
            set { this.txtBoxApellido.Text = value; }
        }

        public string Direccion
        {
            get { return this.txtBoxDireccion.Text; }
            set { this.txtBoxDireccion.Text = value; }
        }


        public string NumeroTelefono
        {
            get { return this.txtBoxTel.Text; }
            set { this.txtBoxTel.Text = value; }
        }

        public string Email
        {
            get { return this.txtBoxEmail.Text; }
            set { this.txtBoxEmail.Text = value; }
        }

        //ctor comida
        public string ComidaTipo
        {

            set { this.tipoComida = value; }
            get { return this.tipoComida; }
        }

        public string NombreComida
        {
            get { return this.ComidaElegida(); }
        }

        public List<Cliente> ListaActual
        {
            get { return this.unRegistro.Lista; }
        }
      
        public Cliente ClienteAgregado
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
    


        public string ComidaElegida()
        {
            string valor = "";

            if (rdbUdon.Checked)
            {
                valor += "\nJaponesa-Fides Udon";

            }

            if (rdbGyudon.Checked)
            {
                valor += "\nJaponesa-Gyudon";

            }

            if (rdbBibimbap.Checked)
            {
                valor += "\nJaponesa-Tempura";

            }

            if (rdbBibimbap.Checked)
            {
                valor += "\nCoreana-Bibimbap";

            }

            if (rdbTeok.Checked)
            {
                valor += "\nCoreana-Tteokbokki";

            }

            if (rdbBulgo.Checked)
            {
                valor += "\nCoreana-Bulgogi";

            }

            if (rdbPollo.Checked)
            {
                valor += "\nChina-Pollo Kung Pao";

            }

            if (rdbCerdo.Checked)
            {
                valor += "\nChina-Cerdo agridulce";

            }

            if (rdbRollito.Checked)
            {
                valor += "\nChina-Rollo de primavera";

            }


            return valor;
        }

        public string NroClienteRan()
        {
            Random ran = new Random();
            double clienteRan = ran.Next(1000, 2000); 

            return clienteRan.ToString();
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            frmEnvio frmEnvio = new frmEnvio(unRegistro);
            frmListaClientes lista = new frmListaClientes(unRegistro);
            string ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + "BackupListaPedidos_XmlExtension.xml";
            bool retorno;

            //validacion campos vacion
            if (String.IsNullOrEmpty(txtBoxNombre.Text) || String.IsNullOrEmpty(txtBoxApellido.Text) || String.IsNullOrEmpty(txtBoxDireccion.Text) ||
                String.IsNullOrEmpty(txtBoxTel.Text) || String.IsNullOrEmpty(txtBoxEmail.Text) || this.lblTotal.Text == "0")
            {
                MessageBox.Show("Debe completar los campos con la informacion del cliente", "Error datos incompletos");
            }
            else
            {
                this.Nombre = this.txtBoxNombre.Text;
                this.Apellido = this.txtBoxApellido.Text;
                this.Direccion = this.txtBoxDireccion.Text;
                this.NumeroTelefono = this.txtBoxTel.Text;
                this.Email = this.txtBoxEmail.Text;              


                if (this.ComidaTipo == "Coreana")
                {
                    cliente = new Cliente(this.Nombre, this.Apellido, this.Direccion, this.NumeroTelefono, this.Email, NroClienteRan(), new ComidaCoreana(this.NombreComida, this.ComidaTipo,Convert.ToDouble( this.lblTotal.Text)));

                }
                else if (this.ComidaTipo == "China")
                {
                    cliente = new Cliente(this.Nombre, this.Apellido, this.Direccion, this.NumeroTelefono, this.Email, NroClienteRan(), new ComidaChina(this.NombreComida, this.ComidaTipo, Convert.ToDouble(this.lblTotal.Text)));

                }
                else if (this.ComidaTipo == "Japonesa")
                {
                    cliente = new Cliente(this.Nombre, this.Apellido, this.Direccion, this.NumeroTelefono, this.Email, NroClienteRan(), new ComidaJaponesa(this.NombreComida, this.ComidaTipo, Convert.ToDouble(this.lblTotal.Text)));

                }
                cliente = ClienteAgregado;
                //----------------CARGO DATOS INGRESADOS EN LA LISTA-------------
                unRegistro.Lista.Add(cliente);
                retorno = this.serializar.SerializarXml(ruta, this.unRegistro.Lista);
                
                this.Hide();
                frmEnvio.ShowDialog();
                this.Close();

               
            }
        }

        public string BuscarCliente(string nroCliente)
        {
            string retornoNro = "";

            foreach (Cliente unCliente in this.unRegistro.Lista)
            {
                if (unCliente.NroCliente == nroCliente)
                {
                    retornoNro = unCliente.NroCliente;
                }
            }

            return retornoNro;
        }

        private void rdbUdon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUdon.Checked)
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) + 1500;
                this.lblTotal.Text = valor.ToString();
                this.ComidaTipo = "Japonesa";
            }
            else
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) - 1500;
                this.lblTotal.Text = valor.ToString();
            }
            
        }

        private void rdbGyudon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGyudon.Checked)
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) + 1350;
                this.lblTotal.Text = valor.ToString();
                this.ComidaTipo = "Japonesa";
            }
            else
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) - 1350;
                this.lblTotal.Text = valor.ToString();
            }
        }

        private void rdbTempura_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTempura.Checked)
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) + 1600;
                this.lblTotal.Text = valor.ToString();
                this.ComidaTipo = "Japonesa";
            }
            else
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) - 1600;
                this.lblTotal.Text = valor.ToString();
            }
        }

        private void rdbBibimbap_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBibimbap.Checked)
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) + 1200;
                this.lblTotal.Text = valor.ToString();
                this.ComidaTipo = "Coreana";
            }
            else
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) - 1200;
                this.lblTotal.Text = valor.ToString();
            }
        }

        private void rdbTeok_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTeok.Checked)
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) + 1450;
                this.lblTotal.Text = valor.ToString();
                this.ComidaTipo = "Coreana";

            }
            else
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) - 1450;
                this.lblTotal.Text = valor.ToString();
            }
        }

        private void rdbBulgo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBulgo.Checked)
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) + 1200;
                this.lblTotal.Text = valor.ToString();
                this.ComidaTipo = "Coreana";

            }
            else
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) - 1200;
                this.lblTotal.Text = valor.ToString();
            }
        }

        private void rdbPollo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPollo.Checked)
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) + 1200;
                this.lblTotal.Text = valor.ToString();
                this.ComidaTipo = "China";

            }
            else
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) - 1200;
                this.lblTotal.Text = valor.ToString();
            }
        }

        private void rdbCerdo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCerdo.Checked)
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) + 1600;
                this.lblTotal.Text = valor.ToString();
                this.ComidaTipo = "China";

            }
            else
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) - 1600;
                this.lblTotal.Text = valor.ToString();
            }
        }

        private void rdbRollito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRollito.Checked)
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) + 400;
                this.lblTotal.Text = valor.ToString();
                this.ComidaTipo = "China";

            }
            else
            {
                double valor = Convert.ToDouble(this.lblTotal.Text) - 400;
                this.lblTotal.Text = valor.ToString();
            }
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
