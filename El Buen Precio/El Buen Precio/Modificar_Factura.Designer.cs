namespace El_Buen_Precio
{
    partial class Modificar_Factura
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_facturas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_facturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar";
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Enabled = false;
            this.textBox_buscar.Location = new System.Drawing.Point(98, 16);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(220, 20);
            this.textBox_buscar.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lista de Facturas";
            // 
            // dt_facturas
            // 
            this.dt_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_facturas.Location = new System.Drawing.Point(55, 42);
            this.dt_facturas.MultiSelect = false;
            this.dt_facturas.Name = "dt_facturas";
            this.dt_facturas.ReadOnly = true;
            this.dt_facturas.Size = new System.Drawing.Size(727, 303);
            this.dt_facturas.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Dar de Baja";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cambiar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Modificar_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 404);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dt_facturas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_buscar);
            this.Controls.Add(this.label1);
            this.Name = "Modificar_Factura";
            this.Text = "Modificar_Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dt_facturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dt_facturas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}