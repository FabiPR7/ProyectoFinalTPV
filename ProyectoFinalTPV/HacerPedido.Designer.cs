namespace ProyectoFinalTPV
{
    partial class HacerPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HacerPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteTPVDataSet = new ProyectoFinalTPV.RestauranteTPVDataSet();
            this.productoTableAdapter = new ProyectoFinalTPV.RestauranteTPVDataSetTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new ProyectoFinalTPV.RestauranteTPVDataSetTableAdapters.TableAdapterManager();
            this.layaoutPanelCategoria = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.restauranteTPVDataSet1 = new ProyectoFinalTPV.RestauranteTPVDataSet1();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager1 = new ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.TableAdapterManager();
            this.nombreComboBox = new System.Windows.Forms.ComboBox();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombreLabel.Location = new System.Drawing.Point(51, 64);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorias";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.restauranteTPVDataSet;
            // 
            // restauranteTPVDataSet
            // 
            this.restauranteTPVDataSet.DataSetName = "RestauranteTPVDataSet";
            this.restauranteTPVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.MesaTableAdapter = null;
            this.tableAdapterManager.MetodoPagoTableAdapter = null;
            this.tableAdapterManager.PedidoTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinalTPV.RestauranteTPVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // layaoutPanelCategoria
            // 
            this.layaoutPanelCategoria.AutoScroll = true;
            this.layaoutPanelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.layaoutPanelCategoria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.layaoutPanelCategoria.Location = new System.Drawing.Point(12, 107);
            this.layaoutPanelCategoria.Name = "layaoutPanelCategoria";
            this.layaoutPanelCategoria.Size = new System.Drawing.Size(644, 283);
            this.layaoutPanelCategoria.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // restauranteTPVDataSet1
            // 
            this.restauranteTPVDataSet1.DataSetName = "RestauranteTPVDataSet1";
            this.restauranteTPVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager1.MesaTableAdapter = null;
            this.tableAdapterManager1.MetodoPagoTableAdapter = null;
            this.tableAdapterManager1.PedidoTableAdapter = null;
            this.tableAdapterManager1.ProductoTableAdapter = null;
            this.tableAdapterManager1.RolesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsuarioTableAdapter = null;
            // 
            // nombreComboBox
            // 
            this.nombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Nombre", true));
            this.nombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.restauranteTPVDataSet1, "Categoria.Nombre", true));
            this.nombreComboBox.DataSource = this.restauranteTPVDataSet1;
            this.nombreComboBox.DisplayMember = "Categoria.Nombre";
            this.nombreComboBox.FormattingEnabled = true;
            this.nombreComboBox.Location = new System.Drawing.Point(104, 61);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(121, 21);
            this.nombreComboBox.TabIndex = 5;
            this.nombreComboBox.ValueMember = "Categoria.Nombre";
            this.nombreComboBox.SelectedValueChanged += new System.EventHandler(this.nombreComboBox_SelectedValueChanged);
            // 
            // HacerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 410);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.layaoutPanelCategoria);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "HacerPedido";
            this.Text = "HacerPedido";
            this.Load += new System.EventHandler(this.HacerPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RestauranteTPVDataSet restauranteTPVDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private RestauranteTPVDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private RestauranteTPVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.FlowLayoutPanel layaoutPanelCategoria;
        private System.Windows.Forms.Button button1;
        private RestauranteTPVDataSet1 restauranteTPVDataSet1;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private RestauranteTPVDataSet1TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private RestauranteTPVDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox nombreComboBox;
    }
}