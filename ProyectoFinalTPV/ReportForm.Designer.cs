namespace ProyectoFinalTPV
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeComidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noPagadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 24);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(668, 378);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.comidasToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // comidasToolStripMenuItem
            // 
            this.comidasToolStripMenuItem.Name = "comidasToolStripMenuItem";
            this.comidasToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.comidasToolStripMenuItem.Text = "Comidas";
            this.comidasToolStripMenuItem.Click += new System.EventHandler(this.comidasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comidaToolStripMenuItem,
            this.usuariosToolStripMenuItem1,
            this.pedidosToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 70);
            // 
            // comidaToolStripMenuItem
            // 
            this.comidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem,
            this.ventaDeComidasToolStripMenuItem,
            this.buscaPorCategoriaToolStripMenuItem});
            this.comidaToolStripMenuItem.Name = "comidaToolStripMenuItem";
            this.comidaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.comidaToolStripMenuItem.Text = "Comida";
            this.comidaToolStripMenuItem.Click += new System.EventHandler(this.comidaToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // ventaDeComidasToolStripMenuItem
            // 
            this.ventaDeComidasToolStripMenuItem.Name = "ventaDeComidasToolStripMenuItem";
            this.ventaDeComidasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventaDeComidasToolStripMenuItem.Text = "Venta de Comidas";
            this.ventaDeComidasToolStripMenuItem.Click += new System.EventHandler(this.ventaDeComidasToolStripMenuItem_Click);
            // 
            // buscaPorCategoriaToolStripMenuItem
            // 
            this.buscaPorCategoriaToolStripMenuItem.Name = "buscaPorCategoriaToolStripMenuItem";
            this.buscaPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscaPorCategoriaToolStripMenuItem.Text = "Busca por Categoria";
            this.buscaPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.buscaPorCategoriaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem1,
            this.adminToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // todosToolStripMenuItem1
            // 
            this.todosToolStripMenuItem1.Name = "todosToolStripMenuItem1";
            this.todosToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.todosToolStripMenuItem1.Text = "Todos";
            this.todosToolStripMenuItem1.Click += new System.EventHandler(this.todosToolStripMenuItem1_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem1
            // 
            this.pedidosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem2,
            this.pagadosToolStripMenuItem,
            this.noPagadosToolStripMenuItem});
            this.pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            this.pedidosToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.pedidosToolStripMenuItem1.Text = "Pedidos";
            // 
            // todosToolStripMenuItem2
            // 
            this.todosToolStripMenuItem2.Name = "todosToolStripMenuItem2";
            this.todosToolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.todosToolStripMenuItem2.Text = "Todos";
            this.todosToolStripMenuItem2.Click += new System.EventHandler(this.todosToolStripMenuItem2_Click);
            // 
            // pagadosToolStripMenuItem
            // 
            this.pagadosToolStripMenuItem.Name = "pagadosToolStripMenuItem";
            this.pagadosToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pagadosToolStripMenuItem.Text = "Pagados";
            this.pagadosToolStripMenuItem.Click += new System.EventHandler(this.pagadosToolStripMenuItem_Click);
            // 
            // noPagadosToolStripMenuItem
            // 
            this.noPagadosToolStripMenuItem.Name = "noPagadosToolStripMenuItem";
            this.noPagadosToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.noPagadosToolStripMenuItem.Text = "No Pagados";
            this.noPagadosToolStripMenuItem.Click += new System.EventHandler(this.noPagadosToolStripMenuItem_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 402);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeComidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem buscaPorCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noPagadosToolStripMenuItem;
    }
}