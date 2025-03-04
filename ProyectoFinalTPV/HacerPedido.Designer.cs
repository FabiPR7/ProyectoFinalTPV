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
            this.volverBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.precioAcumuladolbl = new System.Windows.Forms.Label();
            this.listpedidos = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.numeroMesa = new System.Windows.Forms.NumericUpDown();
            this.nMesa = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombreLabel.Location = new System.Drawing.Point(66, 40);
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
            this.label1.Location = new System.Drawing.Point(115, 14);
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
            this.layaoutPanelCategoria.Location = new System.Drawing.Point(20, 64);
            this.layaoutPanelCategoria.Name = "layaoutPanelCategoria";
            this.layaoutPanelCategoria.Size = new System.Drawing.Size(330, 283);
            this.layaoutPanelCategoria.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ajustes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.nombreComboBox.Location = new System.Drawing.Point(119, 37);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(121, 21);
            this.nombreComboBox.TabIndex = 5;
            this.nombreComboBox.ValueMember = "Categoria.Nombre";
            this.nombreComboBox.SelectedValueChanged += new System.EventHandler(this.nombreComboBox_SelectedValueChanged);
            // 
            // volverBtn
            // 
            this.volverBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volverBtn.BackgroundImage")));
            this.volverBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volverBtn.Location = new System.Drawing.Point(12, 14);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(33, 31);
            this.volverBtn.TabIndex = 17;
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.precioAcumuladolbl);
            this.panel1.Location = new System.Drawing.Point(20, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 53);
            this.panel1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1;
            // 
            // precioAcumuladolbl
            // 
            this.precioAcumuladolbl.AutoSize = true;
            this.precioAcumuladolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioAcumuladolbl.Location = new System.Drawing.Point(500, 19);
            this.precioAcumuladolbl.Name = "precioAcumuladolbl";
            this.precioAcumuladolbl.Size = new System.Drawing.Size(62, 29);
            this.precioAcumuladolbl.TabIndex = 0;
            this.precioAcumuladolbl.Text = "0.00";
            // 
            // listpedidos
            // 
            this.listpedidos.FormattingEnabled = true;
            this.listpedidos.Location = new System.Drawing.Point(429, 70);
            this.listpedidos.Name = "listpedidos";
            this.listpedidos.Size = new System.Drawing.Size(235, 277);
            this.listpedidos.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 31);
            this.button2.TabIndex = 21;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(387, 102);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 41);
            this.button3.TabIndex = 23;
            this.button3.Text = "Eliminar Todo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numeroMesa
            // 
            this.numeroMesa.Location = new System.Drawing.Point(406, 38);
            this.numeroMesa.Name = "numeroMesa";
            this.numeroMesa.Size = new System.Drawing.Size(120, 20);
            this.numeroMesa.TabIndex = 24;
            // 
            // nMesa
            // 
            this.nMesa.AutoSize = true;
            this.nMesa.BackColor = System.Drawing.Color.Transparent;
            this.nMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMesa.ForeColor = System.Drawing.Color.Snow;
            this.nMesa.Location = new System.Drawing.Point(402, 11);
            this.nMesa.Name = "nMesa";
            this.nMesa.Size = new System.Drawing.Size(76, 20);
            this.nMesa.TabIndex = 25;
            this.nMesa.Text = "Nº Mesa";
            this.nMesa.Click += new System.EventHandler(this.label5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(356, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 31);
            this.button4.TabIndex = 26;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // HacerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 410);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.nMesa);
            this.Controls.Add(this.numeroMesa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listpedidos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.volverBtn);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroMesa)).EndInit();
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
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listpedidos;
        private System.Windows.Forms.Label precioAcumuladolbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numeroMesa;
        private System.Windows.Forms.Label nMesa;
        private System.Windows.Forms.Button button4;
    }
}