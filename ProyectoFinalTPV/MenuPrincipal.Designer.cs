namespace ProyectoFinalTPV
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.hacerPedidoBtn = new System.Windows.Forms.Button();
            this.verPedidoBtn = new System.Windows.Forms.Button();
            this.PagarPedido = new System.Windows.Forms.Button();
            this.nombreUs = new System.Windows.Forms.Label();
            this.perfilButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hacerPedidoBtn
            // 
            this.hacerPedidoBtn.Location = new System.Drawing.Point(230, 129);
            this.hacerPedidoBtn.Name = "hacerPedidoBtn";
            this.hacerPedidoBtn.Size = new System.Drawing.Size(172, 32);
            this.hacerPedidoBtn.TabIndex = 0;
            this.hacerPedidoBtn.Text = "HACER PEDIDO";
            this.hacerPedidoBtn.UseVisualStyleBackColor = true;
            this.hacerPedidoBtn.Click += new System.EventHandler(this.hacerPedidoBtn_Click);
            // 
            // verPedidoBtn
            // 
            this.verPedidoBtn.Location = new System.Drawing.Point(230, 210);
            this.verPedidoBtn.Name = "verPedidoBtn";
            this.verPedidoBtn.Size = new System.Drawing.Size(172, 32);
            this.verPedidoBtn.TabIndex = 1;
            this.verPedidoBtn.Text = "VER PEDIDOS";
            this.verPedidoBtn.UseVisualStyleBackColor = true;
            this.verPedidoBtn.Click += new System.EventHandler(this.verPedidoBtn_Click);
            // 
            // PagarPedido
            // 
            this.PagarPedido.Location = new System.Drawing.Point(230, 289);
            this.PagarPedido.Name = "PagarPedido";
            this.PagarPedido.Size = new System.Drawing.Size(172, 32);
            this.PagarPedido.TabIndex = 2;
            this.PagarPedido.Text = "PAGAR PEDIDO";
            this.PagarPedido.UseVisualStyleBackColor = true;
            this.PagarPedido.Click += new System.EventHandler(this.PagarPedido_Click);
            // 
            // nombreUs
            // 
            this.nombreUs.AutoSize = true;
            this.nombreUs.BackColor = System.Drawing.Color.Transparent;
            this.nombreUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUs.ForeColor = System.Drawing.Color.Snow;
            this.nombreUs.Location = new System.Drawing.Point(37, 39);
            this.nombreUs.Name = "nombreUs";
            this.nombreUs.Size = new System.Drawing.Size(57, 20);
            this.nombreUs.TabIndex = 3;
            this.nombreUs.Text = "label1";
            // 
            // perfilButton
            // 
            this.perfilButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("perfilButton.BackgroundImage")));
            this.perfilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.perfilButton.Location = new System.Drawing.Point(603, 15);
            this.perfilButton.Name = "perfilButton";
            this.perfilButton.Size = new System.Drawing.Size(53, 44);
            this.perfilButton.TabIndex = 4;
            this.perfilButton.UseVisualStyleBackColor = true;
            this.perfilButton.Click += new System.EventHandler(this.perfilButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(614, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 44);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.perfilButton);
            this.Controls.Add(this.nombreUs);
            this.Controls.Add(this.PagarPedido);
            this.Controls.Add(this.verPedidoBtn);
            this.Controls.Add(this.hacerPedidoBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuPrincipal_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hacerPedidoBtn;
        private System.Windows.Forms.Button verPedidoBtn;
        private System.Windows.Forms.Button PagarPedido;
        private System.Windows.Forms.Label nombreUs;
        private System.Windows.Forms.Button perfilButton;
        private System.Windows.Forms.Button button1;
    }
}