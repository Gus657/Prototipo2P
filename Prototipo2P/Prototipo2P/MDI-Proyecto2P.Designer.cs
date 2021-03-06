﻿namespace Prototipo2P
{
	partial class MDI_Proyecto2P
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Proyecto2P));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.lbl_usuario = new System.Windows.Forms.Label();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.catalogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(632, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printSetupToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
			this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(60, 20);
			this.fileMenu.Text = "&Archivo";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.newToolStripMenuItem.Text = "&Nuevo";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.openToolStripMenuItem.Text = "&Abrir";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.saveToolStripMenuItem.Text = "&Guardar";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.saveAsToolStripMenuItem.Text = "Guardar &como";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(203, 6);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
			this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.printToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.printToolStripMenuItem.Text = "&Imprimir";
			// 
			// printPreviewToolStripMenuItem
			// 
			this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
			this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
			this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
			this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.printPreviewToolStripMenuItem.Text = "&Vista previa de impresión";
			// 
			// printSetupToolStripMenuItem
			// 
			this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
			this.printSetupToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.printSetupToolStripMenuItem.Text = "Configurar impresión";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(203, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.exitToolStripMenuItem.Text = "&Salir";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
			// 
			// catalogosToolStripMenuItem
			// 
			this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.bodegasToolStripMenuItem,
            this.productosToolStripMenuItem});
			this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
			this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.catalogosToolStripMenuItem.Text = "Catalogos";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.clientesToolStripMenuItem.Text = "Clientes";
			this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
			// 
			// proveedoresToolStripMenuItem
			// 
			this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
			this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.proveedoresToolStripMenuItem.Text = "Marca";
			this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.ProveedoresToolStripMenuItem_Click);
			// 
			// bodegasToolStripMenuItem
			// 
			this.bodegasToolStripMenuItem.Name = "bodegasToolStripMenuItem";
			this.bodegasToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.bodegasToolStripMenuItem.Text = "Linea";
			this.bodegasToolStripMenuItem.Click += new System.EventHandler(this.BodegasToolStripMenuItem_Click);
			// 
			// productosToolStripMenuItem
			// 
			this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
			this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.productosToolStripMenuItem.Text = "Productos";
			this.productosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
			// 
			// procesosToolStripMenuItem
			// 
			this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem});
			this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
			this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.procesosToolStripMenuItem.Text = "Procesos";
			// 
			// facturacionToolStripMenuItem
			// 
			this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
			this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.facturacionToolStripMenuItem.Text = "Facturación";
			this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.FacturacionToolStripMenuItem_Click);
			// 
			// informesToolStripMenuItem
			// 
			this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
			this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.informesToolStripMenuItem.Text = "Informes";
			// 
			// herramientasToolStripMenuItem
			// 
			this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem});
			this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
			this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.herramientasToolStripMenuItem.Text = "Herramientas";
			// 
			// seguridadToolStripMenuItem
			// 
			this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
			this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.seguridadToolStripMenuItem.Text = "Seguridad";
			this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.SeguridadToolStripMenuItem_Click);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// lbl_usuario
			// 
			this.lbl_usuario.AutoSize = true;
			this.lbl_usuario.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lbl_usuario.Location = new System.Drawing.Point(0, 440);
			this.lbl_usuario.Name = "lbl_usuario";
			this.lbl_usuario.Size = new System.Drawing.Size(26, 13);
			this.lbl_usuario.TabIndex = 2;
			this.lbl_usuario.Text = "Gus";
			// 
			// MDI_Proyecto2P
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.Add(this.lbl_usuario);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MDI_Proyecto2P";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "0901-16-420 - Gustavo Perez";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MDI_Proyecto2P_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion


		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileMenu;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label lbl_usuario;
		private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bodegasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
	}
}



