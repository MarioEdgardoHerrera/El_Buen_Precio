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
    public partial class venta_cliente : MetroFramework.Forms.MetroForm
    {
        public venta_cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            venta_clientes pClientes = new venta_clientes();
            pClientes.Cliente = textBox1.Text.Trim();


            int resultado = venta_clientesDal.agregar(pClientes);
            if (resultado > 0)
            {
                MessageBox.Show("Agregado con Exito!!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo agregar", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Facturacion Nuevo = new Facturacion();         
            Nuevo.Show();
            this.Hide();

        }
    }
}
