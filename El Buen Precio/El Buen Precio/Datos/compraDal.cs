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
            string query = "INSERT INTO `distribuidora_el_buen_precio`.`compra_productos` (`emplado_id`, `cantidad`, `inventario_id`, `fecha_compra`,`fecha_vencimiento`) VALUES (@empleado, @cantidad, @inventario, @fecha, @fecha_venci);";

            MySqlCommand comando = new MySqlCommand(query,Bd_Distribuidora.ObtenerConexion());
            comando.Parameters.AddWithValue("@empleado", 1);
            comando.Parameters.AddWithValue("@cantidad", pcompra.Cantidad);
            comando.Parameters.AddWithValue("@inventario", pcompra.Inventario_id);
            comando.Parameters.AddWithValue("@fecha",pcompra.fecha_compra.Date);
            comando.Parameters.AddWithValue("@fecha_venci", pcompra.fecha_vencimiento.Date);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}