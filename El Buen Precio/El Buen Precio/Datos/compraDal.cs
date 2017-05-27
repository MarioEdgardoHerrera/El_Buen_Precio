using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace El_Buen_Precio
{
    class compraDal
    {
        public static int agregar(compras pcompra)
        {

            int retorno = 0;
            string query = @"INSERT INTO `distribuidora_el_buen_precio`.`compra_productos` (`emplado_id`, `cantidad`, `product_id`, `fecha_compra`,`fecha_vencimiento`)
                             VALUES (@empleado, @cantidad, @product, @fecha, @fecha_venci);";

            string query2 = @"UPDATE `distribuidora_el_buen_precio`.`inventario` SET `cantidad`= cantidad+@cantidad WHERE `producto_id`=@product_id;";

            MySqlCommand comando = new MySqlCommand(query,Bd_Distribuidora.ObtenerConexion());
            comando.Parameters.AddWithValue("@empleado", 1);
            comando.Parameters.AddWithValue("@cantidad", pcompra.Cantidad);
            comando.Parameters.AddWithValue("@product", pcompra.Product_id);
            comando.Parameters.AddWithValue("@fecha",pcompra.fecha_compra.Date);
            comando.Parameters.AddWithValue("@fecha_venci", pcompra.fecha_vencimiento.Date);
            retorno = comando.ExecuteNonQuery();

            MySqlCommand cmd = new MySqlCommand(query2, Bd_Distribuidora.ObtenerConexion());
            cmd.Parameters.AddWithValue("@cantidad", pcompra.Cantidad);
            cmd.Parameters.AddWithValue("@product_id", pcompra.Product_id);
            cmd.ExecuteNonQuery();

            return retorno;
        }
    }
}