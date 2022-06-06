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
    public partial class frmListaClientes : Form
    {
        Registro unRegistro;
        Serializador serializar;
        List<Cliente> aux;

        public frmListaClientes(Registro registro)
        {
            InitializeComponent();
            this.unRegistro = registro;
            serializar = new Serializador();
            aux = new List<Cliente>();
        }


        public string Contenido
        {
            set {this.richTxtLista.Text = value; }
            get { return this.richTxtLista.Text; }
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            frmAlta f = new frmAlta(unRegistro);

            if(File.Exists("BackupListaPedidos_XmlExtension.xml"))
            {              
       
                string ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"BackupListaPedidos_XmlExtension.xml";
                 this.unRegistro.Lista = this.serializar.DeserializarXml(ruta);
              

                foreach (Cliente cliente in this.unRegistro.Lista)
                {
       
                  this.richTxtLista.Text += cliente.Mostrar();
  
                }

            }
            else
            {
                try
                {
                    AgregarListaRich();
                }
                catch (ExceptionControllers ex)
                {

                    MessageBox.Show(ex.Message);
                }
               

            }

        }



        private void lblModificar_Click(object sender, EventArgs e)
        {
            frmModificar f = new frmModificar(unRegistro);

            this.Hide();
            f.ShowDialog();
            this.Close();
           
        }

        public string Rich(string s)
        {
            string valorRich = this.richTxtLista.Text;

            this.richTxtLista.Text += s;

            return valorRich;
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {

            string ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"BackupListaPedidos.txt";

            if (this.unRegistro.HacerBackUp(this.Contenido, ruta))
            {
                MessageBox.Show("Backup con extension TXT realizado con exito", "Backup finalizado");
            }
        }

        public void AgregarListaRich()
        {
            
            foreach (Cliente item in this.unRegistro.Lista)
            {
                this.richTxtLista.Text += item.Mostrar();             
            }
            if(this.richTxtLista.Text == String.Empty)
            {
                throw new ExceptionControllers("Excepcion controlada - No se realizo ningun pedido.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmEliminar formEliminar = new frmEliminar(unRegistro);

            this.Hide();
            formEliminar.ShowDialog();
            this.Close();
        }

        private void btnBackupXml_Click(object sender, EventArgs e)
        {
            string ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + "BackupListaPedidos_XmlExtension.xml";

            
            if (this.serializar.SerializarXml(ruta, this.unRegistro.Lista))
            {
                MessageBox.Show("Backup con extension XML realizado con exito");
            }
            else
            {
                MessageBox.Show("No se pudo realizar el backup con extension tipo XML", "Error al hacer backup");

            }


        }

        private void btnBackupJson_Click(object sender, EventArgs e)
        {
            string ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + "BackupListaPedidos_JsonExtension.json";

            if (this.serializar.SerializarJson(ruta, this.unRegistro.Lista))
            {
                MessageBox.Show("Backup con extension JSON realizado con exito");
            }
            else
            {
                MessageBox.Show("No se pudo realizar el backup con extension tipo JSON", "Error al hacer backup");
            }
          
        }
    }
}
  