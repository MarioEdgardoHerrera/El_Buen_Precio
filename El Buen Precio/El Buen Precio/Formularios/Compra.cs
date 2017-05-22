using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace El_Buen_Precio
{
    public partial class Compra : MetroFramework.Forms.MetroForm
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compras pcompra = new compras();
            pcompra.Inventario_id = Convert.ToInt32(txt_producto.Text.Trim());
            pcompra.Cantidad = Convert.ToInt32(txt_cantidad.Text.Trim());
            pcompra.fecha_compra = dateTimePicker1.Value;
            pcompra.fecha_vencimiento = dateTimePicker2.Value;

            int resultado = compraDal.agregar(pcompra);
            if (resultado > 0)
            {
                MessageBox.Show("Compra Registrada con Exito!!", "Reguistrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo Pudo Reguistrar la Compra", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            compras pcompra = new compras();
            pcompra.Inventario_id = Convert.ToInt32(txt_producto.Text.Trim());
        }
    }
}
