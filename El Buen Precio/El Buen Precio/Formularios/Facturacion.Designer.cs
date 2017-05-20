namespace El_Buen_Precio
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.label1 = new System.Windows.Forms.Label();
            this.button_agregar = new System.Windows.Forms.Button();
            this.button_quitar = new System.Windows.Forms.Button();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.dt_factura_productos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_facturas = new System.Windows.Forms.ComboBox();
            this.dt_productos = new System.Windows.Forms.DataGridView();
            this.btn_seleccionar_factura = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.num_cantidad = new System.Windows.Forms.NumericUpDown();
            this.txt_salida = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_factura_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // button_agregar
            // 
            this.button_agregar.Enabled = false;
            this.button_agregar.Location = new System.Drawing.Point(202, 400);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(75, 28);
            this.button_agregar.TabIndex = 1;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // button_quitar
            // 
            this.button_quitar.Location = new System.Drawing.Point(491, 400);
            this.button_quitar.Name = "button_quitar";
            this.button_quitar.Size = new System.Drawing.Size(75, 28);
            this.button_quitar.TabIndex = 2;
            this.button_quitar.Text = "Quitar";
            this.button_quitar.UseVisualStyleBackColor = true;
            this.button_quitar.Click += new System.EventHandler(this.button_quitar_Click);
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Enabled = false;
            this.textBox_buscar.Location = new System.Drawing.Point(57, 65);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(220, 20);
            this.textBox_buscar.TabIndex = 4;
            this.textBox_buscar.TextChanged += new System.EventHandler(this.textBox_buscar_TextChanged);
            // 
            // dt_factura_productos
            // 
            this.dt_factura_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_factura_productos.Location = new System.Drawing.Point(283, 91);
            this.dt_factura_productos.MultiSelect = false;
            this.dt_factura_productos.Name = "dt_factura_productos";
            this.dt_factura_productos.ReadOnly = true;
            this.dt_factura_productos.Size = new System.Drawing.Size(491, 303);
            this.dt_factura_productos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Productos Facturados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Realizar Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_facturas
            // 
            this.comboBox_facturas.DisplayMember = "Value";
            this.comboBox_facturas.FormattingEnabled = true;
            this.comboBox_facturas.Location = new System.Drawing.Point(161, 29);
            this.comboBox_facturas.Name = "comboBox_facturas";
            this.comboBox_facturas.Size = new System.Drawing.Size(162, 21);
            this.comboBox_facturas.TabIndex = 8;
            this.comboBox_facturas.ValueMember = "Id";
            // 
            // dt_productos
            // 
            this.dt_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_productos.Location = new System.Drawing.Point(14, 91);
            this.dt_productos.MultiSelect = false;
            this.dt_productos.Name = "dt_productos";
            this.dt_productos.ReadOnly = true;
            this.dt_productos.Size = new System.Drawing.Size(263, 303);
            this.dt_productos.TabIndex = 9;
            // 
            // btn_seleccionar_factura
            // 
            this.btn_seleccionar_factura.Location = new System.Drawing.Point(329, 29);
            this.btn_seleccionar_factura.Name = "btn_seleccionar_factura";
            this.btn_seleccionar_factura.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar_factura.TabIndex = 10;
            this.btn_seleccionar_factura.Text = "Seleccionar";
            this.btn_seleccionar_factura.UseVisualStyleBackColor = true;
            this.btn_seleccionar_factura.Click += new System.EventHandler(this.btn_seleccionar_factura_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad";
            // 
            // num_cantidad
            // 
            this.num_cantidad.Enabled = false;
            this.num_cantidad.Location = new System.Drawing.Point(76, 403);
            this.num_cantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_cantidad.Name = "num_cantidad";
            this.num_cantidad.Size = new System.Drawing.Size(120, 20);
            this.num_cantidad.TabIndex = 12;
            this.num_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_salida
            // 
            this.txt_salida.Enabled = false;
            this.txt_salida.Location = new System.Drawing.Point(554, 32);
            this.txt_salida.Name = "txt_salida";
            this.txt_salida.Size = new System.Drawing.Size(220, 20);
            this.txt_salida.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_salida);
            this.Controls.Add(this.num_cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_seleccionar_factura);
            this.Controls.Add(this.dt_productos);
            this.Controls.Add(this.comboBox_facturas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_factura_productos);
            this.Controls.Add(this.textBox_buscar);
            this.Controls.Add(this.button_quitar);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dt_factura_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Button button_quitar;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.DataGridView dt_factura_productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_facturas;
        private System.Windows.Forms.DataGridView dt_productos;
        private System.Windows.Forms.Button btn_seleccionar_factura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_cantidad;
        private System.Windows.Forms.TextBox txt_salida;
        private System.Windows.Forms.Button button2;
    }
}