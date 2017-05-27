namespace El_Buen_Precio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.registarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuidoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.realizarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaFacturadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodProximosAVencerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodMenosExistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodMasMovidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDelMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasDelMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vencidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexPorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repProductosVencidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registarToolStripMenuItem
            // 
            this.registarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.entradasProductoToolStripMenuItem});
            this.registarToolStripMenuItem.Name = "registarToolStripMenuItem";
            this.registarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.registarToolStripMenuItem.Text = "Registar";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // entradasProductoToolStripMenuItem
            // 
            this.entradasProductoToolStripMenuItem.Name = "entradasProductoToolStripMenuItem";
            this.entradasProductoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.entradasProductoToolStripMenuItem.Text = "Compras";
            this.entradasProductoToolStripMenuItem.Click += new System.EventHandler(this.entradasProductoToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.distribuidoraToolStripMenuItem1});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.verToolStripMenuItem.Text = "Agregar";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // distribuidoraToolStripMenuItem1
            // 
            this.distribuidoraToolStripMenuItem1.Name = "distribuidoraToolStripMenuItem1";
            this.distribuidoraToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.distribuidoraToolStripMenuItem1.Text = "Distribuidora";
            this.distribuidoraToolStripMenuItem1.Click += new System.EventHandler(this.distribuidoraToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVentasToolStripMenuItem,
            this.registarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.productoToolStripMenuItem1,
            this.proveedorToolStripMenuItem1,
            this.verInventarioToolStripMenuItem,
            this.descuentosToolStripMenuItem1,
            this.imprimirToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // realizarVentasToolStripMenuItem
            // 
            this.realizarVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaFacturadaToolStripMenuItem});
            this.realizarVentasToolStripMenuItem.Name = "realizarVentasToolStripMenuItem";
            this.realizarVentasToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.realizarVentasToolStripMenuItem.Text = "Realizar Ventas";
            // 
            // ventaFacturadaToolStripMenuItem
            // 
            this.ventaFacturadaToolStripMenuItem.Name = "ventaFacturadaToolStripMenuItem";
            this.ventaFacturadaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ventaFacturadaToolStripMenuItem.Text = "Venta Facturada";
            this.ventaFacturadaToolStripMenuItem.Click += new System.EventHandler(this.ventaFacturadaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prodProximosAVencerToolStripMenuItem,
            this.prodMenosExistenciasToolStripMenuItem,
            this.prodMasMovidosToolStripMenuItem,
            this.ventasDelMesToolStripMenuItem,
            this.comprasDelMesToolStripMenuItem,
            this.descuentosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // prodProximosAVencerToolStripMenuItem
            // 
            this.prodProximosAVencerToolStripMenuItem.Name = "prodProximosAVencerToolStripMenuItem";
            this.prodProximosAVencerToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.prodProximosAVencerToolStripMenuItem.Text = "Prod. Proximos a Vencer";
            // 
            // prodMenosExistenciasToolStripMenuItem
            // 
            this.prodMenosExistenciasToolStripMenuItem.Name = "prodMenosExistenciasToolStripMenuItem";
            this.prodMenosExistenciasToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.prodMenosExistenciasToolStripMenuItem.Text = "Prod. Menos Existencias";
            // 
            // prodMasMovidosToolStripMenuItem
            // 
            this.prodMasMovidosToolStripMenuItem.Name = "prodMasMovidosToolStripMenuItem";
            this.prodMasMovidosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.prodMasMovidosToolStripMenuItem.Text = "Prod. Mas Movidos";
            // 
            // ventasDelMesToolStripMenuItem
            // 
            this.ventasDelMesToolStripMenuItem.Name = "ventasDelMesToolStripMenuItem";
            this.ventasDelMesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ventasDelMesToolStripMenuItem.Text = "Ventas del Mes";
            // 
            // comprasDelMesToolStripMenuItem
            // 
            this.comprasDelMesToolStripMenuItem.Name = "comprasDelMesToolStripMenuItem";
            this.comprasDelMesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.comprasDelMesToolStripMenuItem.Text = "Compras del Mes";
            // 
            // descuentosToolStripMenuItem
            // 
            this.descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            this.descuentosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.descuentosToolStripMenuItem.Text = "Descuentos";
            // 
            // productoToolStripMenuItem1
            // 
            this.productoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vencidosToolStripMenuItem,
            this.kardexToolStripMenuItem,
            this.disponibilidadToolStripMenuItem,
            this.proveedorToolStripMenuItem});
            this.productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            this.productoToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.productoToolStripMenuItem1.Text = "Producto";
            // 
            // vencidosToolStripMenuItem
            // 
            this.vencidosToolStripMenuItem.Name = "vencidosToolStripMenuItem";
            this.vencidosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.vencidosToolStripMenuItem.Text = "Vencidos";
            this.vencidosToolStripMenuItem.Click += new System.EventHandler(this.vencidosToolStripMenuItem_Click);
            // 
            // kardexToolStripMenuItem
            // 
            this.kardexToolStripMenuItem.Name = "kardexToolStripMenuItem";
            this.kardexToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.kardexToolStripMenuItem.Text = "Kardex";
            // 
            // disponibilidadToolStripMenuItem
            // 
            this.disponibilidadToolStripMenuItem.Name = "disponibilidadToolStripMenuItem";
            this.disponibilidadToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.disponibilidadToolStripMenuItem.Text = "Disponibilidad";
            this.disponibilidadToolStripMenuItem.Click += new System.EventHandler(this.disponibilidadToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click_1);
            // 
            // proveedorToolStripMenuItem1
            // 
            this.proveedorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditoToolStripMenuItem});
            this.proveedorToolStripMenuItem1.Name = "proveedorToolStripMenuItem1";
            this.proveedorToolStripMenuItem1.Size = new System.Drawing.Size(73, 20);
            this.proveedorToolStripMenuItem1.Text = "Proveedor";
            // 
            // creditoToolStripMenuItem
            // 
            this.creditoToolStripMenuItem.Name = "creditoToolStripMenuItem";
            this.creditoToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.creditoToolStripMenuItem.Text = "Datos";
            this.creditoToolStripMenuItem.Click += new System.EventHandler(this.creditoToolStripMenuItem_Click);
            // 
            // verInventarioToolStripMenuItem
            // 
            this.verInventarioToolStripMenuItem.Name = "verInventarioToolStripMenuItem";
            this.verInventarioToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.verInventarioToolStripMenuItem.Text = "Ver Inventario";
            this.verInventarioToolStripMenuItem.Click += new System.EventHandler(this.verInventarioToolStripMenuItem_Click);
            // 
            // descuentosToolStripMenuItem1
            // 
            this.descuentosToolStripMenuItem1.Name = "descuentosToolStripMenuItem1";
            this.descuentosToolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.descuentosToolStripMenuItem1.Text = "Descuentos";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kardexGeneralToolStripMenuItem,
            this.kardexPorProductoToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.repProductosVencidosToolStripMenuItem});
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // kardexGeneralToolStripMenuItem
            // 
            this.kardexGeneralToolStripMenuItem.Name = "kardexGeneralToolStripMenuItem";
            this.kardexGeneralToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.kardexGeneralToolStripMenuItem.Text = "Kardex General";
            // 
            // kardexPorProductoToolStripMenuItem
            // 
            this.kardexPorProductoToolStripMenuItem.Name = "kardexPorProductoToolStripMenuItem";
            this.kardexPorProductoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.kardexPorProductoToolStripMenuItem.Text = "Kardex Por Producto";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // repProductosVencidosToolStripMenuItem
            // 
            this.repProductosVencidosToolStripMenuItem.Name = "repProductosVencidosToolStripMenuItem";
            this.repProductosVencidosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.repProductosVencidosToolStripMenuItem.Text = "Rep. Productos Vencidos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem1});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem1.Text = "Producto";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::El_Buen_Precio.Properties.Resources.EL_BUEN_PRECIOrealArreglado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 586);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem registarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vencidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kardexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kardexGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kardexPorProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repProductosVencidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodProximosAVencerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodMenosExistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodMasMovidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasDelMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasDelMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentosToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem distribuidoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventaFacturadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
    }
}

