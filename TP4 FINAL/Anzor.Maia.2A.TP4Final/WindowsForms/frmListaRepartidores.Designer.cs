
namespace WindowsForms
{
    partial class frmListaRepartidores
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
            this.richTxtListaRepar = new System.Windows.Forms.RichTextBox();
            this.lblListaPedidos = new System.Windows.Forms.Label();
            this.btnAgregarRepa = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxtListaRepar
            // 
            this.richTxtListaRepar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTxtListaRepar.Location = new System.Drawing.Point(12, 43);
            this.richTxtListaRepar.Name = "richTxtListaRepar";
            this.richTxtListaRepar.ReadOnly = true;
            this.richTxtListaRepar.Size = new System.Drawing.Size(386, 250);
            this.richTxtListaRepar.TabIndex = 27;
            this.richTxtListaRepar.Text = "";
            // 
            // lblListaPedidos
            // 
            this.lblListaPedidos.AutoSize = true;
            this.lblListaPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.lblListaPedidos.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblListaPedidos.Location = new System.Drawing.Point(12, 17);
            this.lblListaPedidos.Name = "lblListaPedidos";
            this.lblListaPedidos.Size = new System.Drawing.Size(222, 23);
            this.lblListaPedidos.TabIndex = 26;
            this.lblListaPedidos.Text = "Listado de repartidores";
            // 
            // btnAgregarRepa
            // 
            this.btnAgregarRepa.Location = new System.Drawing.Point(46, 318);
            this.btnAgregarRepa.Name = "btnAgregarRepa";
            this.btnAgregarRepa.Size = new System.Drawing.Size(140, 34);
            this.btnAgregarRepa.TabIndex = 28;
            this.btnAgregarRepa.Text = "Agregar repartidores";
            this.btnAgregarRepa.UseVisualStyleBackColor = true;
            this.btnAgregarRepa.Click += new System.EventHandler(this.btnAgregarRepa_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(214, 318);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(140, 34);
            this.Salir.TabIndex = 30;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // frmListaRepartidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(418, 372);
            this.ControlBox = false;
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btnAgregarRepa);
            this.Controls.Add(this.richTxtListaRepar);
            this.Controls.Add(this.lblListaPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListaRepartidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion en sistema";
            this.Load += new System.EventHandler(this.frmListaRepartidores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtListaRepar;
        private System.Windows.Forms.Label lblListaPedidos;
        private System.Windows.Forms.Button btnAgregarRepa;
        private System.Windows.Forms.Button Salir;
    }
}