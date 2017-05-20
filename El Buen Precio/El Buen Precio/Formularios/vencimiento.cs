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
    public partial class vencimiento : MetroFramework.Forms.MetroForm
    {
        public vencimiento()
        {
            InitializeComponent();
        }

        Bd_Distribuidora conec = new Bd_Distribuidora();
        private void mostrar ()        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=distribuidora_el_buen_precio; Uid=root; pwd=;");

            conectar.Open();
            string buscar_pro = "SELECT compra_productos.cantidad, compra_productos.inventario_id, compra_productos.fecha_vencimiento, inventario.producto_id, producto.nombre_producto FROM compra_productos INNER JOIN inventario ON compra_productos.inventario_id = inventario.id INNER JOIN producto ON inventario.producto_id = producto.id where CURDATE() >= fecha_vencimiento ";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(buscar_pro, conectar);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conectar.Close();

        }

        private void vencimiento_Load(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
