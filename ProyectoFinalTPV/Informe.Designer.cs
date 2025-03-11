namespace ProyectoFinalTPV
{
    partial class Informe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informe));
            this.PagarPedido = new System.Windows.Forms.Button();
            this.verPedidoBtn = new System.Windows.Forms.Button();
            this.hacerPedidoBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreUs = new System.Windows.Forms.Label();
            this.volverBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PagarPedido
            // 
            this.PagarPedido.Location = new System.Drawing.Point(785, 754);
            this.PagarPedido.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PagarPedido.Name = "PagarPedido";
            this.PagarPedido.Size = new System.Drawing.Size(545, 91);
            this.PagarPedido.TabIndex = 5;
            this.PagarPedido.Text = "PEDIDOS";
            this.PagarPedido.UseVisualStyleBackColor = true;
            this.PagarPedido.Click += new System.EventHandler(this.PagarPedido_Click);
            // 
            // verPedidoBtn
            // 
            this.verPedidoBtn.Location = new System.Drawing.Point(1441, 529);
            this.verPedidoBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.verPedidoBtn.Name = "verPedidoBtn";
            this.verPedidoBtn.Size = new System.Drawing.Size(545, 91);
            this.verPedidoBtn.TabIndex = 4;
            this.verPedidoBtn.Text = "COMIDAS";
            this.verPedidoBtn.UseVisualStyleBackColor = true;
            this.verPedidoBtn.Click += new System.EventHandler(this.verPedidoBtn_Click);
            // 
            // hacerPedidoBtn
            // 
            this.hacerPedidoBtn.Location = new System.Drawing.Point(86, 529);
            this.hacerPedidoBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.hacerPedidoBtn.Name = "hacerPedidoBtn";
            this.hacerPedidoBtn.Size = new System.Drawing.Size(545, 91);
            this.hacerPedidoBtn.TabIndex = 3;
            this.hacerPedidoBtn.Text = "USUARIOS";
            this.hacerPedidoBtn.UseVisualStyleBackColor = true;
            this.hacerPedidoBtn.Click += new System.EventHandler(this.hacerPedidoBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(779, 55);
            this.label2.TabIndex = 7;
            this.label2.Text = "INFORMES DEL RESTAURANTE";
            // 
            // nombreUs
            // 
            this.nombreUs.AutoSize = true;
            this.nombreUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUs.Location = new System.Drawing.Point(621, 293);
            this.nombreUs.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.nombreUs.Name = "nombreUs";
            this.nombreUs.Size = new System.Drawing.Size(779, 55);
            this.nombreUs.TabIndex = 6;
            this.nombreUs.Text = "INFORMES DEL RESTAURANTE";
            // 
            // volverBtn
            // 
            this.volverBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volverBtn.BackgroundImage")));
            this.volverBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volverBtn.Location = new System.Drawing.Point(38, 54);
            this.volverBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(104, 88);
            this.volverBtn.TabIndex = 18;
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click_1);
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 700);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreUs);
            this.Controls.Add(this.PagarPedido);
            this.Controls.Add(this.verPedidoBtn);
            this.Controls.Add(this.hacerPedidoBtn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Informe";
            this.Text = "Informes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PagarPedido;
        private System.Windows.Forms.Button verPedidoBtn;
        private System.Windows.Forms.Button hacerPedidoBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombreUs;
        private System.Windows.Forms.Button volverBtn;
    }
}