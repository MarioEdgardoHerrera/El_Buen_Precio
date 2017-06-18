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
    public partial class Facturacion : MetroFramework.Forms.MetroForm
    {

         /* 
         * Almacenar una lista de los productos 
         */
        // Clase para definir los elementos de la lista
        public class ProductoLista
        {
            public int Id;
            public string Value;
        }
        //La lista de productos
        public List<ProductoLista> productoLista = new List<ProductoLista>();

        /*
         * Almacenar en una lista las facturas abiertas
         */
        public class FacturasLista
        {
            public int Id { get; set; }
            public string Value { get; set; }
        }
        //La lista de facturas
        public List<FacturasLista>facturasLista = new List<FacturasLista>();


        public Facturacion()
        {
            InitializeComponent();
            ListaFacturasAbiertas();
            dt_productos.DataSource = facturaDal.ListaProductos();
        }

        factura Factura = new factura();

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            BuscarArticulos(textBox_buscar.Text);
        }

        public void BuscarArticulos(string busqueda)
        {
            string query = "SELECT nombre_producto as nombre, id as codigo FROM distribuidora_el_buen_precio.producto where nombre_producto LIKE '%" + busqueda + "%';";

            DataTable data_table = new DataTable();
            MySqlDataAdapter dt = new MySqlDataAdapter(query, Bd_Distribuidora.ObtenerConexion());

            try
            {
                dt.Fill(data_table);
                dt_productos.DataSource = data_table;
            }
            catch
            {
                MessageBox.Show("no se pudo realizar la acción");
            }
        }

        public void ListaFacturasAbiertas()
        {
            string query = "SELECT * FROM distribuidora_el_buen_precio.facturas where estado = 0 ;";

            MySqlCommand cmd = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());

            try
            {
                facturasLista.Clear();

                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    facturasLista.Add(new FacturasLista
                    {
                        Id = Reader.GetInt32("id"),
                        Value = Reader.GetString("cliente")
                    });
                }
                // Pasarle los datos al listbox
                comboBox_facturas.DataSource = facturasLista;
            }
            catch (MySqlException)
            {
                MessageBox.Show("no se pudo realizar la acción");
            }
        }

        private void btn_seleccionar_factura_Click(object sender, EventArgs e)
        {
            int id_factura = Convert.ToInt32(comboBox_facturas.SelectedValue);
            dt_factura_productos.DataSource = facturaDal.ProductosFactura(id_factura);
            Factura.id = id_factura;
            textBox_buscar.Enabled = true;
            num_cantidad.Enabled = true;
            button_agregar.Enabled = true;
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            int c_producto = 0;
            string query = @"INSERT INTO factura_productos(factura_id, producto_id, cantidad)
                             VALUES(@factura, @producto, @cantidad)";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());

                if (dt_productos.SelectedCells.Count > 0)
                {
                    // Basicamente esto obtiene el id del item seleccionado en el datagrid
                    int selectedrowindex = dt_productos.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dt_productos.Rows[selectedrowindex];
                    c_producto = Convert.ToInt32(selectedRow.Cells["codigo"].Value);
                }

                cmd.Parameters.AddWithValue("@factura", Factura.id);
                cmd.Parameters.AddWithValue("@producto", c_producto);
                cmd.Parameters.AddWithValue("@cantidad", num_cantidad.Value);
                cmd.ExecuteNonQuery();

                txt_salida.Text = "Se agregó con éxito";

            }
            catch (Exception)
            {
                MessageBox.Show("no se pudo realizar la acción");
            }
            finally
            {
                dt_factura_productos.DataSource = facturaDal.ProductosFactura(Factura.id);
            }
        }

        private void button_quitar_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dt_factura_productos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dt_factura_productos.Rows[selectedrowindex];
            int c_producto = Convert.ToInt32(selectedRow.Cells["codigo"].Value);

            txt_salida.Text = facturaDal.QuitarProducto(c_producto);
            dt_factura_productos.DataSource = facturaDal.ProductosFactura(Factura.id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                facturaDal.FacturarProductos(Factura.id);
                txt_salida.Text = "Se cobró la factura";

                comboBox_facturas.DataSource = null;
            }
            catch (Exception)
            {
                MessageBox.Show("no se pudo realizar la acción");
            }
            finally
            {
                dt_factura_productos.DataSource = new DataTable();
                ListaFacturasAbiertas();
                comboBox_facturas.ValueMember = "Id";
                comboBox_facturas.DisplayMember = "Value";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            venta_cliente Regresar = new venta_cliente();
            Regresar.Show();
            this.Hide();
        }

        private void text_total_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
