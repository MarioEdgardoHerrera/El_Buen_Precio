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
    public partial class Disponibilidad : MetroFramework.Forms.MetroForm
    {
        public Disponibilidad()
        {
            InitializeComponent();
        }

        Bd_Distribuidora conec = new Bd_Distribuidora();
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=distribuidora_el_buen_precio; Uid=root; pwd=;");

            conectar.Open();
            string buscar_pro = "SELECT producto.nombre_producto, producto.precio_venta, inventario.producto_id, inventario.cantidad FROM inventario INNER JOIN producto ON inventario.producto_id = producto.id WHERE producto.nombre_producto LIKE '"+textBox1.Text+"%'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(buscar_pro, conectar);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conectar.Close();
        }
    }
}
