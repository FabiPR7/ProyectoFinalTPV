namespace ProyectoFinalTPV
{
    partial class AdministrarCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarCuenta));
            this.nombreUs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cambiarUsBtn = new System.Windows.Forms.Button();
            this.cerrarSesionBtn = new System.Windows.Forms.Button();
            this.AgregarUsBtn = new System.Windows.Forms.Button();
            this.eliminarUsBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreUs
            // 
            this.nombreUs.AutoSize = true;
            this.nombreUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUs.Location = new System.Drawing.Point(67, 23);
            this.nombreUs.Name = "nombreUs";
            this.nombreUs.Size = new System.Drawing.Size(57, 20);
            this.nombreUs.TabIndex = 0;
            this.nombreUs.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMINISTRA CUENTA";
            // 
            // cambiarUsBtn
            // 
            this.cambiarUsBtn.Location = new System.Drawing.Point(269, 157);
            this.cambiarUsBtn.Name = "cambiarUsBtn";
            this.cambiarUsBtn.Size = new System.Drawing.Size(149, 37);
            this.cambiarUsBtn.TabIndex = 2;
            this.cambiarUsBtn.Text = "CAMBIAR USUARIO";
            this.cambiarUsBtn.UseVisualStyleBackColor = true;
            this.cambiarUsBtn.Click += new System.EventHandler(this.cambiarUsBtn_Click);
            // 
            // cerrarSesionBtn
            // 
            this.cerrarSesionBtn.Location = new System.Drawing.Point(269, 219);
            this.cerrarSesionBtn.Name = "cerrarSesionBtn";
            this.cerrarSesionBtn.Size = new System.Drawing.Size(149, 37);
            this.cerrarSesionBtn.TabIndex = 3;
            this.cerrarSesionBtn.Text = "CERRAR SESION";
            this.cerrarSesionBtn.UseVisualStyleBackColor = true;
            this.cerrarSesionBtn.Click += new System.EventHandler(this.cerrarSesionBtn_Click);
            // 
            // AgregarUsBtn
            // 
            this.AgregarUsBtn.Location = new System.Drawing.Point(269, 277);
            this.AgregarUsBtn.Name = "AgregarUsBtn";
            this.AgregarUsBtn.Size = new System.Drawing.Size(149, 37);
            this.AgregarUsBtn.TabIndex = 4;
            this.AgregarUsBtn.Text = "AGREGAR USUARIO";
            this.AgregarUsBtn.UseVisualStyleBackColor = true;
            this.AgregarUsBtn.Click += new System.EventHandler(this.AgregarUsBtn_Click);
            // 
            // eliminarUsBtn
            // 
            this.eliminarUsBtn.Location = new System.Drawing.Point(269, 338);
            this.eliminarUsBtn.Name = "eliminarUsBtn";
            this.eliminarUsBtn.Size = new System.Drawing.Size(149, 37);
            this.eliminarUsBtn.TabIndex = 5;
            this.eliminarUsBtn.Text = "ELIMINAR USUARIO";
            this.eliminarUsBtn.UseVisualStyleBackColor = true;
            this.eliminarUsBtn.Click += new System.EventHandler(this.eliminarUsBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volverBtn.BackgroundImage")));
            this.volverBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volverBtn.Location = new System.Drawing.Point(12, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(33, 31);
            this.volverBtn.TabIndex = 17;
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // AdministrarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 402);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.eliminarUsBtn);
            this.Controls.Add(this.AgregarUsBtn);
            this.Controls.Add(this.cerrarSesionBtn);
            this.Controls.Add(this.cambiarUsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreUs);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdministrarCuenta";
            this.Text = "AdministrarCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreUs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cambiarUsBtn;
        private System.Windows.Forms.Button cerrarSesionBtn;
        private System.Windows.Forms.Button AgregarUsBtn;
        private System.Windows.Forms.Button eliminarUsBtn;
        private System.Windows.Forms.Button volverBtn;
    }
}