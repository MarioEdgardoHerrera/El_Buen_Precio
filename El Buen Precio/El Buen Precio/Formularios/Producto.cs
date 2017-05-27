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
    public partial class Producto : MetroFramework.Forms.MetroForm
    {
        public Producto()
        {
            InitializeComponent();
            ListarProveedor();
            ListarCategoria();
        }
        public class ProveedorLista
        {
            public int Id { get; set; }
            public string Value { get; set; }
        }

        public List<ProveedorLista> proveedorLista = new List<ProveedorLista>();

        public void ListarProveedor()
        {
            string query = "SELECT id, nombre FROM proveedores";
            MySqlCommand cmd = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());

            try
            {
                proveedorLista.Clear();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    proveedorLista.Add(new ProveedorLista
                    {
                        Id = reader.GetInt32("id"),
                        Value = reader.GetString("nombre")
                    });
                }
                comboBox_proveedor.DataSource = proveedorLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo cargar los proveedores" + ex);
            }
        }
        public class CategoriaLista
        {
            public int Id { get; set; }
            public string Value { get; set; }
        }

        public List<CategoriaLista> categoriaLista = new List<CategoriaLista>();

        public void ListarCategoria()
        {
            string query = "SELECT id, nombre FROM categorias";
            MySqlCommand cmd = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());

            try
            {
                categoriaLista.Clear();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categoriaLista.Add(new CategoriaLista
                    {
                        Id = reader.GetInt32("id"),
                        Value = reader.GetString("nombre")
                    });
                }
                comboBox_categoria.DataSource = categoriaLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo cargar las categorias" + ex);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cl_producto pcl_producto = new cl_producto();
                pcl_producto.Nombre_Producto = textBox1.Text.Trim();
                pcl_producto.Precio_Compra = precio_compra.Value;
                pcl_producto.Precio_Venta = precio_venta.Value;
              
                if (comboBox_proveedor.Text != "") pcl_producto.Proveedor_id = Convert.ToInt32(comboBox_proveedor.SelectedValue);

                if (comboBox_categoria.Text != "") pcl_producto.Categoria_id = Convert.ToInt32(comboBox_categoria.SelectedValue);

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
            catch
            {
                MessageBox.Show("Uno o varios valores no son correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventario Regresar = new Inventario();
            Regresar.Show();
            this.Hide();
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
