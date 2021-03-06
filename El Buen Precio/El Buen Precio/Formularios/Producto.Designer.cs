﻿namespace El_Buen_Precio
{
    partial class Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.comboBox_proveedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.precio_venta = new System.Windows.Forms.NumericUpDown();
            this.precio_compra = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precio_venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_compra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_categoria);
            this.groupBox1.Controls.Add(this.comboBox_proveedor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.precio_venta);
            this.groupBox1.Controls.Add(this.precio_compra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.DisplayMember = "Value";
            this.comboBox_categoria.FormattingEnabled = true;
            this.comboBox_categoria.Location = new System.Drawing.Point(96, 160);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.comboBox_categoria.Size = new System.Drawing.Size(121, 21);
            this.comboBox_categoria.TabIndex = 8;
            this.comboBox_categoria.ValueMember = "Id";
            // 
            // comboBox_proveedor
            // 
            this.comboBox_proveedor.DisplayMember = "Value";
            this.comboBox_proveedor.FormattingEnabled = true;
            this.comboBox_proveedor.Location = new System.Drawing.Point(96, 122);
            this.comboBox_proveedor.Name = "comboBox_proveedor";
            this.comboBox_proveedor.Size = new System.Drawing.Size(121, 21);
            this.comboBox_proveedor.TabIndex = 1;
            this.comboBox_proveedor.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Proveedor";
            // 
            // precio_venta
            // 
            this.precio_venta.Location = new System.Drawing.Point(97, 87);
            this.precio_venta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.precio_venta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.Size = new System.Drawing.Size(120, 20);
            this.precio_venta.TabIndex = 4;
            this.precio_venta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // precio_compra
            // 
            this.precio_compra.Location = new System.Drawing.Point(97, 51);
            this.precio_compra.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.precio_compra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.precio_compra.Name = "precio_compra";
            this.precio_compra.Size = new System.Drawing.Size(120, 20);
            this.precio_compra.TabIndex = 3;
            this.precio_compra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Precio Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Compra";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 311);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Producto";
            this.Text = "Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precio_venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_compra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown precio_venta;
        private System.Windows.Forms.NumericUpDown precio_compra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.ComboBox comboBox_proveedor;
    }
}