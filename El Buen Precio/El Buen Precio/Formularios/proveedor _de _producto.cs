using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace El_Buen_Precio
{
    public partial class proveedor__de__producto : MetroFramework.Forms.MetroForm
    {
        public proveedor__de__producto()
        {
            InitializeComponent();
        }
        Bd_Distribuidora conec = new Bd_Distribuidora();
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=distribuidora_el_buen_precio; Uid=root; pwd=;");

            conectar.Open();
            string buscar_pro_pru = "SELECT proveedores.nombre, proveedores.id_distribuidora, producto.nombre_producto, producto.id, producto.precio_compra, producto.fecha_creacion FROM proveedores INNER JOIN producto ON producto.proveedor_id = proveedores.id WHERE producto.nombre_producto LIKE '" + textBox1.Text + "%'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(buscar_pro_pru, conectar);
            DataTable dtp = new DataTable();
            adaptador.Fill(dtp);
            dataGridView1.DataSource = dtp;
            conectar.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}