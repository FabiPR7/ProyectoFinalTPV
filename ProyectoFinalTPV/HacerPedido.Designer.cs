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
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HacerPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.layaoutPanelCategoria = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreCategoriaComboBox = new System.Windows.Forms.ComboBox();
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
            this.nMesa = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboNumeroMesa = new System.Windows.Forms.ComboBox();
            nombreLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nombreLabel.Location = new System.Drawing.Point(209, 114);
            nombreLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(141, 37);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(364, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorias";
            // 
            // layaoutPanelCategoria
            // 
            this.layaoutPanelCategoria.AutoScroll = true;
            this.layaoutPanelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.layaoutPanelCategoria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.layaoutPanelCategoria.Location = new System.Drawing.Point(63, 182);
            this.layaoutPanelCategoria.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.layaoutPanelCategoria.Name = "layaoutPanelCategoria";
            this.layaoutPanelCategoria.Size = new System.Drawing.Size(1045, 805);
            this.layaoutPanelCategoria.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1913, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 94);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ajustes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreCategoriaComboBox
            // 
            this.nombreCategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombreCategoriaComboBox.FormattingEnabled = true;
            this.nombreCategoriaComboBox.Location = new System.Drawing.Point(377, 105);
            this.nombreCategoriaComboBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.nombreCategoriaComboBox.Name = "nombreCategoriaComboBox";
            this.nombreCategoriaComboBox.Size = new System.Drawing.Size(374, 45);
            this.nombreCategoriaComboBox.TabIndex = 5;
            this.nombreCategoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.nombreCategoriaComboBox_SelectedIndexChanged);
            this.nombreCategoriaComboBox.SelectedValueChanged += new System.EventHandler(this.nombreComboBox_SelectedValueChanged);
            // 
            // volverBtn
            // 
            this.volverBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volverBtn.BackgroundImage")));
            this.volverBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volverBtn.Location = new System.Drawing.Point(38, 40);
            this.volverBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(104, 88);
            this.volverBtn.TabIndex = 17;
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 1025);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.precioAcumuladolbl);
            this.panel1.Location = new System.Drawing.Point(63, 1005);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2039, 151);
            this.panel1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1834, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 82);
            this.label4.TabIndex = 2;
            this.label4.Text = "€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1662, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 37);
            this.label3.TabIndex = 1;
            // 
            // precioAcumuladolbl
            // 
            this.precioAcumuladolbl.AutoSize = true;
            this.precioAcumuladolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioAcumuladolbl.Location = new System.Drawing.Point(1583, 54);
            this.precioAcumuladolbl.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.precioAcumuladolbl.Name = "precioAcumuladolbl";
            this.precioAcumuladolbl.Size = new System.Drawing.Size(179, 82);
            this.precioAcumuladolbl.TabIndex = 0;
            this.precioAcumuladolbl.Text = "0.00";
            // 
            // listpedidos
            // 
            this.listpedidos.FormattingEnabled = true;
            this.listpedidos.ItemHeight = 37;
            this.listpedidos.Location = new System.Drawing.Point(1358, 199);
            this.listpedidos.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.listpedidos.Name = "listpedidos";
            this.listpedidos.Size = new System.Drawing.Size(736, 781);
            this.listpedidos.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1127, 225);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 88);
            this.button2.TabIndex = 21;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1226, 290);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(17, 4);
            this.checkedListBox1.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1127, 495);
            this.button3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 117);
            this.button3.TabIndex = 23;
            this.button3.Text = "Eliminar Todo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nMesa
            // 
            this.nMesa.AutoSize = true;
            this.nMesa.BackColor = System.Drawing.Color.Transparent;
            this.nMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMesa.ForeColor = System.Drawing.Color.Snow;
            this.nMesa.Location = new System.Drawing.Point(1273, 31);
            this.nMesa.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.nMesa.Name = "nMesa";
            this.nMesa.Size = new System.Drawing.Size(215, 55);
            this.nMesa.TabIndex = 25;
            this.nMesa.Text = "Nº Mesa";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1127, 768);
            this.button4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 88);
            this.button4.TabIndex = 26;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboNumeroMesa
            // 
            this.comboNumeroMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNumeroMesa.FormattingEnabled = true;
            this.comboNumeroMesa.Location = new System.Drawing.Point(1262, 125);
            this.comboNumeroMesa.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.comboNumeroMesa.Name = "comboNumeroMesa";
            this.comboNumeroMesa.Size = new System.Drawing.Size(374, 45);
            this.comboNumeroMesa.TabIndex = 27;
            // 
            // HacerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2141, 1167);
            this.Controls.Add(this.comboNumeroMesa);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.nMesa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listpedidos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreCategoriaComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.layaoutPanelCategoria);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "HacerPedido";
            this.Text = "HacerPedido";
            this.Load += new System.EventHandler(this.HacerPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel layaoutPanelCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox nombreCategoriaComboBox;
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
        private System.Windows.Forms.Label nMesa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboNumeroMesa;
    }
}