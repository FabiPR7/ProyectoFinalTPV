namespace ProyectoFinalTPV
{
    partial class EditarOEliminarComida
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
            System.Windows.Forms.Label nombreLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.accionCategoriaTxt = new System.Windows.Forms.Label();
            this.restauranteTPVDataSet1 = new ProyectoFinalTPV.RestauranteTPVDataSet1();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.TableAdapterManager();
            this.nombreComboBox = new System.Windows.Forms.ComboBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.CategoriaTableAdapter();
            this.categriaComboBox = new System.Windows.Forms.ComboBox();
            this.precioLbl = new System.Windows.Forms.Label();
            this.categoriaNombre = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accionCategoriaTxt
            // 
            this.accionCategoriaTxt.AutoSize = true;
            this.accionCategoriaTxt.Location = new System.Drawing.Point(80, 74);
            this.accionCategoriaTxt.Name = "accionCategoriaTxt";
            this.accionCategoriaTxt.Size = new System.Drawing.Size(35, 13);
            this.accionCategoriaTxt.TabIndex = 12;
            this.accionCategoriaTxt.Text = "label2";
            // 
            // restauranteTPVDataSet1
            // 
            this.restauranteTPVDataSet1.DataSetName = "RestauranteTPVDataSet1";
            this.restauranteTPVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.restauranteTPVDataSet1;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.MesaTableAdapter = null;
            this.tableAdapterManager.MetodoPagoTableAdapter = null;
            this.tableAdapterManager.PedidoTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(46, 154);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 16;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreComboBox
            // 
            this.nombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Nombre", true));
            this.nombreComboBox.FormattingEnabled = true;
            this.nombreComboBox.Location = new System.Drawing.Point(114, 151);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(121, 21);
            this.nombreComboBox.TabIndex = 17;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(114, 178);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(121, 20);
            this.precioTextBox.TabIndex = 19;
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
            // categriaComboBox
            // 
            this.categriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Nombre", true));
            this.categriaComboBox.FormattingEnabled = true;
            this.categriaComboBox.Location = new System.Drawing.Point(114, 204);
            this.categriaComboBox.Name = "categriaComboBox";
            this.categriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.categriaComboBox.TabIndex = 20;
            // 
            // precioLbl
            // 
            this.precioLbl.AutoSize = true;
            this.precioLbl.Location = new System.Drawing.Point(49, 184);
            this.precioLbl.Name = "precioLbl";
            this.precioLbl.Size = new System.Drawing.Size(40, 13);
            this.precioLbl.TabIndex = 21;
            this.precioLbl.Text = "Precio:";
            // 
            // categoriaNombre
            // 
            this.categoriaNombre.AutoSize = true;
            this.categoriaNombre.Location = new System.Drawing.Point(52, 211);
            this.categoriaNombre.Name = "categoriaNombre";
            this.categoriaNombre.Size = new System.Drawing.Size(52, 13);
            this.categoriaNombre.TabIndex = 22;
            this.categoriaNombre.Text = "Categoria";
            // 
            // EditarOEliminarComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 335);
            this.Controls.Add(this.categoriaNombre);
            this.Controls.Add(this.precioLbl);
            this.Controls.Add(this.categriaComboBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreComboBox);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accionCategoriaTxt);
            this.Name = "EditarOEliminarComida";
            this.Text = "EditarOEliminarComida";
            this.Load += new System.EventHandler(this.EditarOEliminarComida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label accionCategoriaTxt;
        private RestauranteTPVDataSet1 restauranteTPVDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private RestauranteTPVDataSet1TableAdapters.ProductoTableAdapter productoTableAdapter;
        private RestauranteTPVDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nombreComboBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private RestauranteTPVDataSet1TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.ComboBox categriaComboBox;
        private System.Windows.Forms.Label precioLbl;
        private System.Windows.Forms.Label categoriaNombre;
    }
}