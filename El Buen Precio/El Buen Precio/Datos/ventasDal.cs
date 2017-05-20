using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace El_Buen_Precio
{
    class ventasDal
    {
        public static int agregar(ventas pventas)
        {

            int retorno = 0;
            string query = "INSERT INTO `distribuidora_el_buen_precio`.`ventas` (`articulo_id`, `cantidad`) VALUES (@articulo, @cantidad);";

            MySqlCommand comando = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());
            comando.Parameters.AddWithValue("@articulo", pventas.articulo_id);
            comando.Parameters.AddWithValue("@cantidad", pventas.cantidad);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
