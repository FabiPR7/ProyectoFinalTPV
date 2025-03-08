namespace ProyectoFinalTPV
{
    partial class EditarOEliminarCategoria
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
            System.Windows.Forms.Label nombreCategoria;
            this.nombreCategoriaBox = new System.Windows.Forms.ComboBox();
            this.cambiarCategoriaTXT = new System.Windows.Forms.Label();
            this.cambiarCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.accionCategoriaTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nombreCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreCategoria
            // 
            nombreCategoria.AutoSize = true;
            nombreCategoria.Location = new System.Drawing.Point(22, 131);
            nombreCategoria.Name = "nombreCategoria";
            nombreCategoria.Size = new System.Drawing.Size(47, 13);
            nombreCategoria.TabIndex = 1;
            nombreCategoria.Text = "Nombre:";
            // 
            // nombreCategoriaBox
            // 
            this.nombreCategoriaBox.FormattingEnabled = true;
            this.nombreCategoriaBox.Location = new System.Drawing.Point(75, 128);
            this.nombreCategoriaBox.Name = "nombreCategoriaBox";
            this.nombreCategoriaBox.Size = new System.Drawing.Size(121, 21);
            this.nombreCategoriaBox.TabIndex = 2;
            // 
            // cambiarCategoriaTXT
            // 
            this.cambiarCategoriaTXT.AutoSize = true;
            this.cambiarCategoriaTXT.Location = new System.Drawing.Point(10, 180);
            this.cambiarCategoriaTXT.Name = "cambiarCategoriaTXT";
            this.cambiarCategoriaTXT.Size = new System.Drawing.Size(59, 13);
            this.cambiarCategoriaTXT.TabIndex = 3;
            this.cambiarCategoriaTXT.Text = "cambiar a :";
            // 
            // cambiarCategoriaTextBox
            // 
            this.cambiarCategoriaTextBox.Location = new System.Drawing.Point(75, 177);
            this.cambiarCategoriaTextBox.Name = "cambiarCategoriaTextBox";
            this.cambiarCategoriaTextBox.Size = new System.Drawing.Size(146, 20);
            this.cambiarCategoriaTextBox.TabIndex = 4;
            // 
            // accionCategoriaTxt
            // 
            this.accionCategoriaTxt.AutoSize = true;
            this.accionCategoriaTxt.Location = new System.Drawing.Point(107, 67);
            this.accionCategoriaTxt.Name = "accionCategoriaTxt";
            this.accionCategoriaTxt.Size = new System.Drawing.Size(35, 13);
            this.accionCategoriaTxt.TabIndex = 5;
            this.accionCategoriaTxt.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditarOEliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 293);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accionCategoriaTxt);
            this.Controls.Add(this.cambiarCategoriaTextBox);
            this.Controls.Add(this.cambiarCategoriaTXT);
            this.Controls.Add(nombreCategoria);
            this.Controls.Add(this.nombreCategoriaBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditarOEliminarCategoria";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox nombreCategoriaBox;
        private System.Windows.Forms.Label cambiarCategoriaTXT;
        private System.Windows.Forms.TextBox cambiarCategoriaTextBox;
        private System.Windows.Forms.Label accionCategoriaTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}