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
using MySql.Data.MySqlClient;

namespace El_Buen_Precio
{
    public partial class Compra : MetroFramework.Forms.MetroForm
    {
        public Compra()
        {
            InitializeComponent();
            ListarProductos();

        }

        public class ProductoLista
        {
            public int Id { get; set; }
            public string Value { get; set; }
        }

        public List<ProductoLista>productoLista = new List<ProductoLista>();
        
        public void ListarProductos()
        {
            string query = "SELECT id, nombre_producto FROM producto";
            MySqlCommand cmd = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());

            try
            {
                productoLista.Clear();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productoLista.Add(new ProductoLista
                    {
                        Id = reader.GetInt32("id"),
                        Value = reader.GetString("nombre_producto")
                    });
                }
                comboBox1.DataSource = productoLista;
            }
            catch(Exception ex)
            {
                MessageBox.Show("no se pudo cargar los productos" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compras pcompra = new compras();
            pcompra.Product_id = Convert.ToInt32(comboBox1.SelectedValue);
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
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
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
