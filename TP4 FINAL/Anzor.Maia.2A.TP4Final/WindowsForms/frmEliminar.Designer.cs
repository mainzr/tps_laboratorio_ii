
namespace WindowsForms
{
    partial class frmEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminar));
            this.lblClientes = new System.Windows.Forms.GroupBox();
            this.txtClientesExistentesElimi = new System.Windows.Forms.RichTextBox();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.txtBoxNroClienteBuscado = new System.Windows.Forms.TextBox();
            this.lblLnroClienteElimi = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.Controls.Add(this.txtClientesExistentesElimi);
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClientes.Location = new System.Drawing.Point(22, 139);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(366, 205);
            this.lblClientes.TabIndex = 40;
            this.lblClientes.TabStop = false;
            this.lblClientes.Text = "Listado de clientes";
            // 
            // txtClientesExistentesElimi
            // 
            this.txtClientesExistentesElimi.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClientesExistentesElimi.Location = new System.Drawing.Point(11, 21);
            this.txtClientesExistentesElimi.Name = "txtClientesExistentesElimi";
            this.txtClientesExistentesElimi.ReadOnly = true;
            this.txtClientesExistentesElimi.Size = new System.Drawing.Size(334, 168);
            this.txtClientesExistentesElimi.TabIndex = 0;
            this.txtClientesExistentesElimi.Text = "";
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.BackColor = System.Drawing.SystemColors.Control;
            this.lblEjemplo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblEjemplo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEjemplo.Location = new System.Drawing.Point(22, 66);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(88, 15);
            this.lblEjemplo.TabIndex = 43;
            this.lblEjemplo.Text = "(Ejemplo: 2014)";
            // 
            // txtBoxNroClienteBuscado
            // 
            this.txtBoxNroClienteBuscado.Location = new System.Drawing.Point(22, 84);
            this.txtBoxNroClienteBuscado.Multiline = true;
            this.txtBoxNroClienteBuscado.Name = "txtBoxNroClienteBuscado";
            this.txtBoxNroClienteBuscado.Size = new System.Drawing.Size(286, 23);
            this.txtBoxNroClienteBuscado.TabIndex = 42;
            // 
            // lblLnroClienteElimi
            // 
            this.lblLnroClienteElimi.AutoSize = true;
            this.lblLnroClienteElimi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.lblLnroClienteElimi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLnroClienteElimi.Location = new System.Drawing.Point(22, 35);
            this.lblLnroClienteElimi.Name = "lblLnroClienteElimi";
            this.lblLnroClienteElimi.Size = new System.Drawing.Size(304, 19);
            this.lblLnroClienteElimi.TabIndex = 41;
            this.lblLnroClienteElimi.Text = "Numero de cliente a cancelar pedido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(122, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 33);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar Pedido";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 412);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.txtBoxNroClienteBuscado);
            this.Controls.Add(this.lblLnroClienteElimi);
            this.Controls.Add(this.lblClientes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelacion de pedido";
            this.Load += new System.EventHandler(this.frmEliminar_Load);
            this.lblClientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox lblClientes;
        private System.Windows.Forms.RichTextBox txtClientesExistentesElimi;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.TextBox txtBoxNroClienteBuscado;
        private System.Windows.Forms.Label lblLnroClienteElimi;
        private System.Windows.Forms.Button btnCancelar;
    }
}