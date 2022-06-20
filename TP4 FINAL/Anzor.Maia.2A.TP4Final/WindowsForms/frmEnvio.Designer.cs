
namespace WindowsForms
{
    partial class frmEnvio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvio));
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.lblTipoEnvio = new System.Windows.Forms.Label();
            this.groupBoxEnvio = new System.Windows.Forms.GroupBox();
            this.rdbPremium = new System.Windows.Forms.RadioButton();
            this.rdbBasico = new System.Windows.Forms.RadioButton();
            this.rdBEstandar = new System.Windows.Forms.RadioButton();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupBoxInfoPlan = new System.Windows.Forms.GroupBox();
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.groupBoxEnvio.SuspendLayout();
            this.groupBoxInfoPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.lblNroCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNroCliente.Location = new System.Drawing.Point(355, 29);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(100, 17);
            this.lblNroCliente.TabIndex = 2;
            this.lblNroCliente.Text = "Cliente nro:  #";
            // 
            // lblTipoEnvio
            // 
            this.lblTipoEnvio.AutoSize = true;
            this.lblTipoEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.lblTipoEnvio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoEnvio.Location = new System.Drawing.Point(19, 23);
            this.lblTipoEnvio.Name = "lblTipoEnvio";
            this.lblTipoEnvio.Size = new System.Drawing.Size(167, 23);
            this.lblTipoEnvio.TabIndex = 4;
            this.lblTipoEnvio.Text = "Servicio de Envio";
            // 
            // groupBoxEnvio
            // 
            this.groupBoxEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.groupBoxEnvio.Controls.Add(this.rdbPremium);
            this.groupBoxEnvio.Controls.Add(this.rdbBasico);
            this.groupBoxEnvio.Controls.Add(this.rdBEstandar);
            this.groupBoxEnvio.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBoxEnvio.Location = new System.Drawing.Point(19, 82);
            this.groupBoxEnvio.Name = "groupBoxEnvio";
            this.groupBoxEnvio.Size = new System.Drawing.Size(176, 224);
            this.groupBoxEnvio.TabIndex = 6;
            this.groupBoxEnvio.TabStop = false;
            this.groupBoxEnvio.Text = "Plan de Envio";
            // 
            // rdbPremium
            // 
            this.rdbPremium.AutoSize = true;
            this.rdbPremium.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbPremium.Location = new System.Drawing.Point(6, 164);
            this.rdbPremium.Name = "rdbPremium";
            this.rdbPremium.Size = new System.Drawing.Size(122, 21);
            this.rdbPremium.TabIndex = 2;
            this.rdbPremium.TabStop = true;
            this.rdbPremium.Text = "Envio Premium";
            this.rdbPremium.UseVisualStyleBackColor = true;
            this.rdbPremium.CheckedChanged += new System.EventHandler(this.rdbPremium_CheckedChanged);
            // 
            // rdbBasico
            // 
            this.rdbBasico.AutoSize = true;
            this.rdbBasico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbBasico.Location = new System.Drawing.Point(6, 47);
            this.rdbBasico.Name = "rdbBasico";
            this.rdbBasico.Size = new System.Drawing.Size(106, 21);
            this.rdbBasico.TabIndex = 1;
            this.rdbBasico.TabStop = true;
            this.rdbBasico.Text = "Envio Basico";
            this.rdbBasico.UseVisualStyleBackColor = true;
            this.rdbBasico.CheckedChanged += new System.EventHandler(this.rdbBasico_CheckedChanged);
            // 
            // rdBEstandar
            // 
            this.rdBEstandar.AutoSize = true;
            this.rdBEstandar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBEstandar.Location = new System.Drawing.Point(6, 105);
            this.rdBEstandar.Name = "rdBEstandar";
            this.rdBEstandar.Size = new System.Drawing.Size(121, 21);
            this.rdBEstandar.TabIndex = 0;
            this.rdBEstandar.TabStop = true;
            this.rdBEstandar.Text = "Envio Estandar";
            this.rdBEstandar.UseVisualStyleBackColor = true;
            this.rdBEstandar.CheckedChanged += new System.EventHandler(this.rdBEstandar_CheckedChanged);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(354, 327);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(144, 32);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // groupBoxInfoPlan
            // 
            this.groupBoxInfoPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.groupBoxInfoPlan.Controls.Add(this.richTxtBox);
            this.groupBoxInfoPlan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBoxInfoPlan.Location = new System.Drawing.Point(228, 82);
            this.groupBoxInfoPlan.Name = "groupBoxInfoPlan";
            this.groupBoxInfoPlan.Size = new System.Drawing.Size(249, 224);
            this.groupBoxInfoPlan.TabIndex = 9;
            this.groupBoxInfoPlan.TabStop = false;
            this.groupBoxInfoPlan.Text = "Informacion del Plan";
            // 
            // richTxtBox
            // 
            this.richTxtBox.Location = new System.Drawing.Point(16, 23);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.ReadOnly = true;
            this.richTxtBox.Size = new System.Drawing.Size(217, 185);
            this.richTxtBox.TabIndex = 8;
            this.richTxtBox.Text = "";
            // 
            // frmEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(538, 385);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxInfoPlan);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.groupBoxEnvio);
            this.Controls.Add(this.lblTipoEnvio);
            this.Controls.Add(this.lblNroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEnvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despachar";
            this.Load += new System.EventHandler(this.frmEnvio_Load);
            this.groupBoxEnvio.ResumeLayout(false);
            this.groupBoxEnvio.PerformLayout();
            this.groupBoxInfoPlan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.Label lblTipoEnvio;
        private System.Windows.Forms.GroupBox groupBoxEnvio;
        private System.Windows.Forms.RadioButton rdbPremium;
        private System.Windows.Forms.RadioButton rdbBasico;
        private System.Windows.Forms.RadioButton rdBEstandar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox groupBoxInfoPlan;
        private System.Windows.Forms.RichTextBox richTxtBox;
    }
}