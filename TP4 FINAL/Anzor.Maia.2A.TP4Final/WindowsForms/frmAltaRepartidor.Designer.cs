
namespace WindowsForms
{
    partial class frmAltaRepartidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaRepartidor));
            this.btnAgregarRepar = new System.Windows.Forms.Button();
            this.txtBoxNuevoEstadoRepar = new System.Windows.Forms.TextBox();
            this.txtBoxNumContactoRepar = new System.Windows.Forms.TextBox();
            this.lblNumeroContactoRepar = new System.Windows.Forms.Label();
            this.txtBoxNuevoSexoRepar = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtBoxNuevoApellidoRepar = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNuevoNombreRepar = new System.Windows.Forms.TextBox();
            this.lblModificacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarRepar
            // 
            this.btnAgregarRepar.Location = new System.Drawing.Point(28, 317);
            this.btnAgregarRepar.Name = "btnAgregarRepar";
            this.btnAgregarRepar.Size = new System.Drawing.Size(149, 36);
            this.btnAgregarRepar.TabIndex = 52;
            this.btnAgregarRepar.Text = "Agregar repartidor";
            this.btnAgregarRepar.UseVisualStyleBackColor = true;
            this.btnAgregarRepar.Click += new System.EventHandler(this.btnAgregarRepar_Click);
            // 
            // txtBoxNuevoEstadoRepar
            // 
            this.txtBoxNuevoEstadoRepar.Location = new System.Drawing.Point(12, 258);
            this.txtBoxNuevoEstadoRepar.Name = "txtBoxNuevoEstadoRepar";
            this.txtBoxNuevoEstadoRepar.Size = new System.Drawing.Size(204, 23);
            this.txtBoxNuevoEstadoRepar.TabIndex = 51;
            // 
            // txtBoxNumContactoRepar
            // 
            this.txtBoxNumContactoRepar.Location = new System.Drawing.Point(199, 157);
            this.txtBoxNumContactoRepar.Name = "txtBoxNumContactoRepar";
            this.txtBoxNumContactoRepar.Size = new System.Drawing.Size(165, 23);
            this.txtBoxNumContactoRepar.TabIndex = 49;
            this.txtBoxNumContactoRepar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNumContactoRepar_KeyPress);
            // 
            // lblNumeroContactoRepar
            // 
            this.lblNumeroContactoRepar.AutoSize = true;
            this.lblNumeroContactoRepar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNumeroContactoRepar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroContactoRepar.Location = new System.Drawing.Point(199, 137);
            this.lblNumeroContactoRepar.Name = "lblNumeroContactoRepar";
            this.lblNumeroContactoRepar.Size = new System.Drawing.Size(146, 17);
            this.lblNumeroContactoRepar.TabIndex = 48;
            this.lblNumeroContactoRepar.Text = "Numero de contacto";
            // 
            // txtBoxNuevoSexoRepar
            // 
            this.txtBoxNuevoSexoRepar.Location = new System.Drawing.Point(12, 157);
            this.txtBoxNuevoSexoRepar.Name = "txtBoxNuevoSexoRepar";
            this.txtBoxNuevoSexoRepar.Size = new System.Drawing.Size(165, 23);
            this.txtBoxNuevoSexoRepar.TabIndex = 47;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(12, 137);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 17);
            this.lblDireccion.TabIndex = 46;
            this.lblDireccion.Text = "Sexo f/m";
            // 
            // txtBoxNuevoApellidoRepar
            // 
            this.txtBoxNuevoApellidoRepar.Location = new System.Drawing.Point(199, 96);
            this.txtBoxNuevoApellidoRepar.Name = "txtBoxNuevoApellidoRepar";
            this.txtBoxNuevoApellidoRepar.Size = new System.Drawing.Size(165, 23);
            this.txtBoxNuevoApellidoRepar.TabIndex = 45;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(199, 76);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 17);
            this.lblApellido.TabIndex = 44;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 17);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBoxNuevoNombreRepar
            // 
            this.txtBoxNuevoNombreRepar.Location = new System.Drawing.Point(12, 96);
            this.txtBoxNuevoNombreRepar.Name = "txtBoxNuevoNombreRepar";
            this.txtBoxNuevoNombreRepar.Size = new System.Drawing.Size(165, 23);
            this.txtBoxNuevoNombreRepar.TabIndex = 42;
            // 
            // lblModificacion
            // 
            this.lblModificacion.AutoSize = true;
            this.lblModificacion.BackColor = System.Drawing.SystemColors.Control;
            this.lblModificacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModificacion.Location = new System.Drawing.Point(12, 37);
            this.lblModificacion.Name = "lblModificacion";
            this.lblModificacion.Size = new System.Drawing.Size(252, 23);
            this.lblModificacion.TabIndex = 41;
            this.lblModificacion.Text = "Informacion del repartidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "Estado del repartidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "(Ejemplo: Activo - Inactivo)";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(199, 317);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 36);
            this.btnSalir.TabIndex = 59;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAltaRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 382);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarRepar);
            this.Controls.Add(this.txtBoxNuevoEstadoRepar);
            this.Controls.Add(this.txtBoxNumContactoRepar);
            this.Controls.Add(this.lblNumeroContactoRepar);
            this.Controls.Add(this.txtBoxNuevoSexoRepar);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtBoxNuevoApellidoRepar);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxNuevoNombreRepar);
            this.Controls.Add(this.lblModificacion);
            this.DoubleBuffered = true;
            this.Name = "frmAltaRepartidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRepartidorModificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarRepar;
        private System.Windows.Forms.TextBox txtBoxNuevoEstadoRepar;
        private System.Windows.Forms.TextBox txtBoxNumContactoRepar;
        private System.Windows.Forms.Label lblNumeroContactoRepar;
        private System.Windows.Forms.TextBox txtBoxNuevoSexoRepar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtBoxNuevoApellidoRepar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNuevoNombreRepar;
        private System.Windows.Forms.Label lblModificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}