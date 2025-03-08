namespace ProyectoFinalTPV
{
    partial class VerPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPedidos));
            this.restauranteTPVDataSet1 = new ProyectoFinalTPV.RestauranteTPVDataSet1();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.PedidoTableAdapter();
            this.tableAdapterManager = new ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.TableAdapterManager();
            this.categoriaTableAdapter = new ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.CategoriaTableAdapter();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombreUs = new System.Windows.Forms.Label();
            this.volverBtn = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // restauranteTPVDataSet1
            // 
            this.restauranteTPVDataSet1.DataSetName = "RestauranteTPVDataSet1";
            this.restauranteTPVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.restauranteTPVDataSet1;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.MesaTableAdapter = null;
            this.tableAdapterManager.MetodoPagoTableAdapter = null;
            this.tableAdapterManager.PedidoTableAdapter = this.pedidoTableAdapter;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinalTPV.RestauranteTPVDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.restauranteTPVDataSet1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(74, 419);
            this.listView1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1983, 667);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mesa";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 163;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 154;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pagado";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 221;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(48, 54);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(199, 41);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ver todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1431, 54);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(236, 41);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No pagados";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(776, 54);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(188, 41);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pagados";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton3_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(86, 208);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Size = new System.Drawing.Size(1919, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // nombreUs
            // 
            this.nombreUs.AutoSize = true;
            this.nombreUs.BackColor = System.Drawing.Color.Transparent;
            this.nombreUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombreUs.Location = new System.Drawing.Point(104, 142);
            this.nombreUs.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.nombreUs.Name = "nombreUs";
            this.nombreUs.Size = new System.Drawing.Size(363, 55);
            this.nombreUs.TabIndex = 4;
            this.nombreUs.Text = "VER PEDIDOS";
            // 
            // volverBtn
            // 
            this.volverBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volverBtn.BackgroundImage")));
            this.volverBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volverBtn.Location = new System.Drawing.Point(38, 46);
            this.volverBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(104, 88);
            this.volverBtn.TabIndex = 18;
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 334;
            // 
            // VerPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2115, 1144);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.nombreUs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.Name = "VerPedidos";
            this.Text = "VerPedidos";
            this.Load += new System.EventHandler(this.VerPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RestauranteTPVDataSet1 restauranteTPVDataSet1;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private RestauranteTPVDataSet1TableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private RestauranteTPVDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private RestauranteTPVDataSet1TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nombreUs;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.ColumnHeader ID;
    }
}