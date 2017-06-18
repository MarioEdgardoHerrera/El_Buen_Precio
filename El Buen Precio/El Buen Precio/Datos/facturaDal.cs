using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace El_Buen_Precio
{
    class facturaDal
    {
        public static string CrearFactura(factura Factura)
        {
            string retorno = "No se ha realizado ninguna acción";

            string query = "INSERT INTO facturas(cliente) VALUES(@fcliente)";
            MySqlCommand cmd = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());
            cmd.Parameters.AddWithValue("@fcliente", Factura.cliente);

            // Ejecutar el comando 
            try
            {
                cmd.ExecuteNonQuery();
                retorno = "Se abrió una factura para: " + Factura.cliente;
            }
            // Si falla retornar un mensaje
            catch (MySqlException)
            {
                retorno = "Ocurrió un error al crear la factura";
            }

            return retorno;
        }

        public static string AgregarProductos(factura_productos FacturaProductos)
        {
            string retorno = "No se ha realizado ninguna acción";

            string query = "INSERT INTO factura_productos(produto_id, factura_id, cantidad)VALUES(@producto,@factura,@cant)";
            MySqlCommand cmd = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());
            cmd.Parameters.AddWithValue("@producto", FacturaProductos.producto_id);
            cmd.Parameters.AddWithValue("@factura", FacturaProductos.factura_id);
            cmd.Parameters.AddWithValue("@cantidad", FacturaProductos.cantidad);

            try
            {
                cmd.ExecuteNonQuery();
                retorno = "Se agregó el artículo a la factura";
            }
            catch (MySqlException)
            {

                retorno = "Ocurrió un error al agregar el artículo";
            }
            return retorno;
        }

        /// <summary>
        /// Retorna una tabla con los productos incluidos en la factura
        /// </summary>
        /// <param name="factura_id"></param>
        /// <param name="factura_producto_id"></param>
        /// <returns></returns>
        public static DataTable ProductosFactura(int id)
        {
            DataTable dt = new DataTable(); ;

            string query = @"SELECT `producto`.`nombre_producto`, `facturas`.`cliente`, 
                            `factura_productos`.`cantidad`, `producto`.`precio_venta` as precio,
                            factura_productos.`id` as codigo, `cantidad`*`precio_venta` as `subtotal`

                            FROM `producto`
                            LEFT JOIN `factura_productos` ON `producto`.`id` = `factura_productos`.`producto_id` 
                            LEFT JOIN `facturas` ON `factura_productos`.`factura_id` = @IdFactura 
                            where facturas.id = @IdFactura;";

            MySqlDataAdapter da = new MySqlDataAdapter(query, Bd_Distribuidora.ObtenerConexion());
            da.SelectCommand.Parameters.AddWithValue("@IdFactura", id);

            try
            {
                da.Fill(dt);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ocurrió un error ");
            }
            return dt;
        }

        public static DataTable ListaProductos()
        {
            DataTable dt = new DataTable();
            string query = "SELECT nombre_producto as nombre, id as codigo FROM distribuidora_el_buen_precio.producto;";
            MySqlDataAdapter da = new MySqlDataAdapter(query, Bd_Distribuidora.ObtenerConexion());

            try
            {
                da.Fill(dt);
                Console.WriteLine("leídos todos los productos del la base de datos");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al cargar los productos");
            }

            return dt;
        }

        public static string QuitarProducto(int id_producto)
        {
            string info = "";
            string query = "DELETE FROM `factura_productos` WHERE `id`= @id_producto";
            MySqlCommand cmd = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());
            cmd.Parameters.AddWithValue("@id_producto", id_producto);

            try
            {
                cmd.ExecuteNonQuery();
                info = "Se eliminó el producto de la factura";
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al eliminar el artículo");
            }
            return info;
        }

        public static void VenderProducto(int id, decimal cantidad, decimal total)
        {
            string query = "INSERT INTO `distribuidora_el_buen_precio`.`ventas` (`articulo_id`, `cantidad`, `total`) VALUES (@articulo, @cant, @totl);";
            MySqlCommand cmd = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());
            cmd.Parameters.AddWithValue("@articulo", id);
            cmd.Parameters.AddWithValue("@cant", cantidad);
            cmd.Parameters.AddWithValue("@totl", total);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Ocurrio un error al realizar la venta: " + ex);
            }

        }

        public static string FacturarProductos(int id)
        {
            DataTable dt = ProductosFactura(id);
            foreach (DataRow row in dt.Rows)
            {
                int codigo = row.Field<int>("codigo");
                decimal cantidad = row.Field<decimal>("cantidad");
                decimal precio = row.Field<decimal>("precio");
                // Calcular el total
                decimal total = (precio * cantidad);

                VenderProducto(codigo, cantidad, total);
            }

            // Marcar la factura como cerrada
            string query = "UPDATE `distribuidora_el_buen_precio`.`facturas` SET `estado`='1' WHERE `id`= @id_factura;";
            MySqlCommand cmd = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());
            cmd.Parameters.AddWithValue("@id_factura", id);
            cmd.ExecuteNonQuery();

            return "Listo!";
        }
    }
}
