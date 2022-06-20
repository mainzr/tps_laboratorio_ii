
namespace WindowsForms
{
    partial class frmListaClientes
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
            this.lblListaPedidos = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBackUpTxt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTxtLista = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBackupJson = new System.Windows.Forms.Button();
            this.btnBackupXml = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListaPedidos
            // 
            this.lblListaPedidos.AutoSize = true;
            this.lblListaPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.lblListaPedidos.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblListaPedidos.Location = new System.Drawing.Point(12, 26);
            this.lblListaPedidos.Name = "lblListaPedidos";
            this.lblListaPedidos.Size = new System.Drawing.Size(186, 23);
            this.lblListaPedidos.TabIndex = 18;
            this.lblListaPedidos.Text = "Listado de pedidos";
            // 
            // lblModificar
            // 
            this.lblModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModificar.Location = new System.Drawing.Point(15, 37);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(128, 33);
            this.lblModificar.TabIndex = 19;
            this.lblModificar.Text = "Modificar Pedido";
            this.lblModificar.UseVisualStyleBackColor = true;
            this.lblModificar.Click += new System.EventHandler(this.lblModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(15, 87);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 33);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar Pedido";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(340, 423);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 33);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBackUpTxt
            // 
            this.btnBackUpTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackUpTxt.Location = new System.Drawing.Point(15, 34);
            this.btnBackUpTxt.Name = "btnBackUpTxt";
            this.btnBackUpTxt.Size = new System.Drawing.Size(128, 33);
            this.btnBackUpTxt.TabIndex = 23;
            this.btnBackUpTxt.Text = "Extension TXT";
            this.btnBackUpTxt.UseVisualStyleBackColor = true;
            this.btnBackUpTxt.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblModificar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(325, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 149);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu de opciones";
            // 
            // richTxtLista
            // 
            this.richTxtLista.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTxtLista.Location = new System.Drawing.Point(12, 61);
            this.richTxtLista.Name = "richTxtLista";
            this.richTxtLista.Size = new System.Drawing.Size(287, 395);
            this.richTxtLista.TabIndex = 25;
            this.richTxtLista.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBackupJson);
            this.groupBox2.Controls.Add(this.btnBackupXml);
            this.groupBox2.Controls.Add(this.btnBackUpTxt);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(325, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 180);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipos de Backup";
            // 
            // btnBackupJson
            // 
            this.btnBackupJson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackupJson.Location = new System.Drawing.Point(15, 128);
            this.btnBackupJson.Name = "btnBackupJson";
            this.btnBackupJson.Size = new System.Drawing.Size(128, 29);
            this.btnBackupJson.TabIndex = 25;
            this.btnBackupJson.Text = "Extension JSON";
            this.btnBackupJson.UseVisualStyleBackColor = true;
            this.btnBackupJson.Click += new System.EventHandler(this.btnBackupJson_Click);
            // 
            // btnBackupXml
            // 
            this.btnBackupXml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackupXml.Location = new System.Drawing.Point(15, 84);
            this.btnBackupXml.Name = "btnBackupXml";
            this.btnBackupXml.Size = new System.Drawing.Size(128, 29);
            this.btnBackupXml.TabIndex = 24;
            this.btnBackupXml.Text = "Extension XML";
            this.btnBackupXml.UseVisualStyleBackColor = true;
            this.btnBackupXml.Click += new System.EventHandler(this.btnBackupXml_Click);
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(509, 487);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.richTxtLista);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblListaPedidos);
            this.Name = "frmListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.frmListaClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListaPedidos;
        private System.Windows.Forms.Button lblModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBackUpTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTxtLista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBackupXml;
        private System.Windows.Forms.Button btnBackupJson;
    }
}