namespace ProyectoFinalTPV
{
    partial class AgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEmpleado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aceptarAgregarEmpleadoBtn = new System.Windows.Forms.Button();
            this.nameAgregarEmpleadoTXT = new System.Windows.Forms.TextBox();
            this.restauranteTPVDataSet = new ProyectoFinalTPV.RestauranteTPVDataSet();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoAgregarEmpleadoTXT = new System.Windows.Forms.TextBox();
            this.rolesTableAdapter = new ProyectoFinalTPV.RestauranteTPVDataSetTableAdapters.RolesTableAdapter();
            this.tableAdapterManager = new ProyectoFinalTPV.RestauranteTPVDataSetTableAdapters.TableAdapterManager();
            this.rolAgregarEmpeladoTXT = new System.Windows.Forms.ComboBox();
            this.restauranteTPVDataSet1 = new ProyectoFinalTPV.RestauranteTPVDataSet();
            this.rolesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR EMPLEADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE COMPLETO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CODIGO:";
            // 
            // aceptarAgregarEmpleadoBtn
            // 
            this.aceptarAgregarEmpleadoBtn.Location = new System.Drawing.Point(238, 286);
            this.aceptarAgregarEmpleadoBtn.Name = "aceptarAgregarEmpleadoBtn";
            this.aceptarAgregarEmpleadoBtn.Size = new System.Drawing.Size(176, 39);
            this.aceptarAgregarEmpleadoBtn.TabIndex = 4;
            this.aceptarAgregarEmpleadoBtn.Text = "ACEPTAR";
            this.aceptarAgregarEmpleadoBtn.UseVisualStyleBackColor = true;
            this.aceptarAgregarEmpleadoBtn.Click += new System.EventHandler(this.aceptarAgregarEmpleadoBtn_Click);
            // 
            // nameAgregarEmpleadoTXT
            // 
            this.nameAgregarEmpleadoTXT.Location = new System.Drawing.Point(325, 123);
            this.nameAgregarEmpleadoTXT.Name = "nameAgregarEmpleadoTXT";
            this.nameAgregarEmpleadoTXT.Size = new System.Drawing.Size(100, 20);
            this.nameAgregarEmpleadoTXT.TabIndex = 5;
            // 
            // restauranteTPVDataSet
            // 
            this.restauranteTPVDataSet.DataSetName = "RestauranteTPVDataSet";
            this.restauranteTPVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.restauranteTPVDataSet;
            // 
            // codigoAgregarEmpleadoTXT
            // 
            this.codigoAgregarEmpleadoTXT.Location = new System.Drawing.Point(325, 186);
            this.codigoAgregarEmpleadoTXT.Name = "codigoAgregarEmpleadoTXT";
            this.codigoAgregarEmpleadoTXT.Size = new System.Drawing.Size(100, 20);
            this.codigoAgregarEmpleadoTXT.TabIndex = 9;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.MesaTableAdapter = null;
            this.tableAdapterManager.MetodoPagoTableAdapter = null;
            this.tableAdapterManager.PedidoTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = this.rolesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProyectoFinalTPV.RestauranteTPVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(287, 162);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(32, 13);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "ROL:";
            // 
            // rolAgregarEmpeladoTXT
            // 
            this.rolAgregarEmpeladoTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "Nombre", true));
            this.rolAgregarEmpeladoTXT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rolesBindingSource, "Nombre", true));
            this.rolAgregarEmpeladoTXT.DataSource = this.rolesBindingSource1;
            this.rolAgregarEmpeladoTXT.DisplayMember = "Nombre";
            this.rolAgregarEmpeladoTXT.FormattingEnabled = true;
            this.rolAgregarEmpeladoTXT.Location = new System.Drawing.Point(325, 159);
            this.rolAgregarEmpeladoTXT.Name = "rolAgregarEmpeladoTXT";
            this.rolAgregarEmpeladoTXT.Size = new System.Drawing.Size(100, 21);
            this.rolAgregarEmpeladoTXT.TabIndex = 10;
            this.rolAgregarEmpeladoTXT.ValueMember = "Nombre";
            // 
            // restauranteTPVDataSet1
            // 
            this.restauranteTPVDataSet1.DataSetName = "RestauranteTPVDataSet";
            this.restauranteTPVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesBindingSource1
            // 
            this.rolesBindingSource1.DataMember = "Roles";
            this.rolesBindingSource1.DataSource = this.restauranteTPVDataSet1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 402);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.rolAgregarEmpeladoTXT);
            this.Controls.Add(this.codigoAgregarEmpleadoTXT);
            this.Controls.Add(this.nameAgregarEmpleadoTXT);
            this.Controls.Add(this.aceptarAgregarEmpleadoBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "AgregarEmpleado";
            this.Text = "AgregarEmpleado";
            this.Load += new System.EventHandler(this.AgregarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteTPVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aceptarAgregarEmpleadoBtn;
        private System.Windows.Forms.TextBox nameAgregarEmpleadoTXT;
        private RestauranteTPVDataSet restauranteTPVDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.TextBox codigoAgregarEmpleadoTXT;
        private RestauranteTPVDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private RestauranteTPVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox rolAgregarEmpeladoTXT;
        private RestauranteTPVDataSet restauranteTPVDataSet1;
        private System.Windows.Forms.BindingSource rolesBindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}