using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace El_Buen_Precio
{
    class cl_productoDal
    {
        public static int agregar(cl_producto pcl_producto)
        {

            int retorno = 0;

            string query = @"INSERT INTO `distribuidora_el_buen_precio`.`producto`(`nombre_producto`, `proveedor_id`, `precio_compra`, 
                            `precio_venta`, `categoria_id`) VALUES (@nombre, @prov_id, @precio_compra, @precio_venta, @cat_id);";

            MySqlCommand comando = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());
            comando.Parameters.AddWithValue("@nombre", pcl_producto.Nombre_Producto);
            comando.Parameters.AddWithValue("@prov_id", pcl_producto.Proveedor_id);
            comando.Parameters.AddWithValue("@precio_compra", pcl_producto.Precio_Compra);
            comando.Parameters.AddWithValue("@precio_venta", pcl_producto.Precio_Venta);
            comando.Parameters.AddWithValue("@cat_id", pcl_producto.Categoria_id);

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        
    }
}
