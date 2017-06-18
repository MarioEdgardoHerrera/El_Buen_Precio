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
            this.text_total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_pago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_cambio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.factura_id_txt = new System.Windows.Forms.TextBox();
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
            this.button_quitar.Location = new System.Drawing.Point(283, 400);
            this.button_quitar.Name = "button_quitar";
            this.button_quitar.Size = new System.Drawing.Size(126, 28);
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
            this.button1.Location = new System.Drawing.Point(664, 490);
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
            // text_total
            // 
            this.text_total.Location = new System.Drawing.Point(663, 403);
            this.text_total.Name = "text_total";
            this.text_total.ReadOnly = true;
            this.text_total.Size = new System.Drawing.Size(100, 20);
            this.text_total.TabIndex = 15;
            this.text_total.TextChanged += new System.EventHandler(this.text_total_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total";
            // 
            // text_pago
            // 
            this.text_pago.Location = new System.Drawing.Point(663, 430);
            this.text_pago.Name = "text_pago";
            this.text_pago.Size = new System.Drawing.Size(100, 20);
            this.text_pago.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pago";
            // 
            // text_cambio
            // 
            this.text_cambio.Location = new System.Drawing.Point(663, 457);
            this.text_cambio.Name = "text_cambio";
            this.text_cambio.Size = new System.Drawing.Size(100, 20);
            this.text_cambio.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(602, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cambio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(551, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Factura #";
            // 
            // factura_id_txt
            // 
            this.factura_id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factura_id_txt.Location = new System.Drawing.Point(619, 65);
            this.factura_id_txt.Name = "factura_id_txt";
            this.factura_id_txt.ReadOnly = true;
            this.factura_id_txt.Size = new System.Drawing.Size(155, 20);
            this.factura_id_txt.TabIndex = 22;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 529);
            this.Controls.Add(this.factura_id_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_cambio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_pago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_total);
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
        private System.Windows.Forms.TextBox text_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_pago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_cambio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox factura_id_txt;
    }
}