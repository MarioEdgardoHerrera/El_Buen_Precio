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
    public partial class Proveedores : MetroFramework.Forms.MetroForm
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bd_Distribuidora.ObtenerConexion();
            MessageBox.Show("conectado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
              proveedor pproveedores = new proveedor();
            pproveedores.Nombre_Proveedor = textBox1.Text.Trim();
            pproveedores.Apellido_Proveedor = textBox2.Text.Trim();
            pproveedores.Numero_Telf_Proveedor = Convert.ToInt32(textBox3.Text.Trim());

            int resultado = proveedoresDal.agregar(pproveedores);
            if (resultado > 0)
            {
                MessageBox.Show("Proveedor Guardado con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Proveedor", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
    }
}
