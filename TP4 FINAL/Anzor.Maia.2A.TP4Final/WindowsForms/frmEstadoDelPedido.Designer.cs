
namespace WindowsForms
{
    partial class frmEstadoDelPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadoDelPedido));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCargando = new System.Windows.Forms.Label();
            this.lblPedidoListo = new System.Windows.Forms.Label();
            this.lblCargando = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(50, 171);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(206, 23);
            this.progressBar.Step = 2;
            this.progressBar.TabIndex = 2;
            this.progressBar.Value = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelCargando);
            this.groupBox1.Controls.Add(this.lblPedidoListo);
            this.groupBox1.Controls.Add(this.lblCargando);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(32, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTADO DEL PEDIDO";
            // 
            // labelCargando
            // 
            this.labelCargando.AutoSize = true;
            this.labelCargando.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCargando.Location = new System.Drawing.Point(12, 39);
            this.labelCargando.Name = "labelCargando";
            this.labelCargando.Size = new System.Drawing.Size(180, 25);
            this.labelCargando.TabIndex = 4;
            this.labelCargando.Text = "Procesando pedido...";
            // 
            // lblPedidoListo
            // 
            this.lblPedidoListo.AutoSize = true;
            this.lblPedidoListo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPedidoListo.Location = new System.Drawing.Point(12, 39);
            this.lblPedidoListo.Name = "lblPedidoListo";
            this.lblPedidoListo.Size = new System.Drawing.Size(58, 25);
            this.lblPedidoListo.TabIndex = 1;
            this.lblPedidoListo.Text = "label1";
            this.lblPedidoListo.Visible = false;
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCargando.Location = new System.Drawing.Point(6, 37);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(0, 25);
            this.lblCargando.TabIndex = 0;
            // 
            // frmEstadoDelPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(317, 221);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEstadoDelPedido";
            this.Text = "frmEstadoDelPedido";
            this.Load += new System.EventHandler(this.frmEstadoDelPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.Label lblPedidoListo;
        private System.Windows.Forms.Label labelCargando;
    }
}