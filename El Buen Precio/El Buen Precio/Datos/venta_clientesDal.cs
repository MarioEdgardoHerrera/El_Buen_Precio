using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace El_Buen_Precio
{
    class venta_clientesDal
    {
        public static int agregar(venta_clientes pCliente)
        {

            int retorno = 0;

            string query = "INSERT INTO `distribuidora_el_buen_precio`.`facturas` (`cliente`) VALUES (@cliente);";
            MySqlCommand comando = new MySqlCommand(query, Bd_Distribuidora.ObtenerConexion());
            comando.Parameters.AddWithValue("@cliente", pCliente.Cliente);
            retorno = comando.ExecuteNonQuery();
            return retorno;


        }
    }
}
