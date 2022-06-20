
namespace WindowsForms
{
    partial class frmModificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificar));
            this.txtBoxNuevoEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxNuevoTel = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.txtBoxNuevaDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtBoxNuevoApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblModificacion = new System.Windows.Forms.Label();
            this.btnModificarDatos = new System.Windows.Forms.Button();
            this.txtBoxNroClienteBuscado = new System.Windows.Forms.TextBox();
            this.lblLnroCliente = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.GroupBox();
            this.txtClientesExistentes = new System.Windows.Forms.RichTextBox();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.lblClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxNuevoEmail
            // 
            this.txtBoxNuevoEmail.Location = new System.Drawing.Point(29, 323);
            this.txtBoxNuevoEmail.Name = "txtBoxNuevoEmail";
            this.txtBoxNuevoEmail.Size = new System.Drawing.Size(165, 23);
            this.txtBoxNuevoEmail.TabIndex = 34;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(29, 303);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxNuevoTel
            // 
            this.txtBoxNuevoTel.Location = new System.Drawing.Point(216, 263);
            this.txtBoxNuevoTel.Name = "txtBoxNuevoTel";
            this.txtBoxNuevoTel.Size = new System.Drawing.Size(165, 23);
            this.txtBoxNuevoTel.TabIndex = 32;
            this.txtBoxNuevoTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNuevoTel_KeyPress);
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroTelefono.Location = new System.Drawing.Point(216, 243);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(122, 17);
            this.lblNumeroTelefono.TabIndex = 31;
            this.lblNumeroTelefono.Text = "Numero Telefono:";
            // 
            // txtBoxNuevaDireccion
            // 
            this.txtBoxNuevaDireccion.Location = new System.Drawing.Point(29, 263);
            this.txtBoxNuevaDireccion.Name = "txtBoxNuevaDireccion";
            this.txtBoxNuevaDireccion.Size = new System.Drawing.Size(165, 23);
            this.txtBoxNuevaDireccion.TabIndex = 30;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(29, 243);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(73, 17);
            this.lblDireccion.TabIndex = 29;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtBoxNuevoApellido
            // 
            this.txtBoxNuevoApellido.Location = new System.Drawing.Point(216, 202);
            this.txtBoxNuevoApellido.Name = "txtBoxNuevoApellido";
            this.txtBoxNuevoApellido.Size = new System.Drawing.Size(165, 23);
            this.txtBoxNuevoApellido.TabIndex = 28;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(216, 182);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 17);
            this.lblApellido.TabIndex = 27;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(29, 182);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 17);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBoxNuevoNombre
            // 
            this.txtBoxNuevoNombre.Location = new System.Drawing.Point(29, 202);
            this.txtBoxNuevoNombre.Name = "txtBoxNuevoNombre";
            this.txtBoxNuevoNombre.Size = new System.Drawing.Size(165, 23);
            this.txtBoxNuevoNombre.TabIndex = 25;
            // 
            // lblModificacion
            // 
            this.lblModificacion.AutoSize = true;
            this.lblModificacion.BackColor = System.Drawing.SystemColors.Control;
            this.lblModificacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModificacion.Location = new System.Drawing.Point(29, 138);
            this.lblModificacion.Name = "lblModificacion";
            this.lblModificacion.Size = new System.Drawing.Size(238, 23);
            this.lblModificacion.TabIndex = 24;
            this.lblModificacion.Text = "Nuevos datos del cliente";
            // 
            // btnModificarDatos
            // 
            this.btnModificarDatos.Location = new System.Drawing.Point(130, 369);
            this.btnModificarDatos.Name = "btnModificarDatos";
            this.btnModificarDatos.Size = new System.Drawing.Size(149, 32);
            this.btnModificarDatos.TabIndex = 36;
            this.btnModificarDatos.Text = "Modificar";
            this.btnModificarDatos.UseVisualStyleBackColor = true;
            this.btnModificarDatos.Click += new System.EventHandler(this.btnModificarDatos_Click);
            // 
            // txtBoxNroClienteBuscado
            // 
            this.txtBoxNroClienteBuscado.Location = new System.Drawing.Point(29, 85);
            this.txtBoxNroClienteBuscado.Multiline = true;
            this.txtBoxNroClienteBuscado.Name = "txtBoxNroClienteBuscado";
            this.txtBoxNroClienteBuscado.Size = new System.Drawing.Size(250, 23);
            this.txtBoxNroClienteBuscado.TabIndex = 38;
            // 
            // lblLnroCliente
            // 
            this.lblLnroCliente.AutoSize = true;
            this.lblLnroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblLnroCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLnroCliente.Location = new System.Drawing.Point(29, 36);
            this.lblLnroCliente.Name = "lblLnroCliente";
            this.lblLnroCliente.Size = new System.Drawing.Size(250, 23);
            this.lblLnroCliente.TabIndex = 37;
            this.lblLnroCliente.Text = "Ingrese numero de cliente";
            // 
            // lblClientes
            // 
            this.lblClientes.Controls.Add(this.txtClientesExistentes);
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblClientes.Location = new System.Drawing.Point(421, 37);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(230, 351);
            this.lblClientes.TabIndex = 39;
            this.lblClientes.TabStop = false;
            this.lblClientes.Text = "Copia listado de clientes";
            // 
            // txtClientesExistentes
            // 
            this.txtClientesExistentes.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClientesExistentes.Location = new System.Drawing.Point(6, 21);
            this.txtClientesExistentes.Name = "txtClientesExistentes";
            this.txtClientesExistentes.Size = new System.Drawing.Size(218, 324);
            this.txtClientesExistentes.TabIndex = 0;
            this.txtClientesExistentes.Text = "";
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.BackColor = System.Drawing.SystemColors.Control;
            this.lblEjemplo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblEjemplo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEjemplo.Location = new System.Drawing.Point(29, 67);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(88, 15);
            this.lblEjemplo.TabIndex = 40;
            this.lblEjemplo.Text = "(Ejemplo: 2014)";
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 413);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.txtBoxNroClienteBuscado);
            this.Controls.Add(this.lblLnroCliente);
            this.Controls.Add(this.btnModificarDatos);
            this.Controls.Add(this.txtBoxNuevoEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBoxNuevoTel);
            this.Controls.Add(this.lblNumeroTelefono);
            this.Controls.Add(this.txtBoxNuevaDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtBoxNuevoApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxNuevoNombre);
            this.Controls.Add(this.lblModificacion);
            this.DoubleBuffered = true;
            this.Name = "frmModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion del pedido";
            this.Load += new System.EventHandler(this.frmModificar_Load);
            this.lblClientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxNuevoEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxNuevoTel;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.TextBox txtBoxNuevaDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtBoxNuevoApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNuevoNombre;
        private System.Windows.Forms.Label lblModificacion;
        private System.Windows.Forms.Button btnModificarDatos;
        private System.Windows.Forms.TextBox txtBoxNroClienteBuscado;
        private System.Windows.Forms.Label lblLnroCliente;
        private System.Windows.Forms.GroupBox lblClientes;
        private System.Windows.Forms.RichTextBox txtClientesExistentes;
        private System.Windows.Forms.Label lblEjemplo;
    }
}