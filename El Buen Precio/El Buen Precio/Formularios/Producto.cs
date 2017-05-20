using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace El_Buen_Precio
{
    public partial class Producto : MetroFramework.Forms.MetroForm
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl_producto pcl_producto = new cl_producto();
            pcl_producto.Nombre_Producto = textBox1.Text.Trim();
            pcl_producto.Precio_Compra = precio_compra.Value;
            pcl_producto.Precio_Venta = precio_venta.Value;
            pcl_producto.Proveedor_id = Convert.ToInt32(txt_proveedor.Text);
            pcl_producto.Categoria_id = Convert.ToInt32(txt_categoria.Text);

            int resultado = cl_productoDal.agregar(pcl_producto);
            if (resultado > 0)
            {
                MessageBox.Show("Producto Agregado con Exito!!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo agregar el Producto", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
