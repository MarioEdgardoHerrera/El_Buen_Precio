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
using MySql.Data.MySqlClient;

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
            string buscar_pro = "select `distribuidora_el_buen_precio`.`compra_productos`.`cantidad` AS `cantidad`,`distribuidora_el_buen_precio`.`compra_productos`.`product_id` AS `product_id`,`distribuidora_el_buen_precio`.`compra_productos`.`fecha_vencimiento` AS `fecha_vencimiento`,`distribuidora_el_buen_precio`.`inventario`.`producto_id` AS `producto_id`,`distribuidora_el_buen_precio`.`producto`.`nombre_producto` AS `nombre_producto` from((`distribuidora_el_buen_precio`.`compra_productos` join `distribuidora_el_buen_precio`.`inventario` on((`distribuidora_el_buen_precio`.`compra_productos`.`product_id` = `distribuidora_el_buen_precio`.`inventario`.`producto_id`)))  join `distribuidora_el_buen_precio`.`producto`  on((`distribuidora_el_buen_precio`.`inventario`.`producto_id` = `distribuidora_el_buen_precio`.`producto`.`id`))) WHERE `compra_productos`.`fecha_vencimiento` <= CURDATE()";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Inventario Regresar = new Inventario();
            Regresar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            int id_producto = Convert.ToInt32(selectedRow.Cells["producto_id"].Value);

            string query = "DELETE FROM `producto` WHERE `id`= "+id_producto+";";
            MySqlCommand cmd1 = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());

            string query1 = "DELETE FROM `inventario` WHERE `id`= "+id_producto+";";
            MySqlCommand cmd = new MySqlCommand(query1, Bd_Distribuidora.ObtenerConexion());

            try
            {
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Se dió de baja el producto vencido");
                mostrar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex);

            }
        }
    }
}
