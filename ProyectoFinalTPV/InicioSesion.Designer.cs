namespace ProyectoFinalTPV
{
    partial class InicioSesion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.iniciarSesionBtn = new System.Windows.Forms.Button();
            this.crearCuentaBtn = new System.Windows.Forms.Button();
            this.nohaycuentasTXT = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // iniciarSesionBtn
            // 
            this.iniciarSesionBtn.Location = new System.Drawing.Point(275, 163);
            this.iniciarSesionBtn.Name = "iniciarSesionBtn";
            this.iniciarSesionBtn.Size = new System.Drawing.Size(166, 42);
            this.iniciarSesionBtn.TabIndex = 0;
            this.iniciarSesionBtn.Text = "INICIAR SESION";
            this.toolTip1.SetToolTip(this.iniciarSesionBtn, "Permite entrar a la ventana para elegir cuenta");
            this.iniciarSesionBtn.UseVisualStyleBackColor = true;
            this.iniciarSesionBtn.Click += new System.EventHandler(this.iniciarSesionBtn_Click);
            // 
            // crearCuentaBtn
            // 
            this.crearCuentaBtn.Enabled = false;
            this.crearCuentaBtn.Location = new System.Drawing.Point(275, 226);
            this.crearCuentaBtn.Name = "crearCuentaBtn";
            this.crearCuentaBtn.Size = new System.Drawing.Size(166, 40);
            this.crearCuentaBtn.TabIndex = 2;
            this.crearCuentaBtn.Text = "CREAR CUENTA";
            this.toolTip1.SetToolTip(this.crearCuentaBtn, "Permite agregar usuario, pero debes inicair sesion con un admin");
            this.crearCuentaBtn.UseVisualStyleBackColor = true;
            this.crearCuentaBtn.Click += new System.EventHandler(this.crearCuentaBtn_Click);
            // 
            // nohaycuentasTXT
            // 
            this.nohaycuentasTXT.AutoSize = true;
            this.nohaycuentasTXT.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nohaycuentasTXT.Location = new System.Drawing.Point(272, 269);
            this.nohaycuentasTXT.Name = "nohaycuentasTXT";
            this.nohaycuentasTXT.Size = new System.Drawing.Size(170, 14);
            this.nohaycuentasTXT.TabIndex = 3;
            this.nohaycuentasTXT.Text = "NO HAY CUENTAS REGISTRADAS";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 402);
            this.Controls.Add(this.nohaycuentasTXT);
            this.Controls.Add(this.crearCuentaBtn);
            this.Controls.Add(this.iniciarSesionBtn);
            this.Name = "InicioSesion";
            this.Text = "89";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniciarSesionBtn;
        private System.Windows.Forms.Button crearCuentaBtn;
        private System.Windows.Forms.Label nohaycuentasTXT;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}