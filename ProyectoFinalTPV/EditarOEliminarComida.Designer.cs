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
            System.Windows.Forms.Label nombreLabel1;
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.accionTxt = new System.Windows.Forms.Label();
            this.restauranteTPVDataSet1 = new ProyectoFinalTPV.RestauranteTPVDataSet1();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.TableAdapterManager();
            this.categoriaTableAdapter = new ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.CategoriaTableAdapter();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categriaComboBox = new System.Windows.Forms.ComboBox();
            this.precioLbl = new System.Windows.Forms.Label();
            this.categoriaNombre = new System.Windows.Forms.Label();
            this.nombeAcambiarText = new System.Windows.Forms.ComboBox();
            this.cambiarAText = new System.Windows.Forms.Label();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.categoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Location = new System.Drawing.Point(38, 116);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(47, 13);
            nombreLabel1.TabIndex = 22;
            nombreLabel1.Text = "Nombre:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accionTxt
            // 
            this.accionTxt.AutoSize = true;
            this.accionTxt.Location = new System.Drawing.Point(113, 65);
            this.accionTxt.Name = "accionTxt";
            this.accionTxt.Size = new System.Drawing.Size(35, 13);
            this.accionTxt.TabIndex = 12;
            this.accionTxt.Text = "label2";
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
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(100, 216);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(121, 20);
            this.precioTextBox.TabIndex = 19;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.restauranteTPVDataSet1;
            // 
            // categriaComboBox
            // 
            this.categriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Nombre", true));
            this.categriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriaBindingSource2, "Nombre", true));
            this.categriaComboBox.DataSource = this.categoriaBindingSource1;
            this.categriaComboBox.DisplayMember = "Nombre";
            this.categriaComboBox.FormattingEnabled = true;
            this.categriaComboBox.Location = new System.Drawing.Point(100, 242);
            this.categriaComboBox.Name = "categriaComboBox";
            this.categriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.categriaComboBox.TabIndex = 20;
            this.categriaComboBox.ValueMember = "Nombre";
            // 
            // precioLbl
            // 
            this.precioLbl.AutoSize = true;
            this.precioLbl.Location = new System.Drawing.Point(39, 223);
            this.precioLbl.Name = "precioLbl";
            this.precioLbl.Size = new System.Drawing.Size(40, 13);
            this.precioLbl.TabIndex = 21;
            this.precioLbl.Text = "Precio:";
            // 
            // categoriaNombre
            // 
            this.categoriaNombre.AutoSize = true;
            this.categoriaNombre.Location = new System.Drawing.Point(38, 249);
            this.categoriaNombre.Name = "categoriaNombre";
            this.categoriaNombre.Size = new System.Drawing.Size(52, 13);
            this.categoriaNombre.TabIndex = 22;
            this.categoriaNombre.Text = "Categoria";
            // 
            // nombeAcambiarText
            // 
            this.nombeAcambiarText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Nombre", true));
            this.nombeAcambiarText.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource2, "Nombre", true));
            this.nombeAcambiarText.DataSource = this.productoBindingSource1;
            this.nombeAcambiarText.DisplayMember = "Nombre";
            this.nombeAcambiarText.FormattingEnabled = true;
            this.nombeAcambiarText.Location = new System.Drawing.Point(91, 108);
            this.nombeAcambiarText.Name = "nombeAcambiarText";
            this.nombeAcambiarText.Size = new System.Drawing.Size(121, 21);
            this.nombeAcambiarText.TabIndex = 23;
            this.nombeAcambiarText.ValueMember = "Nombre";
            // 
            // cambiarAText
            // 
            this.cambiarAText.AutoSize = true;
            this.cambiarAText.Location = new System.Drawing.Point(93, 150);
            this.cambiarAText.Name = "cambiarAText";
            this.cambiarAText.Size = new System.Drawing.Size(56, 13);
            this.cambiarAText.TabIndex = 24;
            this.cambiarAText.Text = "cambiar a:";
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "Producto";
            this.productoBindingSource1.DataSource = this.restauranteTPVDataSet1;
            // 
            // productoBindingSource2
            // 
            this.productoBindingSource2.DataMember = "Producto";
            this.productoBindingSource2.DataSource = this.restauranteTPVDataSet1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 25;
            // 
            // categoriaBindingSource1
            // 
            this.categoriaBindingSource1.DataMember = "Categoria";
            this.categoriaBindingSource1.DataSource = this.restauranteTPVDataSet1;
            // 
            // categoriaBindingSource2
            // 
            this.categoriaBindingSource2.DataMember = "Categoria";
            this.categoriaBindingSource2.DataSource = this.restauranteTPVDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre:";
            // 
            // EditarOEliminarComida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cambiarAText);
            this.Controls.Add(nombreLabel1);
            this.Controls.Add(this.nombeAcambiarText);
            this.Controls.Add(this.categoriaNombre);
            this.Controls.Add(this.precioLbl);
            this.Controls.Add(this.categriaComboBox);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accionTxt);
            this.Name = "EditarOEliminarComida";
            this.Text = "EditarOEliminarComida";
            this.Load += new System.EventHandler(this.EditarOEliminarComida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label accionTxt;
        private RestauranteTPVDataSet1 restauranteTPVDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private RestauranteTPVDataSet1TableAdapters.ProductoTableAdapter productoTableAdapter;
        private RestauranteTPVDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox precioTextBox;
        private RestauranteTPVDataSet1TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.ComboBox categriaComboBox;
        private System.Windows.Forms.Label precioLbl;
        private System.Windows.Forms.Label categoriaNombre;
        private System.Windows.Forms.ComboBox nombeAcambiarText;
        private System.Windows.Forms.Label cambiarAText;
        private System.Windows.Forms.BindingSource productoBindingSource2;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private System.Windows.Forms.BindingSource categoriaBindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource categoriaBindingSource2;
        private System.Windows.Forms.Label label1;
    }
}