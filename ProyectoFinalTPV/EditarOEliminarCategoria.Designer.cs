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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreCategoria;
            this.nombreComboBox = new System.Windows.Forms.ComboBox();
            this.restauranteTPVDataSet1 = new ProyectoFinalTPV.RestauranteTPVDataSet1();
            this.categoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cambiarCategoriaTXT = new System.Windows.Forms.Label();
            this.cambiarCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.accionCategoriaTxt = new System.Windows.Forms.Label();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.CategoriaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nombreCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
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
            // nombreComboBox
            // 
            this.nombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.restauranteTPVDataSet1, "Categoria.Nombre", true));
            this.nombreComboBox.DataSource = this.categoriaBindingSource1;
            this.nombreComboBox.DisplayMember = "Nombre";
            this.nombreComboBox.FormattingEnabled = true;
            this.nombreComboBox.Location = new System.Drawing.Point(75, 128);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(121, 21);
            this.nombreComboBox.TabIndex = 2;
            this.nombreComboBox.ValueMember = "Nombre";
            // 
            // restauranteTPVDataSet1
            // 
            this.restauranteTPVDataSet1.DataSetName = "RestauranteTPVDataSet1";
            this.restauranteTPVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource1
            // 
            this.categoriaBindingSource1.DataMember = "Categoria";
            this.categoriaBindingSource1.DataSource = this.restauranteTPVDataSet1;
            // 
            // cambiarCategoriaTXT
            // 
            this.cambiarCategoriaTXT.AutoSize = true;
            this.cambiarCategoriaTXT.Location = new System.Drawing.Point(10, 180);
            this.cambiarCategoriaTXT.Name = "cambiarCategoriaTXT";
            this.cambiarCategoriaTXT.Size = new System.Drawing.Size(59, 13);
            this.cambiarCategoriaTXT.TabIndex = 3;
            this.cambiarCategoriaTXT.Text = "cambiar a :";
            this.cambiarCategoriaTXT.Click += new System.EventHandler(this.cambiarCategoriaTXT_Click);
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
            this.accionCategoriaTxt.Location = new System.Drawing.Point(84, 67);
            this.accionCategoriaTxt.Name = "accionCategoriaTxt";
            this.accionCategoriaTxt.Size = new System.Drawing.Size(35, 13);
            this.accionCategoriaTxt.TabIndex = 5;
            this.accionCategoriaTxt.Text = "label2";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.restauranteTPVDataSet1;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditarOEliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 335);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accionCategoriaTxt);
            this.Controls.Add(this.cambiarCategoriaTextBox);
            this.Controls.Add(this.cambiarCategoriaTXT);
            this.Controls.Add(nombreCategoria);
            this.Controls.Add(this.nombreComboBox);
            this.Name = "EditarOEliminarCategoria";
            this.Text = " ";
            this.Load += new System.EventHandler(this.EditarOEliminarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox nombreComboBox;
        private System.Windows.Forms.Label cambiarCategoriaTXT;
        private System.Windows.Forms.TextBox cambiarCategoriaTextBox;
        private System.Windows.Forms.Label accionCategoriaTxt;
        private RestauranteTPVDataSet1 restauranteTPVDataSet1;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private RestauranteTPVDataSet1TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}